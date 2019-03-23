namespace SchoolManagement
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Close = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.BG = new System.Windows.Forms.Panel();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.btn_Login = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txt_LoginPass = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_LoginId = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panel1.SuspendLayout();
            this.BG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.Close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(355, 32);
            this.panel1.TabIndex = 2;
            // 
            // Close
            // 
            this.Close.AutoSize = true;
            this.Close.BackColor = System.Drawing.Color.Transparent;
            this.Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Close.Location = new System.Drawing.Point(332, 6);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(17, 17);
            this.Close.TabIndex = 2;
            this.Close.Text = "X";
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 6;
            this.bunifuElipse1.TargetControl = this;
            // 
            // BG
            // 
            this.BG.BackColor = System.Drawing.Color.Black;
            this.BG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BG.Controls.Add(this.lbl_Title);
            this.BG.Controls.Add(this.btn_Login);
            this.BG.Controls.Add(this.pictureBox3);
            this.BG.Controls.Add(this.pictureBox2);
            this.BG.Controls.Add(this.txt_LoginPass);
            this.BG.Controls.Add(this.txt_LoginId);
            this.BG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BG.Location = new System.Drawing.Point(0, 32);
            this.BG.Name = "BG";
            this.BG.Size = new System.Drawing.Size(355, 382);
            this.BG.TabIndex = 3;
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.lbl_Title.ForeColor = System.Drawing.Color.White;
            this.lbl_Title.Location = new System.Drawing.Point(32, 23);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(288, 26);
            this.lbl_Title.TabIndex = 11;
            this.lbl_Title.Text = "ABC School Management";
            // 
            // btn_Login
            // 
            this.btn_Login.ActiveBorderThickness = 1;
            this.btn_Login.ActiveCornerRadius = 10;
            this.btn_Login.ActiveFillColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Login.ActiveForecolor = System.Drawing.Color.Black;
            this.btn_Login.ActiveLineColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Login.BackColor = System.Drawing.Color.Black;
            this.btn_Login.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Login.BackgroundImage")));
            this.btn_Login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Login.ButtonText = "Login";
            this.btn_Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Login.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Login.IdleBorderThickness = 2;
            this.btn_Login.IdleCornerRadius = 2;
            this.btn_Login.IdleFillColor = System.Drawing.Color.Transparent;
            this.btn_Login.IdleForecolor = System.Drawing.SystemColors.HotTrack;
            this.btn_Login.IdleLineColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Login.Location = new System.Drawing.Point(86, 243);
            this.btn_Login.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(181, 41);
            this.btn_Login.TabIndex = 10;
            this.btn_Login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(48, 171);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(33, 33);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(48, 107);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 33);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // txt_LoginPass
            // 
            this.txt_LoginPass.BackColor = System.Drawing.Color.Black;
            this.txt_LoginPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_LoginPass.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_LoginPass.ForeColor = System.Drawing.Color.White;
            this.txt_LoginPass.HintForeColor = System.Drawing.Color.White;
            this.txt_LoginPass.HintText = "";
            this.txt_LoginPass.isPassword = true;
            this.txt_LoginPass.LineFocusedColor = System.Drawing.SystemColors.HotTrack;
            this.txt_LoginPass.LineIdleColor = System.Drawing.Color.White;
            this.txt_LoginPass.LineMouseHoverColor = System.Drawing.Color.White;
            this.txt_LoginPass.LineThickness = 3;
            this.txt_LoginPass.Location = new System.Drawing.Point(96, 171);
            this.txt_LoginPass.Margin = new System.Windows.Forms.Padding(4);
            this.txt_LoginPass.Name = "txt_LoginPass";
            this.txt_LoginPass.Size = new System.Drawing.Size(209, 33);
            this.txt_LoginPass.TabIndex = 6;
            this.txt_LoginPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_LoginId
            // 
            this.txt_LoginId.BackColor = System.Drawing.Color.Black;
            this.txt_LoginId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_LoginId.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_LoginId.ForeColor = System.Drawing.Color.White;
            this.txt_LoginId.HintForeColor = System.Drawing.Color.White;
            this.txt_LoginId.HintText = "User Name";
            this.txt_LoginId.isPassword = false;
            this.txt_LoginId.LineFocusedColor = System.Drawing.SystemColors.HotTrack;
            this.txt_LoginId.LineIdleColor = System.Drawing.Color.White;
            this.txt_LoginId.LineMouseHoverColor = System.Drawing.Color.White;
            this.txt_LoginId.LineThickness = 3;
            this.txt_LoginId.Location = new System.Drawing.Point(96, 107);
            this.txt_LoginId.Margin = new System.Windows.Forms.Padding(4);
            this.txt_LoginId.Name = "txt_LoginId";
            this.txt_LoginId.Size = new System.Drawing.Size(209, 33);
            this.txt_LoginId.TabIndex = 7;
            this.txt_LoginId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(355, 414);
            this.Controls.Add(this.BG);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.BG.ResumeLayout(false);
            this.BG.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomLabel Close;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel BG;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_Login;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_LoginPass;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_LoginId;
        private System.Windows.Forms.Label lbl_Title;
    }
}