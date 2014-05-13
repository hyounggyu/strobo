namespace strobo
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.imageViewer = new NationalInstruments.Vision.WindowsForms.ImageViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.interfaceTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numImages = new System.Windows.Forms.NumericUpDown();
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.bufNumTextBox = new System.Windows.Forms.TextBox();
            this.quitButton = new System.Windows.Forms.Button();
            this.subCheckBox = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.voltageValTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.volumeDepthTextBox = new System.Windows.Forms.TextBox();
            this.renderPictureBox = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rotxTextBox = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.rotyTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.rotzTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.transxTextBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.transyTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.transzTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.linfilterCheckBox = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.densityTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.brightnessTextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.transoffsetTextBox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.transscaleTextBox = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.label16 = new System.Windows.Forms.Label();
            this.daqInterfaceTextBox = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.thresholdDeltaVoltageTextBox = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.stackedImageTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numImages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.renderPictureBox)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageViewer
            // 
            this.imageViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageViewer.Location = new System.Drawing.Point(12, 11);
            this.imageViewer.Name = "imageViewer";
            this.imageViewer.Size = new System.Drawing.Size(640, 480);
            this.imageViewer.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Interface Name";
            // 
            // interfaceTextBox
            // 
            this.interfaceTextBox.Location = new System.Drawing.Point(109, 3);
            this.interfaceTextBox.Name = "interfaceTextBox";
            this.interfaceTextBox.Size = new System.Drawing.Size(100, 21);
            this.interfaceTextBox.TabIndex = 2;
            this.interfaceTextBox.Text = "img0";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(3, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "# of Images";
            // 
            // numImages
            // 
            this.numImages.Location = new System.Drawing.Point(109, 30);
            this.numImages.Name = "numImages";
            this.numImages.Size = new System.Drawing.Size(100, 21);
            this.numImages.TabIndex = 4;
            this.numImages.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(879, 729);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(87, 21);
            this.startButton.TabIndex = 5;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(972, 729);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(87, 21);
            this.stopButton.TabIndex = 6;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(3, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Buffer Number";
            // 
            // bufNumTextBox
            // 
            this.bufNumTextBox.Location = new System.Drawing.Point(109, 57);
            this.bufNumTextBox.Name = "bufNumTextBox";
            this.bufNumTextBox.Size = new System.Drawing.Size(100, 21);
            this.bufNumTextBox.TabIndex = 8;
            // 
            // quitButton
            // 
            this.quitButton.Location = new System.Drawing.Point(1065, 729);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(87, 21);
            this.quitButton.TabIndex = 9;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // subCheckBox
            // 
            this.subCheckBox.AutoSize = true;
            this.subCheckBox.Location = new System.Drawing.Point(528, 497);
            this.subCheckBox.Name = "subCheckBox";
            this.subCheckBox.Size = new System.Drawing.Size(126, 16);
            this.subCheckBox.TabIndex = 10;
            this.subCheckBox.Text = "Subtraction Image";
            this.subCheckBox.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(3, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Voltage";
            // 
            // voltageValTextBox
            // 
            this.voltageValTextBox.Location = new System.Drawing.Point(109, 30);
            this.voltageValTextBox.Name = "voltageValTextBox";
            this.voltageValTextBox.Size = new System.Drawing.Size(100, 21);
            this.voltageValTextBox.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 669);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 12);
            this.label7.TabIndex = 18;
            this.label7.Text = "Volume Depth";
            // 
            // volumeDepthTextBox
            // 
            this.volumeDepthTextBox.Location = new System.Drawing.Point(127, 666);
            this.volumeDepthTextBox.Name = "volumeDepthTextBox";
            this.volumeDepthTextBox.Size = new System.Drawing.Size(116, 21);
            this.volumeDepthTextBox.TabIndex = 17;
            this.volumeDepthTextBox.Text = "300";
            // 
            // renderPictureBox
            // 
            this.renderPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.renderPictureBox.Location = new System.Drawing.Point(670, 11);
            this.renderPictureBox.Name = "renderPictureBox";
            this.renderPictureBox.Size = new System.Drawing.Size(480, 480);
            this.renderPictureBox.TabIndex = 19;
            this.renderPictureBox.TabStop = false;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Rotation X";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rotxTextBox
            // 
            this.rotxTextBox.Location = new System.Drawing.Point(89, 3);
            this.rotxTextBox.Name = "rotxTextBox";
            this.rotxTextBox.Size = new System.Drawing.Size(80, 21);
            this.rotxTextBox.TabIndex = 20;
            this.rotxTextBox.Text = "0";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label5);
            this.flowLayoutPanel1.Controls.Add(this.rotxTextBox);
            this.flowLayoutPanel1.Controls.Add(this.label8);
            this.flowLayoutPanel1.Controls.Add(this.rotyTextBox);
            this.flowLayoutPanel1.Controls.Add(this.label10);
            this.flowLayoutPanel1.Controls.Add(this.rotzTextBox);
            this.flowLayoutPanel1.Controls.Add(this.label12);
            this.flowLayoutPanel1.Controls.Add(this.transxTextBox);
            this.flowLayoutPanel1.Controls.Add(this.label14);
            this.flowLayoutPanel1.Controls.Add(this.transyTextBox);
            this.flowLayoutPanel1.Controls.Add(this.label6);
            this.flowLayoutPanel1.Controls.Add(this.transzTextBox);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(6, 21);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(180, 160);
            this.flowLayoutPanel1.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(3, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 20);
            this.label8.TabIndex = 25;
            this.label8.Text = "Rotation Y";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rotyTextBox
            // 
            this.rotyTextBox.Location = new System.Drawing.Point(89, 30);
            this.rotyTextBox.Name = "rotyTextBox";
            this.rotyTextBox.Size = new System.Drawing.Size(80, 21);
            this.rotyTextBox.TabIndex = 22;
            this.rotyTextBox.Text = "0";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(3, 54);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 20);
            this.label10.TabIndex = 29;
            this.label10.Text = "Rotation Z";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rotzTextBox
            // 
            this.rotzTextBox.Location = new System.Drawing.Point(89, 57);
            this.rotzTextBox.Name = "rotzTextBox";
            this.rotzTextBox.Size = new System.Drawing.Size(80, 21);
            this.rotzTextBox.TabIndex = 24;
            this.rotzTextBox.Text = "0";
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(3, 81);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 20);
            this.label12.TabIndex = 33;
            this.label12.Text = "Translation X";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // transxTextBox
            // 
            this.transxTextBox.Location = new System.Drawing.Point(89, 84);
            this.transxTextBox.Name = "transxTextBox";
            this.transxTextBox.Size = new System.Drawing.Size(80, 21);
            this.transxTextBox.TabIndex = 28;
            this.transxTextBox.Text = "0";
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(3, 108);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(80, 20);
            this.label14.TabIndex = 37;
            this.label14.Text = "Translation Y";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // transyTextBox
            // 
            this.transyTextBox.Location = new System.Drawing.Point(89, 111);
            this.transyTextBox.Name = "transyTextBox";
            this.transyTextBox.Size = new System.Drawing.Size(80, 21);
            this.transyTextBox.TabIndex = 32;
            this.transyTextBox.Text = "0";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(3, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "Translation Z";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // transzTextBox
            // 
            this.transzTextBox.Location = new System.Drawing.Point(89, 138);
            this.transzTextBox.Name = "transzTextBox";
            this.transzTextBox.Size = new System.Drawing.Size(80, 21);
            this.transzTextBox.TabIndex = 36;
            this.transzTextBox.Text = "4";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.linfilterCheckBox);
            this.groupBox1.Controls.Add(this.flowLayoutPanel2);
            this.groupBox1.Controls.Add(this.flowLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(670, 521);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(480, 190);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rendering Parameters";
            // 
            // linfilterCheckBox
            // 
            this.linfilterCheckBox.AutoSize = true;
            this.linfilterCheckBox.Checked = true;
            this.linfilterCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.linfilterCheckBox.Location = new System.Drawing.Point(209, 145);
            this.linfilterCheckBox.Name = "linfilterCheckBox";
            this.linfilterCheckBox.Size = new System.Drawing.Size(90, 16);
            this.linfilterCheckBox.TabIndex = 24;
            this.linfilterCheckBox.Text = "Linear Filter";
            this.linfilterCheckBox.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.label9);
            this.flowLayoutPanel2.Controls.Add(this.densityTextBox);
            this.flowLayoutPanel2.Controls.Add(this.label11);
            this.flowLayoutPanel2.Controls.Add(this.brightnessTextBox);
            this.flowLayoutPanel2.Controls.Add(this.label13);
            this.flowLayoutPanel2.Controls.Add(this.transoffsetTextBox);
            this.flowLayoutPanel2.Controls.Add(this.label15);
            this.flowLayoutPanel2.Controls.Add(this.transscaleTextBox);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(209, 21);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(200, 118);
            this.flowLayoutPanel2.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 20);
            this.label9.TabIndex = 21;
            this.label9.Text = "Density";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // densityTextBox
            // 
            this.densityTextBox.Location = new System.Drawing.Point(109, 3);
            this.densityTextBox.Name = "densityTextBox";
            this.densityTextBox.Size = new System.Drawing.Size(80, 21);
            this.densityTextBox.TabIndex = 20;
            this.densityTextBox.Text = "0.05";
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(3, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 20);
            this.label11.TabIndex = 25;
            this.label11.Text = "Brightness";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // brightnessTextBox
            // 
            this.brightnessTextBox.Location = new System.Drawing.Point(109, 30);
            this.brightnessTextBox.Name = "brightnessTextBox";
            this.brightnessTextBox.Size = new System.Drawing.Size(80, 21);
            this.brightnessTextBox.TabIndex = 22;
            this.brightnessTextBox.Text = "1.0";
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(3, 54);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 20);
            this.label13.TabIndex = 29;
            this.label13.Text = "Transfer Offset";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // transoffsetTextBox
            // 
            this.transoffsetTextBox.Location = new System.Drawing.Point(109, 57);
            this.transoffsetTextBox.Name = "transoffsetTextBox";
            this.transoffsetTextBox.Size = new System.Drawing.Size(80, 21);
            this.transoffsetTextBox.TabIndex = 24;
            this.transoffsetTextBox.Text = "0.0";
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(3, 81);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(100, 20);
            this.label15.TabIndex = 33;
            this.label15.Text = "Transfer Scale";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // transscaleTextBox
            // 
            this.transscaleTextBox.Location = new System.Drawing.Point(109, 84);
            this.transscaleTextBox.Name = "transscaleTextBox";
            this.transscaleTextBox.Size = new System.Drawing.Size(80, 21);
            this.transscaleTextBox.TabIndex = 28;
            this.transscaleTextBox.Text = "1.0";
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.label16);
            this.flowLayoutPanel3.Controls.Add(this.daqInterfaceTextBox);
            this.flowLayoutPanel3.Controls.Add(this.label4);
            this.flowLayoutPanel3.Controls.Add(this.voltageValTextBox);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(6, 20);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(220, 100);
            this.flowLayoutPanel3.TabIndex = 24;
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(3, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(100, 20);
            this.label16.TabIndex = 25;
            this.label16.Text = "Interface Name";
            // 
            // daqInterfaceTextBox
            // 
            this.daqInterfaceTextBox.Location = new System.Drawing.Point(109, 3);
            this.daqInterfaceTextBox.Name = "daqInterfaceTextBox";
            this.daqInterfaceTextBox.Size = new System.Drawing.Size(100, 21);
            this.daqInterfaceTextBox.TabIndex = 26;
            this.daqInterfaceTextBox.Text = "img0";
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.label1);
            this.flowLayoutPanel4.Controls.Add(this.interfaceTextBox);
            this.flowLayoutPanel4.Controls.Add(this.label2);
            this.flowLayoutPanel4.Controls.Add(this.numImages);
            this.flowLayoutPanel4.Controls.Add(this.label3);
            this.flowLayoutPanel4.Controls.Add(this.bufNumTextBox);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(6, 23);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(220, 100);
            this.flowLayoutPanel4.TabIndex = 25;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.flowLayoutPanel4);
            this.groupBox2.Location = new System.Drawing.Point(12, 518);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(250, 142);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "IMAQ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.flowLayoutPanel3);
            this.groupBox3.Location = new System.Drawing.Point(268, 521);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(250, 139);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "DAQ";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(16, 696);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(106, 12);
            this.label17.TabIndex = 29;
            this.label17.Text = "Threshold Delta V";
            // 
            // thresholdDeltaVoltageTextBox
            // 
            this.thresholdDeltaVoltageTextBox.Location = new System.Drawing.Point(128, 693);
            this.thresholdDeltaVoltageTextBox.Name = "thresholdDeltaVoltageTextBox";
            this.thresholdDeltaVoltageTextBox.Size = new System.Drawing.Size(116, 21);
            this.thresholdDeltaVoltageTextBox.TabIndex = 28;
            this.thresholdDeltaVoltageTextBox.Text = "0.0";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(265, 678);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(96, 12);
            this.label19.TabIndex = 33;
            this.label19.Text = "Stacked Images";
            // 
            // stackedImageTextBox
            // 
            this.stackedImageTextBox.Location = new System.Drawing.Point(367, 678);
            this.stackedImageTextBox.Name = "stackedImageTextBox";
            this.stackedImageTextBox.Size = new System.Drawing.Size(116, 21);
            this.stackedImageTextBox.TabIndex = 32;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 762);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.stackedImageTextBox);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.thresholdDeltaVoltageTextBox);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.renderPictureBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.volumeDepthTextBox);
            this.Controls.Add(this.subCheckBox);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.imageViewer);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numImages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.renderPictureBox)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NationalInstruments.Vision.WindowsForms.ImageViewer imageViewer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox interfaceTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numImages;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox bufNumTextBox;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.CheckBox subCheckBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox voltageValTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox volumeDepthTextBox;
        private System.Windows.Forms.PictureBox renderPictureBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox rotxTextBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox rotyTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox rotzTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox transxTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox transyTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox transzTextBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox densityTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox brightnessTextBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox transoffsetTextBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox transscaleTextBox;
        private System.Windows.Forms.CheckBox linfilterCheckBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox daqInterfaceTextBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox thresholdDeltaVoltageTextBox;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox stackedImageTextBox;
    }
}

