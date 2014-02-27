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
            this.volumeWidthTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.volumeHegithTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.volumeDepthTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numImages)).BeginInit();
            this.SuspendLayout();
            // 
            // imageViewer
            // 
            this.imageViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageViewer.Location = new System.Drawing.Point(14, 11);
            this.imageViewer.Name = "imageViewer";
            this.imageViewer.Size = new System.Drawing.Size(640, 480);
            this.imageViewer.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 503);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Interface Name";
            // 
            // interfaceTextBox
            // 
            this.interfaceTextBox.Location = new System.Drawing.Point(19, 518);
            this.interfaceTextBox.Name = "interfaceTextBox";
            this.interfaceTextBox.Size = new System.Drawing.Size(93, 21);
            this.interfaceTextBox.TabIndex = 2;
            this.interfaceTextBox.Text = "img0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 504);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "# of Images";
            // 
            // numImages
            // 
            this.numImages.Location = new System.Drawing.Point(134, 518);
            this.numImages.Name = "numImages";
            this.numImages.Size = new System.Drawing.Size(82, 21);
            this.numImages.TabIndex = 4;
            this.numImages.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(567, 497);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(87, 21);
            this.startButton.TabIndex = 5;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(567, 523);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(87, 21);
            this.stopButton.TabIndex = 6;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(239, 503);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "Current Image Number";
            // 
            // bufNumTextBox
            // 
            this.bufNumTextBox.Location = new System.Drawing.Point(243, 518);
            this.bufNumTextBox.Name = "bufNumTextBox";
            this.bufNumTextBox.Size = new System.Drawing.Size(116, 21);
            this.bufNumTextBox.TabIndex = 8;
            // 
            // quitButton
            // 
            this.quitButton.Location = new System.Drawing.Point(567, 546);
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
            this.subCheckBox.Location = new System.Drawing.Point(391, 504);
            this.subCheckBox.Name = "subCheckBox";
            this.subCheckBox.Size = new System.Drawing.Size(85, 16);
            this.subCheckBox.TabIndex = 10;
            this.subCheckBox.Text = "Sub Image";
            this.subCheckBox.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(241, 546);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "Voltage";
            // 
            // voltageValTextBox
            // 
            this.voltageValTextBox.Location = new System.Drawing.Point(241, 561);
            this.voltageValTextBox.Name = "voltageValTextBox";
            this.voltageValTextBox.Size = new System.Drawing.Size(116, 21);
            this.voltageValTextBox.TabIndex = 12;
            // 
            // volumeWidthTextBox
            // 
            this.volumeWidthTextBox.Location = new System.Drawing.Point(122, 607);
            this.volumeWidthTextBox.Name = "volumeWidthTextBox";
            this.volumeWidthTextBox.Size = new System.Drawing.Size(116, 21);
            this.volumeWidthTextBox.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 610);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 12);
            this.label5.TabIndex = 14;
            this.label5.Text = "Volume Width";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 637);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 12);
            this.label6.TabIndex = 16;
            this.label6.Text = "Volume Height";
            // 
            // volumeHegithTextBox
            // 
            this.volumeHegithTextBox.Location = new System.Drawing.Point(122, 634);
            this.volumeHegithTextBox.Name = "volumeHegithTextBox";
            this.volumeHegithTextBox.Size = new System.Drawing.Size(116, 21);
            this.volumeHegithTextBox.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 664);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 12);
            this.label7.TabIndex = 18;
            this.label7.Text = "Volume Depth";
            // 
            // volumeDepthTextBox
            // 
            this.volumeDepthTextBox.Location = new System.Drawing.Point(122, 661);
            this.volumeDepthTextBox.Name = "volumeDepthTextBox";
            this.volumeDepthTextBox.Size = new System.Drawing.Size(116, 21);
            this.volumeDepthTextBox.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 737);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.volumeDepthTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.volumeHegithTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.volumeWidthTextBox);
            this.Controls.Add(this.voltageValTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.subCheckBox);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.bufNumTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.numImages);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.interfaceTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imageViewer);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numImages)).EndInit();
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
        private System.Windows.Forms.TextBox volumeWidthTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox volumeHegithTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox volumeDepthTextBox;
    }
}

