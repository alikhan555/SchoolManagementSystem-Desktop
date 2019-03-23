namespace SchoolManagement.Registration
{
    partial class WebCamCapture
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
            this.btn_CaptureImagetoBox = new System.Windows.Forms.Button();
            this.pictureBox_ProfileImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ProfileImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_CaptureImagetoBox
            // 
            this.btn_CaptureImagetoBox.Location = new System.Drawing.Point(6, 340);
            this.btn_CaptureImagetoBox.Name = "btn_CaptureImagetoBox";
            this.btn_CaptureImagetoBox.Size = new System.Drawing.Size(91, 60);
            this.btn_CaptureImagetoBox.TabIndex = 5;
            this.btn_CaptureImagetoBox.Text = "Capture ";
            this.btn_CaptureImagetoBox.UseVisualStyleBackColor = true;
            this.btn_CaptureImagetoBox.Click += new System.EventHandler(this.btn_CaptureImagetoBox_Click);
            // 
            // pictureBox_ProfileImage
            // 
            this.pictureBox_ProfileImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_ProfileImage.Location = new System.Drawing.Point(6, 13);
            this.pictureBox_ProfileImage.Name = "pictureBox_ProfileImage";
            this.pictureBox_ProfileImage.Size = new System.Drawing.Size(272, 312);
            this.pictureBox_ProfileImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_ProfileImage.TabIndex = 4;
            this.pictureBox_ProfileImage.TabStop = false;
            // 
            // WebCamCapture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 412);
            this.Controls.Add(this.btn_CaptureImagetoBox);
            this.Controls.Add(this.pictureBox_ProfileImage);
            this.Name = "WebCamCapture";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WebCamCapture";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WebCamCapture_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ProfileImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_CaptureImagetoBox;
        private System.Windows.Forms.PictureBox pictureBox_ProfileImage;
    }
}