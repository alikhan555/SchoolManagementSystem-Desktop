namespace SchoolManagement.Accounts
{
    partial class Account
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Account));
            this.panel_MenuLine = new System.Windows.Forms.PictureBox();
            this.btn_GetAmount = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_ViewDetails = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel1 = new System.Windows.Forms.Panel();
            this.getAmount2 = new SchoolManagement.Accounts.GetAmount();
            this.getAmount1 = new SchoolManagement.Accounts.GetAmount();
            this.viewDetails1 = new SchoolManagement.Accounts.ViewDetails();
            ((System.ComponentModel.ISupportInitialize)(this.panel_MenuLine)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_MenuLine
            // 
            this.panel_MenuLine.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel_MenuLine.Location = new System.Drawing.Point(72, 51);
            this.panel_MenuLine.Name = "panel_MenuLine";
            this.panel_MenuLine.Size = new System.Drawing.Size(91, 4);
            this.panel_MenuLine.TabIndex = 9;
            this.panel_MenuLine.TabStop = false;
            // 
            // btn_GetAmount
            // 
            this.btn_GetAmount.ActiveBorderThickness = 1;
            this.btn_GetAmount.ActiveCornerRadius = 1;
            this.btn_GetAmount.ActiveFillColor = System.Drawing.Color.Transparent;
            this.btn_GetAmount.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_GetAmount.ActiveLineColor = System.Drawing.Color.Transparent;
            this.btn_GetAmount.BackColor = System.Drawing.Color.White;
            this.btn_GetAmount.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_GetAmount.BackgroundImage")));
            this.btn_GetAmount.ButtonText = "Get Amount";
            this.btn_GetAmount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_GetAmount.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GetAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_GetAmount.IdleBorderThickness = 1;
            this.btn_GetAmount.IdleCornerRadius = 1;
            this.btn_GetAmount.IdleFillColor = System.Drawing.Color.Transparent;
            this.btn_GetAmount.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_GetAmount.IdleLineColor = System.Drawing.Color.Transparent;
            this.btn_GetAmount.Location = new System.Drawing.Point(187, 16);
            this.btn_GetAmount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_GetAmount.Name = "btn_GetAmount";
            this.btn_GetAmount.Size = new System.Drawing.Size(112, 31);
            this.btn_GetAmount.TabIndex = 6;
            this.btn_GetAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_GetAmount.Click += new System.EventHandler(this.btn_GetAmount_Click);
            // 
            // btn_ViewDetails
            // 
            this.btn_ViewDetails.ActiveBorderThickness = 1;
            this.btn_ViewDetails.ActiveCornerRadius = 1;
            this.btn_ViewDetails.ActiveFillColor = System.Drawing.Color.Transparent;
            this.btn_ViewDetails.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_ViewDetails.ActiveLineColor = System.Drawing.Color.Transparent;
            this.btn_ViewDetails.BackColor = System.Drawing.Color.White;
            this.btn_ViewDetails.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_ViewDetails.BackgroundImage")));
            this.btn_ViewDetails.ButtonText = "View Details";
            this.btn_ViewDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ViewDetails.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ViewDetails.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_ViewDetails.IdleBorderThickness = 1;
            this.btn_ViewDetails.IdleCornerRadius = 1;
            this.btn_ViewDetails.IdleFillColor = System.Drawing.Color.Transparent;
            this.btn_ViewDetails.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_ViewDetails.IdleLineColor = System.Drawing.Color.Transparent;
            this.btn_ViewDetails.Location = new System.Drawing.Point(72, 16);
            this.btn_ViewDetails.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_ViewDetails.Name = "btn_ViewDetails";
            this.btn_ViewDetails.Size = new System.Drawing.Size(91, 31);
            this.btn_ViewDetails.TabIndex = 8;
            this.btn_ViewDetails.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_ViewDetails.Click += new System.EventHandler(this.btn_ViewDetails_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.viewDetails1);
            this.panel1.Controls.Add(this.getAmount2);
            this.panel1.Controls.Add(this.getAmount1);
            this.panel1.Location = new System.Drawing.Point(3, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(790, 460);
            this.panel1.TabIndex = 10;
            // 
            // getAmount2
            // 
            this.getAmount2.BackColor = System.Drawing.Color.White;
            this.getAmount2.Location = new System.Drawing.Point(0, 0);
            this.getAmount2.Name = "getAmount2";
            this.getAmount2.Size = new System.Drawing.Size(790, 500);
            this.getAmount2.TabIndex = 1;
            // 
            // getAmount1
            // 
            this.getAmount1.BackColor = System.Drawing.Color.White;
            this.getAmount1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.getAmount1.Location = new System.Drawing.Point(0, 0);
            this.getAmount1.Name = "getAmount1";
            this.getAmount1.Size = new System.Drawing.Size(790, 460);
            this.getAmount1.TabIndex = 0;
            // 
            // viewDetails1
            // 
            this.viewDetails1.Location = new System.Drawing.Point(0, 0);
            this.viewDetails1.Name = "viewDetails1";
            this.viewDetails1.Size = new System.Drawing.Size(790, 500);
            this.viewDetails1.TabIndex = 2;
            // 
            // Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_MenuLine);
            this.Controls.Add(this.btn_GetAmount);
            this.Controls.Add(this.btn_ViewDetails);
            this.Name = "Account";
            this.Size = new System.Drawing.Size(815, 590);
            ((System.ComponentModel.ISupportInitialize)(this.panel_MenuLine)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private GetAmount feesSubmissionForm1;
        private System.Windows.Forms.PictureBox panel_MenuLine;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_GetAmount;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_ViewDetails;
        private System.Windows.Forms.Panel panel1;
        private GetAmount getAmount2;
        private GetAmount getAmount1;
        private ViewDetails viewDetails1;
    }
}
