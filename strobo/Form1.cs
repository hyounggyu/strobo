using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using NationalInstruments.Vision;
using NationalInstruments.Vision.Acquisition.Imaq;
using NationalInstruments.DAQmx;

using volrender;

namespace strobo
{
    public partial class Form1 : Form
    {
        private System.ComponentModel.BackgroundWorker acquisitionWorker, renderWorker;

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

        // Volume render
        private Render render;

        private struct ImageData
        {
            public byte[,] image;
            public double pos;
        }

        ConcurrentQueue<ImageData> imageDataQueue;

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

            // Set Queue
            imageDataQueue = new ConcurrentQueue<ImageData>();

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
            
            //PixelValue2D a = new PixelValue2D(new Rgb32Value[480, 640]);
            //a.Rgb32[10, 10] = new Rgb32Value(10, 10, 10, 10);

            //PixelValue2D a = new PixelValue2D(new byte[480, 640]);
            //a.U8[10, 10] = 10;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            try
            {
                //  Update the UI.
                startButton.Enabled = false;
                stopButton.Enabled = true;
                bufNumTextBox.Text = "";
                //pixelValTextBox.Text = "";
#if IMAQ
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
                renderWorker.RunWorkerAsync();
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

            // RANDOM
            Random rand = new Random();
            double voltage = 0.0;
            byte[,] im = new byte[480, 640];
            PixelValue2D image = new PixelValue2D(im);
            ImageData imdata;

            try
            {
#if IMAQ
                PixelValue2D subPixels = new PixelValue2D(new byte[480, 640]);
                uint imgnum = 0;
                int tmp;
                uint bufferNumber = 0, outbufferNumber;
                string pixelValue = "";
                ImageType imageType = (ImageType)_session.Attributes[ImaqStandardAttribute.ImageType].GetValue();

                PixelValue2D prePixels = _session.Acquisition.Extract(bufferNumber, out outbufferNumber).ToPixelArray();
                bufferNumber++;

                double preVoltage = analogInReader.ReadSingleSample()[0];
                double curVoltage;
#endif
                //  Loop until we tell the thread to cancel or we get an error.  When this
                //  function completes the acquisitionWorker_RunWorkerCompleted method will
                //  be called.
                while (!worker.CancellationPending)
                {
                    // RANDOM
                    for (int x = 0; x < 640; x++)
                    {
                        for (int y = 0; y < 480; y++)
                        {
                            im[y, x] = (byte)rand.Next(0, 255);
                        }
                    }
                    voltage = voltage + 1.0;
                    imdata.image = im;
                    imdata.pos = voltage;
                    //imageDataQueue.Enqueue(imdata);
                    imageViewer.Image.ArrayToImage(image);

                    //  Get the next image, convert it to a VisionImage and then update the display.
                    //  Extracting an image is a 0-copy operation, and we need to copy the
                    //  image here for display purposes only.  You can perform image processing
                    //  on the extractedImage without having to copy it.
#if IMAQ
                    PixelValue2D curPixels = _session.Acquisition.Extract(bufferNumber, out outbufferNumber).ToPixelArray();
                    curVoltage = analogInReader.ReadSingleSample()[0];

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
                    //byte[] dest = new byte[subPixels.U8.Length];
                    //Buffer.BlockCopy(subPixels.U8, 0, dest, 0, subPixels.U8.Length);

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

                    //  Update the UI by calling ReportProgress on the background worker.
                    //  This will call the acquisition_ProgressChanged method in the UI
                    //  thread, where it is safe to update UI elements.  Do not update UI
                    //  elements directly in this thread as doing so could result in a
                    //  deadlock.
                    worker.ReportProgress(0, new UIUpdateArgs(outbufferNumber, dvolt));
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
            // TODO: Params from UI
            int volume_width = 640;
            int volume_height = 480;
            int volume_depth = 300;
            int image_width = 150;
            int image_height = 150;

            BackgroundWorker worker = (BackgroundWorker)sender;

            Bitmap bitmap = new Bitmap(image_width, image_height, PixelFormat.Format32bppArgb);
            byte[] volume = new byte[volume_width * volume_height * volume_depth];
            int[] image = new int[image_width * image_height];

            render = new Render(volume_width, volume_height, volume_depth, image_width, image_height);
            // TODO: Params from UI
            render.SetParams(0.05f, 1.0f, 0.0f, 1.0f, true);
            render.SetViewMatrix(0.0f, 0.0f, 0.0f, 0.0f, -4.0f);

            int offset = 0;
            ImageData imdata;

            while (!worker.CancellationPending)
            {
                if (!imageDataQueue.TryDequeue(out imdata))
                {
                    continue;
                }

                Buffer.BlockCopy(imdata.image, 0, volume, offset, imdata.image.Length);
                offset += imdata.image.Length;

                if (imdata.pos % 100.0 < 0.001)
                {
                    render.Update(volume, image);

                    for (int x = 0, idx = 0; x < image_width; x++)
                    {
                        for (int y = 0; y < image_height; y++, idx++)
                        {
                            bitmap.SetPixel(x, y, Color.FromArgb(image[idx]));
                        }
                    }
                    pictureBox1.Image = (Image)bitmap;
                    offset = 0;
                }
            }
        }

        void renderWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            return;
        }

        void renderWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            render = null;
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            acquisitionWorker.CancelAsync();
            renderWorker.CancelAsync();

            try
            {
                if (_session != null)
                {
                    //  Signal the background worker thread to stop and then stop the acquisition.
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
            //  Update the UI.
            startButton.Enabled = true;
            stopButton.Enabled = false;
        }

    }
}
