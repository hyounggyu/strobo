#define RANDOM

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using NationalInstruments.Vision;
using NationalInstruments.Vision.Acquisition.Imaq;
using NationalInstruments.DAQmx;


namespace strobo
{
    public partial class Form1 : Form
    {
        private System.ComponentModel.BackgroundWorker acquisitionWorker, renderWorker;
        ConcurrentQueue<PixelValue2D> volumeQueue;

        // IMAQ variables
        private ImaqSession _session = null;
        private ImaqBufferCollection bufList;
        private VisionImage displayImage;

        // DAQ variables
        private AnalogMultiChannelReader analogInReader;
        private Task myTask;
        private string physicalChannelText;
        private double minimumValue;
        private double maximumValue;
        private double rateValue;
        private int    samplesPerChannelValue;

        // Logging
        private StreamWriter sw;

        private struct UIUpdateArgs
        {
            public uint bufferNumber;
            public double voltageValue;

            public UIUpdateArgs(uint _bufferNumber, double _voltageValue)
            {
                bufferNumber = _bufferNumber;
                voltageValue = _voltageValue;
            }
        }

        public Form1()
        {
            InitializeComponent();
            //  Initialize the UI.
            startButton.Enabled = true;
            stopButton.Enabled = false;
            quitButton.Enabled = true;
            //  Set up the acquisition background worker thread.  This thread
            //  will actually acquire the images and issue a callback
            //  to update the UI.
            acquisitionWorker = new System.ComponentModel.BackgroundWorker();
            acquisitionWorker.DoWork += new DoWorkEventHandler(acquisitionWorker_DoWork);
            acquisitionWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(acquisitionWorker_RunWorkerCompleted);
            acquisitionWorker.ProgressChanged += new ProgressChangedEventHandler(acquisitionWorker_ProgressChanged);
            acquisitionWorker.WorkerReportsProgress = true;
            acquisitionWorker.WorkerSupportsCancellation = true;

            renderWorker = new System.ComponentModel.BackgroundWorker();
            renderWorker.DoWork += new DoWorkEventHandler(renderWorker_DoWork);
            renderWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(renderWorker_RunWorkerCompleted);
            renderWorker.ProgressChanged += new ProgressChangedEventHandler(renderWorker_ProgressChanged);
            renderWorker.WorkerReportsProgress = true;
            renderWorker.WorkerSupportsCancellation = true;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
#if DAQTEST
            sw = new StreamWriter( new FileStream("output.dat", FileMode.Create) );
#endif
            try
            {
                //  Update the UI.
                startButton.Enabled = false;
                stopButton.Enabled = true;
                bufNumTextBox.Text = "";
                //pixelValTextBox.Text = "";
#if DAQ
                //// DAQmx START
                // Create a new task
                myTask = new Task();
                physicalChannelText = "Dev1/ai0";
                minimumValue = -10.00;
                maximumValue = 10.00;
                rateValue = 10000.00;
                samplesPerChannelValue = 1000;

                // Create a virtual channel
                myTask.AIChannels.CreateVoltageChannel(physicalChannelText, "",
                    (AITerminalConfiguration)(-1), Convert.ToDouble(minimumValue),
                    Convert.ToDouble(maximumValue), AIVoltageUnits.Volts);

                analogInReader = new AnalogMultiChannelReader(myTask.Stream);

                // Verify the Task
                myTask.Control(TaskAction.Verify);
                //// DAQmx END
#endif
#if IMAQ
                //  Create a session.
                _session = new ImaqSession(interfaceTextBox.Text);

                //  Configure the image viewer.
                displayImage = new VisionImage((ImageType)_session.Attributes[ImaqStandardAttribute.ImageType].GetValue());
                imageViewer.Attach(displayImage);

                //  Create a buffer collection for the acquisition with the requested
                //  number of images, and configure the buffers to loop continuously.
                int numberOfImages = (int)numImages.Value;
                bufList = _session.CreateBufferCollection(numberOfImages, ImaqBufferCollectionType.PixelValue2D);
                for (int i = 0; i < bufList.Count; ++i)
                {
                    bufList[i].Command = (i == bufList.Count - 1) ? ImaqBufferCommand.Loop : ImaqBufferCommand.Next;
                }

                //  Configure and start the acquisition.
                _session.Acquisition.Configure(bufList);
                _session.Acquisition.AcquireAsync();
#endif
                //  Start the background worker thread.
                acquisitionWorker.RunWorkerAsync(subCheckBox);
            }
            catch (ImaqException ex)
            {
                MessageBox.Show(ex.Message, "NI-IMAQ Error");
                Cleanup();
            }
        }


        void acquisitionWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            //  This is the main function of the acquisition background worker thread.
            //  Perform image processing here instead of the UI thread to avoid a
            //  sluggish or unresponsive UI.
            BackgroundWorker worker = (BackgroundWorker)sender;
            byte[] zero = new byte[] { 0 };
            try
            {
#if IMAQ
                PixelValue2D subPixels = new PixelValue2D(new byte[480, 640]);
                uint imgnum = 0;
                int tmp;
                uint bufferNumber = 0, outbufferNumber;
                string pixelValue = "";
                ImageType imageType = (ImageType)_session.Attributes[ImaqStandardAttribute.ImageType].GetValue();

                PixelValue2D prePixels = _session.Acquisition.Extract(bufferNumber, out bufferNumber).ToPixelArray();
                bufferNumber++;
#endif
#if DAQ
                double preVoltage = analogInReader.ReadSingleSample()[0];
                double curVoltage;
#endif
                //  Loop until we tell the thread to cancel or we get an error.  When this
                //  function completes the acquisitionWorker_RunWorkerCompleted method will
                //  be called.
                while (!worker.CancellationPending)
                {
                    //  Get the next image, convert it to a VisionImage and then update the display.
                    //  Extracting an image is a 0-copy operation, and we need to copy the
                    //  image here for display purposes only.  You can perform image processing
                    //  on the extractedImage without having to copy it.
#if IMAQ
                    PixelValue2D curPixels = _session.Acquisition.Extract(bufferNumber, out outbufferNumber).ToPixelArray();
#endif
#if DAQ
                    curVoltage = analogInReader.ReadSingleSample()[0];
#endif
#if IMAQ
                    for (int x = 0; x < 640; x++)
                    {
                        for (int y=0; y < 480; y++)
                        {
                            tmp = (int)curPixels.U8[y,x] - (int)prePixels.U8[y,x];
                            tmp = tmp * tmp;
                            subPixels.U8[y, x] = (byte)(tmp > 255 ? 255 : tmp);
                        }
                    }
                    prePixels = curPixels;
                    if (((CheckBox)e.Argument).Checked)
                    {
                        imageViewer.Image.ArrayToImage(subPixels);
                    }
                    else
                    {
                        imageViewer.Image.ArrayToImage(curPixels);
                    }
                    // Send image
                    // byte[,] 타입을 byte[]로 변경 -> 이거 안 해도 되어야함.
                    byte[] dest = new byte[subPixels.U8.Length];
                    Buffer.BlockCopy(subPixels.U8, 0, dest, 0, subPixels.U8.Length);
#endif
#if DAQ
                    double dvolt = curVoltage - preVoltage;
                    if (dvolt > 0.02)
                    {
                        publisher.SendMore(dest);
                        flagSendMore = true;
                    }
                    else if (flagSendMore)
                    {
                        publisher.Send(zero);

                        // finish
                        flagSendMore = false;
                    }
                    preVoltage = curVoltage;
#endif
#if RANDOM
                    // 여기에 Queue를 넣어야

#endif
                    //  Update the UI by calling ReportProgress on the background worker.
                    //  This will call the acquisition_ProgressChanged method in the UI
                    //  thread, where it is safe to update UI elements.  Do not update UI
                    //  elements directly in this thread as doing so could result in a
                    //  deadlock.
#if DAQ
                    worker.ReportProgress(0, new UIUpdateArgs(outbufferNumber, dvolt));
                    bufferNumber++;
#elif IMAQ
                    worker.ReportProgress(0, new UIUpdateArgs(outbufferNumber, 0));
                    bufferNumber++;
#endif
                }
            }
            catch (ImaqException ex)
            {
                //  If an error occurs and the background worker thread is not being
                //  cancelled, then pass the exception along in the result so that
                //  it can be handled in the acquisition_RunWorkerCompleted method.
                if (!worker.CancellationPending)
                    e.Result = ex;
            }
        }

        void acquisitionWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //  Update the UI with the information passed from the background worker thread.
            UIUpdateArgs updateArgs = (UIUpdateArgs)e.UserState;
            bufNumTextBox.Text = updateArgs.bufferNumber.ToString();
            voltageValTextBox.Text = String.Format("{0,8:0.00000}", updateArgs.voltageValue);
        }

        void acquisitionWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //  The background worker thread has completed its execution.  Perform any cleanup here.
            if (e.Result is ImaqException)
            {
                //  If we get here it means that we had an error in the background worker thread
                //  that we need to handle.
                MessageBox.Show(((ImaqException)e.Result).ToString(), "NI-IMAQ Error");
            }
            Cleanup();
        }

        void renderWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            return;
        }

        void renderWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            return;
        }

        void renderWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            return;
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (_session != null)
                {
                    //  Signal the background worker thread to stop and then stop the acquisition.
                    acquisitionWorker.CancelAsync();
                    _session.Stop();
                }
            }
            catch (ImaqException ex)
            {
                MessageBox.Show(ex.Message, "NI-IMAQ Error");
            }
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            //  Clean up and exit.
            stopButton.PerformClick();
            this.Close();
            Application.Exit();
        }

        private void Cleanup()
        {
            if (_session != null)
            {
                // Close the session.
                _session.Close();
                _session = null;
            }
#if DAQTEST
            sw.Close();
#endif
            //  Update the UI.
            startButton.Enabled = true;
            stopButton.Enabled = false;
        }

    }
}
