namespace SchoolManagement
{
    partial class Form_Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Dashboard));
            this.panel_Topbar = new System.Windows.Forms.Panel();
            this.lbl_Welcomebacktoschool = new System.Windows.Forms.Label();
            this.icon_Education = new System.Windows.Forms.PictureBox();
            this.btn_CloseApplication = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_MinimizeApplication = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel_Menu = new System.Windows.Forms.Panel();
            this.btn_settings = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Reports = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_BackupRestore = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Registeration = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_ManageAccounts = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Dashboard = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel_Logo = new System.Windows.Forms.Panel();
            this.Elipse_Dashboard = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.account1 = new SchoolManagement.Accounts.Account();
            this.register1 = new SchoolManagement.Registration.Register();
            this.dB_Migrator1 = new SchoolManagement.DB_Migrator();
            this.home1 = new SchoolManagement.Home();
            this.timer_Exit = new System.Windows.Forms.Timer(this.components);
            this.statsMain1 = new SchoolManagement.ReportsStats.StatsMain();
            this.panel_Topbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon_Education)).BeginInit();
            this.panel_Menu.SuspendLayout();
            this.bunifuGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Topbar
            // 
            this.panel_Topbar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel_Topbar.Controls.Add(this.lbl_Welcomebacktoschool);
            this.panel_Topbar.Controls.Add(this.icon_Education);
            this.panel_Topbar.Controls.Add(this.btn_CloseApplication);
            this.panel_Topbar.Controls.Add(this.btn_MinimizeApplication);
            this.panel_Topbar.Location = new System.Drawing.Point(0, 0);
            this.panel_Topbar.Name = "panel_Topbar";
            this.panel_Topbar.Size = new System.Drawing.Size(971, 50);
            this.panel_Topbar.TabIndex = 0;
            // 
            // lbl_Welcomebacktoschool
            // 
            this.lbl_Welcomebacktoschool.AutoSize = true;
            this.lbl_Welcomebacktoschool.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Welcomebacktoschool.ForeColor = System.Drawing.Color.White;
            this.lbl_Welcomebacktoschool.Location = new System.Drawing.Point(62, 13);
            this.lbl_Welcomebacktoschool.Name = "lbl_Welcomebacktoschool";
            this.lbl_Welcomebacktoschool.Size = new System.Drawing.Size(269, 25);
            this.lbl_Welcomebacktoschool.TabIndex = 2;
            this.lbl_Welcomebacktoschool.Text = "WELCOME BACK TO SCHOOL";
            // 
            // icon_Education
            // 
            this.icon_Education.Image = ((System.Drawing.Image)(resources.GetObject("icon_Education.Image")));
            this.icon_Education.Location = new System.Drawing.Point(8, 4);
            this.icon_Education.Name = "icon_Education";
            this.icon_Education.Size = new System.Drawing.Size(45, 43);
            this.icon_Education.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.icon_Education.TabIndex = 1;
            this.icon_Education.TabStop = false;
            // 
            // btn_CloseApplication
            // 
            this.btn_CloseApplication.Activecolor = System.Drawing.Color.Transparent;
            this.btn_CloseApplication.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_CloseApplication.BackColor = System.Drawing.Color.Transparent;
            this.btn_CloseApplication.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_CloseApplication.BorderRadius = 0;
            this.btn_CloseApplication.ButtonText = "";
            this.btn_CloseApplication.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CloseApplication.DisabledColor = System.Drawing.Color.Transparent;
            this.btn_CloseApplication.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_CloseApplication.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_CloseApplication.Iconimage")));
            this.btn_CloseApplication.Iconimage_right = null;
            this.btn_CloseApplication.Iconimage_right_Selected = null;
            this.btn_CloseApplication.Iconimage_Selected = null;
            this.btn_CloseApplication.IconMarginLeft = 0;
            this.btn_CloseApplication.IconMarginRight = 0;
            this.btn_CloseApplication.IconRightVisible = true;
            this.btn_CloseApplication.IconRightZoom = 0D;
            this.btn_CloseApplication.IconVisible = true;
            this.btn_CloseApplication.IconZoom = 80D;
            this.btn_CloseApplication.IsTab = false;
            this.btn_CloseApplication.Location = new System.Drawing.Point(921, 7);
            this.btn_CloseApplication.Name = "btn_CloseApplication";
            this.btn_CloseApplication.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_CloseApplication.OnHovercolor = System.Drawing.Color.Transparent;
            this.btn_CloseApplication.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_CloseApplication.selected = false;
            this.btn_CloseApplication.Size = new System.Drawing.Size(37, 36);
            this.btn_CloseApplication.TabIndex = 0;
            this.btn_CloseApplication.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_CloseApplication.Textcolor = System.Drawing.Color.White;
            this.btn_CloseApplication.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CloseApplication.Click += new System.EventHandler(this.btn_CloseApplication_Click);
            // 
            // btn_MinimizeApplication
            // 
            this.btn_MinimizeApplication.Activecolor = System.Drawing.Color.Transparent;
            this.btn_MinimizeApplication.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_MinimizeApplication.BackColor = System.Drawing.Color.Transparent;
            this.btn_MinimizeApplication.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_MinimizeApplication.BorderRadius = 0;
            this.btn_MinimizeApplication.ButtonText = "";
            this.btn_MinimizeApplication.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_MinimizeApplication.DisabledColor = System.Drawing.Color.Transparent;
            this.btn_MinimizeApplication.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_MinimizeApplication.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_MinimizeApplication.Iconimage")));
            this.btn_MinimizeApplication.Iconimage_right = null;
            this.btn_MinimizeApplication.Iconimage_right_Selected = null;
            this.btn_MinimizeApplication.Iconimage_Selected = null;
            this.btn_MinimizeApplication.IconMarginLeft = 0;
            this.btn_MinimizeApplication.IconMarginRight = 0;
            this.btn_MinimizeApplication.IconRightVisible = true;
            this.btn_MinimizeApplication.IconRightZoom = 0D;
            this.btn_MinimizeApplication.IconVisible = true;
            this.btn_MinimizeApplication.IconZoom = 80D;
            this.btn_MinimizeApplication.IsTab = false;
            this.btn_MinimizeApplication.Location = new System.Drawing.Point(869, 7);
            this.btn_MinimizeApplication.Name = "btn_MinimizeApplication";
            this.btn_MinimizeApplication.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_MinimizeApplication.OnHovercolor = System.Drawing.Color.Transparent;
            this.btn_MinimizeApplication.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_MinimizeApplication.selected = false;
            this.btn_MinimizeApplication.Size = new System.Drawing.Size(37, 36);
            this.btn_MinimizeApplication.TabIndex = 0;
            this.btn_MinimizeApplication.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_MinimizeApplication.Textcolor = System.Drawing.Color.White;
            this.btn_MinimizeApplication.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MinimizeApplication.Click += new System.EventHandler(this.btn_MinimizeApplication_Click);
            // 
            // panel_Menu
            // 
            this.panel_Menu.BackColor = System.Drawing.Color.Black;
            this.panel_Menu.Controls.Add(this.btn_settings);
            this.panel_Menu.Controls.Add(this.btn_Reports);
            this.panel_Menu.Controls.Add(this.btn_BackupRestore);
            this.panel_Menu.Controls.Add(this.btn_Registeration);
            this.panel_Menu.Controls.Add(this.btn_ManageAccounts);
            this.panel_Menu.Controls.Add(this.btn_Dashboard);
            this.panel_Menu.Controls.Add(this.panel_Logo);
            this.panel_Menu.Location = new System.Drawing.Point(0, 49);
            this.panel_Menu.Name = "panel_Menu";
            this.panel_Menu.Size = new System.Drawing.Size(183, 589);
            this.panel_Menu.TabIndex = 1;
            // 
            // btn_settings
            // 
            this.btn_settings.Activecolor = System.Drawing.SystemColors.HotTrack;
            this.btn_settings.BackColor = System.Drawing.Color.Transparent;
            this.btn_settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_settings.BorderRadius = 0;
            this.btn_settings.ButtonText = "Settings";
            this.btn_settings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_settings.DisabledColor = System.Drawing.Color.Gray;
            this.btn_settings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_settings.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_settings.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_settings.Iconimage")));
            this.btn_settings.Iconimage_right = null;
            this.btn_settings.Iconimage_right_Selected = null;
            this.btn_settings.Iconimage_Selected = null;
            this.btn_settings.IconMarginLeft = 0;
            this.btn_settings.IconMarginRight = 0;
            this.btn_settings.IconRightVisible = true;
            this.btn_settings.IconRightZoom = 0D;
            this.btn_settings.IconVisible = true;
            this.btn_settings.IconZoom = 60D;
            this.btn_settings.IsTab = true;
            this.btn_settings.Location = new System.Drawing.Point(0, 510);
            this.btn_settings.Name = "btn_settings";
            this.btn_settings.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_settings.OnHovercolor = System.Drawing.SystemColors.HotTrack;
            this.btn_settings.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_settings.selected = false;
            this.btn_settings.Size = new System.Drawing.Size(183, 40);
            this.btn_settings.TabIndex = 3;
            this.btn_settings.Text = "Settings";
            this.btn_settings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_settings.Textcolor = System.Drawing.Color.White;
            this.btn_settings.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btn_Reports
            // 
            this.btn_Reports.Activecolor = System.Drawing.SystemColors.HotTrack;
            this.btn_Reports.BackColor = System.Drawing.Color.Transparent;
            this.btn_Reports.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Reports.BorderRadius = 0;
            this.btn_Reports.ButtonText = "Stats Reports";
            this.btn_Reports.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Reports.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Reports.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reports.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Reports.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Reports.Iconimage")));
            this.btn_Reports.Iconimage_right = null;
            this.btn_Reports.Iconimage_right_Selected = null;
            this.btn_Reports.Iconimage_Selected = null;
            this.btn_Reports.IconMarginLeft = 0;
            this.btn_Reports.IconMarginRight = 0;
            this.btn_Reports.IconRightVisible = true;
            this.btn_Reports.IconRightZoom = 0D;
            this.btn_Reports.IconVisible = true;
            this.btn_Reports.IconZoom = 60D;
            this.btn_Reports.IsTab = true;
            this.btn_Reports.Location = new System.Drawing.Point(0, 400);
            this.btn_Reports.Name = "btn_Reports";
            this.btn_Reports.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_Reports.OnHovercolor = System.Drawing.SystemColors.HotTrack;
            this.btn_Reports.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Reports.selected = false;
            this.btn_Reports.Size = new System.Drawing.Size(183, 40);
            this.btn_Reports.TabIndex = 2;
            this.btn_Reports.Text = "Stats Reports";
            this.btn_Reports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Reports.Textcolor = System.Drawing.Color.White;
            this.btn_Reports.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reports.Click += new System.EventHandler(this.btn_Reports_Click);
            // 
            // btn_BackupRestore
            // 
            this.btn_BackupRestore.Activecolor = System.Drawing.SystemColors.HotTrack;
            this.btn_BackupRestore.BackColor = System.Drawing.Color.Transparent;
            this.btn_BackupRestore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_BackupRestore.BorderRadius = 0;
            this.btn_BackupRestore.ButtonText = "Backup Restore";
            this.btn_BackupRestore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_BackupRestore.DisabledColor = System.Drawing.Color.Gray;
            this.btn_BackupRestore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BackupRestore.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_BackupRestore.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_BackupRestore.Iconimage")));
            this.btn_BackupRestore.Iconimage_right = null;
            this.btn_BackupRestore.Iconimage_right_Selected = null;
            this.btn_BackupRestore.Iconimage_Selected = null;
            this.btn_BackupRestore.IconMarginLeft = 0;
            this.btn_BackupRestore.IconMarginRight = 0;
            this.btn_BackupRestore.IconRightVisible = true;
            this.btn_BackupRestore.IconRightZoom = 0D;
            this.btn_BackupRestore.IconVisible = true;
            this.btn_BackupRestore.IconZoom = 60D;
            this.btn_BackupRestore.IsTab = true;
            this.btn_BackupRestore.Location = new System.Drawing.Point(0, 455);
            this.btn_BackupRestore.Name = "btn_BackupRestore";
            this.btn_BackupRestore.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_BackupRestore.OnHovercolor = System.Drawing.SystemColors.HotTrack;
            this.btn_BackupRestore.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_BackupRestore.selected = false;
            this.btn_BackupRestore.Size = new System.Drawing.Size(183, 40);
            this.btn_BackupRestore.TabIndex = 1;
            this.btn_BackupRestore.Text = "Backup Restore";
            this.btn_BackupRestore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_BackupRestore.Textcolor = System.Drawing.Color.White;
            this.btn_BackupRestore.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BackupRestore.Click += new System.EventHandler(this.btn_BackupRestore_Click);
            // 
            // btn_Registeration
            // 
            this.btn_Registeration.Activecolor = System.Drawing.SystemColors.HotTrack;
            this.btn_Registeration.BackColor = System.Drawing.Color.Transparent;
            this.btn_Registeration.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Registeration.BorderRadius = 0;
            this.btn_Registeration.ButtonText = "Registeration";
            this.btn_Registeration.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Registeration.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Registeration.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Registeration.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Registeration.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Registeration.Iconimage")));
            this.btn_Registeration.Iconimage_right = null;
            this.btn_Registeration.Iconimage_right_Selected = null;
            this.btn_Registeration.Iconimage_Selected = null;
            this.btn_Registeration.IconMarginLeft = 0;
            this.btn_Registeration.IconMarginRight = 0;
            this.btn_Registeration.IconRightVisible = true;
            this.btn_Registeration.IconRightZoom = 0D;
            this.btn_Registeration.IconVisible = true;
            this.btn_Registeration.IconZoom = 60D;
            this.btn_Registeration.IsTab = true;
            this.btn_Registeration.Location = new System.Drawing.Point(0, 283);
            this.btn_Registeration.Name = "btn_Registeration";
            this.btn_Registeration.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_Registeration.OnHovercolor = System.Drawing.SystemColors.HotTrack;
            this.btn_Registeration.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Registeration.selected = false;
            this.btn_Registeration.Size = new System.Drawing.Size(183, 40);
            this.btn_Registeration.TabIndex = 1;
            this.btn_Registeration.Text = "Registeration";
            this.btn_Registeration.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Registeration.Textcolor = System.Drawing.Color.White;
            this.btn_Registeration.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Registeration.Click += new System.EventHandler(this.btn_Registeration_Click);
            // 
            // btn_ManageAccounts
            // 
            this.btn_ManageAccounts.Activecolor = System.Drawing.SystemColors.HotTrack;
            this.btn_ManageAccounts.BackColor = System.Drawing.Color.Transparent;
            this.btn_ManageAccounts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ManageAccounts.BorderRadius = 0;
            this.btn_ManageAccounts.ButtonText = "Manage Accounts";
            this.btn_ManageAccounts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ManageAccounts.DisabledColor = System.Drawing.Color.Gray;
            this.btn_ManageAccounts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ManageAccounts.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_ManageAccounts.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_ManageAccounts.Iconimage")));
            this.btn_ManageAccounts.Iconimage_right = null;
            this.btn_ManageAccounts.Iconimage_right_Selected = null;
            this.btn_ManageAccounts.Iconimage_Selected = null;
            this.btn_ManageAccounts.IconMarginLeft = 0;
            this.btn_ManageAccounts.IconMarginRight = 0;
            this.btn_ManageAccounts.IconRightVisible = true;
            this.btn_ManageAccounts.IconRightZoom = 0D;
            this.btn_ManageAccounts.IconVisible = true;
            this.btn_ManageAccounts.IconZoom = 60D;
            this.btn_ManageAccounts.IsTab = true;
            this.btn_ManageAccounts.Location = new System.Drawing.Point(0, 343);
            this.btn_ManageAccounts.Name = "btn_ManageAccounts";
            this.btn_ManageAccounts.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_ManageAccounts.OnHovercolor = System.Drawing.SystemColors.HotTrack;
            this.btn_ManageAccounts.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_ManageAccounts.selected = false;
            this.btn_ManageAccounts.Size = new System.Drawing.Size(183, 40);
            this.btn_ManageAccounts.TabIndex = 1;
            this.btn_ManageAccounts.Text = "Manage Accounts";
            this.btn_ManageAccounts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ManageAccounts.Textcolor = System.Drawing.Color.White;
            this.btn_ManageAccounts.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ManageAccounts.Click += new System.EventHandler(this.btn_ManageAccounts_Click);
            // 
            // btn_Dashboard
            // 
            this.btn_Dashboard.Activecolor = System.Drawing.SystemColors.HotTrack;
            this.btn_Dashboard.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Dashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Dashboard.BorderRadius = 0;
            this.btn_Dashboard.ButtonText = "Dashboard";
            this.btn_Dashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Dashboard.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Dashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Dashboard.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Dashboard.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Dashboard.Iconimage")));
            this.btn_Dashboard.Iconimage_right = null;
            this.btn_Dashboard.Iconimage_right_Selected = null;
            this.btn_Dashboard.Iconimage_Selected = null;
            this.btn_Dashboard.IconMarginLeft = 0;
            this.btn_Dashboard.IconMarginRight = 0;
            this.btn_Dashboard.IconRightVisible = true;
            this.btn_Dashboard.IconRightZoom = 0D;
            this.btn_Dashboard.IconVisible = true;
            this.btn_Dashboard.IconZoom = 55D;
            this.btn_Dashboard.IsTab = true;
            this.btn_Dashboard.Location = new System.Drawing.Point(0, 225);
            this.btn_Dashboard.Name = "btn_Dashboard";
            this.btn_Dashboard.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_Dashboard.OnHovercolor = System.Drawing.SystemColors.HotTrack;
            this.btn_Dashboard.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Dashboard.selected = true;
            this.btn_Dashboard.Size = new System.Drawing.Size(183, 40);
            this.btn_Dashboard.TabIndex = 1;
            this.btn_Dashboard.Text = "Dashboard";
            this.btn_Dashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Dashboard.Textcolor = System.Drawing.Color.White;
            this.btn_Dashboard.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Dashboard.Click += new System.EventHandler(this.btn_Dashboard_Click);
            // 
            // panel_Logo
            // 
            this.panel_Logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_Logo.BackgroundImage")));
            this.panel_Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_Logo.Location = new System.Drawing.Point(8, 36);
            this.panel_Logo.Name = "panel_Logo";
            this.panel_Logo.Size = new System.Drawing.Size(159, 131);
            this.panel_Logo.TabIndex = 0;
            // 
            // Elipse_Dashboard
            // 
            this.Elipse_Dashboard.ElipseRadius = 10;
            this.Elipse_Dashboard.TargetControl = this;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuGradientPanel1.Controls.Add(this.statsMain1);
            this.bunifuGradientPanel1.Controls.Add(this.account1);
            this.bunifuGradientPanel1.Controls.Add(this.register1);
            this.bunifuGradientPanel1.Controls.Add(this.dB_Migrator1);
            this.bunifuGradientPanel1.Controls.Add(this.home1);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.LightGray;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.WhiteSmoke;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(183, 49);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(788, 589);
            this.bunifuGradientPanel1.TabIndex = 3;
            this.bunifuGradientPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.bunifuGradientPanel1_Paint);
            // 
            // account1
            // 
            this.account1.BackColor = System.Drawing.Color.White;
            this.account1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.account1.Location = new System.Drawing.Point(0, 0);
            this.account1.Name = "account1";
            this.account1.Size = new System.Drawing.Size(786, 587);
            this.account1.TabIndex = 3;
            // 
            // register1
            // 
            this.register1.BackColor = System.Drawing.Color.Transparent;
            this.register1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.register1.Location = new System.Drawing.Point(0, 0);
            this.register1.Name = "register1";
            this.register1.Size = new System.Drawing.Size(786, 587);
            this.register1.TabIndex = 0;
            // 
            // dB_Migrator1
            // 
            this.dB_Migrator1.BackColor = System.Drawing.Color.White;
            this.dB_Migrator1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dB_Migrator1.Location = new System.Drawing.Point(0, 0);
            this.dB_Migrator1.Name = "dB_Migrator1";
            this.dB_Migrator1.Size = new System.Drawing.Size(786, 587);
            this.dB_Migrator1.TabIndex = 2;
            // 
            // home1
            // 
            this.home1.BackColor = System.Drawing.Color.Transparent;
            this.home1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.home1.Location = new System.Drawing.Point(0, 0);
            this.home1.Name = "home1";
            this.home1.Size = new System.Drawing.Size(786, 587);
            this.home1.TabIndex = 1;
            this.home1.Load += new System.EventHandler(this.home1_Load);
            // 
            // timer_Exit
            // 
            this.timer_Exit.Interval = 10;
            this.timer_Exit.Tick += new System.EventHandler(this.timer_Minimize_Tick);
            // 
            // statsMain1
            // 
            this.statsMain1.BackColor = System.Drawing.Color.White;
            this.statsMain1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statsMain1.Location = new System.Drawing.Point(0, 0);
            this.statsMain1.Name = "statsMain1";
            this.statsMain1.Size = new System.Drawing.Size(786, 587);
            this.statsMain1.TabIndex = 4;
            // 
            // Form_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(970, 639);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.panel_Menu);
            this.Controls.Add(this.panel_Topbar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "School Management";
            this.panel_Topbar.ResumeLayout(false);
            this.panel_Topbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon_Education)).EndInit();
            this.panel_Menu.ResumeLayout(false);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Topbar;
        private System.Windows.Forms.Panel panel_Menu;
        private Bunifu.Framework.UI.BunifuElipse Elipse_Dashboard;
        private Bunifu.Framework.UI.BunifuFlatButton btn_CloseApplication;
        private Bunifu.Framework.UI.BunifuFlatButton btn_MinimizeApplication;
        private System.Windows.Forms.PictureBox icon_Education;
        private System.Windows.Forms.Label lbl_Welcomebacktoschool;
        private System.Windows.Forms.Panel panel_Logo;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Dashboard;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Registeration;
        private Bunifu.Framework.UI.BunifuFlatButton btn_ManageAccounts;
        private Bunifu.Framework.UI.BunifuFlatButton btn_BackupRestore;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Home home1;
        private Registration.Register register1;
        private System.Windows.Forms.Timer timer_Exit;
        private DB_Migrator dB_Migrator1;
        private Accounts.Account account1;
        private Bunifu.Framework.UI.BunifuFlatButton btn_settings;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Reports;
        private ReportsStats.StatsMain statsMain1;
    }
}

