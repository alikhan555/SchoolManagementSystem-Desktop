namespace SchoolManagement
{
    partial class WindowsForm
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
            this.registerForm1 = new SchoolManagement.Registration.RegisterForm();
            this.SuspendLayout();
            // 
            // registerForm1
            // 
            this.registerForm1.BackColor = System.Drawing.Color.White;
            this.registerForm1.Location = new System.Drawing.Point(-2, -10);
            this.registerForm1.Name = "registerForm1";
            this.registerForm1.Size = new System.Drawing.Size(790, 500);
            this.registerForm1.TabIndex = 0;
            // 
            // WindowsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 495);
            this.Controls.Add(this.registerForm1);
            this.Name = "WindowsForm";
            this.Text = "WindowsForm";
            this.Load += new System.EventHandler(this.WindowsForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Registration.RegisterForm registerForm1;
    }
}