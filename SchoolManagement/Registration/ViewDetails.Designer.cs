namespace SchoolManagement.Registration
{
    partial class ViewDetails
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
            this.lbl_Qualification = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_Qualification = new System.Windows.Forms.TextBox();
            this.txt_Designation = new System.Windows.Forms.TextBox();
            this.lbl_Designation = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.combo_Class = new System.Windows.Forms.ComboBox();
            this.combo_Section = new System.Windows.Forms.ComboBox();
            this.lbl_Section = new System.Windows.Forms.Label();
            this.lbl_Class = new System.Windows.Forms.Label();
            this.combo_Status = new System.Windows.Forms.ComboBox();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.lbl_Id = new System.Windows.Forms.Label();
            this.radioBtn_Staff = new System.Windows.Forms.RadioButton();
            this.radioBtn_Student = new System.Windows.Forms.RadioButton();
            this.panel_person = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel_person.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Qualification
            // 
            this.lbl_Qualification.AutoSize = true;
            this.lbl_Qualification.Location = new System.Drawing.Point(11, 44);
            this.lbl_Qualification.Name = "lbl_Qualification";
            this.lbl_Qualification.Size = new System.Drawing.Size(65, 13);
            this.lbl_Qualification.TabIndex = 120;
            this.lbl_Qualification.Text = "Qualification";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txt_Qualification);
            this.panel2.Controls.Add(this.lbl_Qualification);
            this.panel2.Controls.Add(this.txt_Designation);
            this.panel2.Controls.Add(this.lbl_Designation);
            this.panel2.Location = new System.Drawing.Point(478, 77);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 74);
            this.panel2.TabIndex = 132;
            // 
            // txt_Qualification
            // 
            this.txt_Qualification.Location = new System.Drawing.Point(85, 39);
            this.txt_Qualification.Name = "txt_Qualification";
            this.txt_Qualification.Size = new System.Drawing.Size(102, 20);
            this.txt_Qualification.TabIndex = 121;
            this.txt_Qualification.TextChanged += new System.EventHandler(this.txt_Qualification_TextChanged);
            // 
            // txt_Designation
            // 
            this.txt_Designation.Location = new System.Drawing.Point(85, 13);
            this.txt_Designation.Name = "txt_Designation";
            this.txt_Designation.Size = new System.Drawing.Size(102, 20);
            this.txt_Designation.TabIndex = 119;
            this.txt_Designation.TextChanged += new System.EventHandler(this.txt_Qualification_TextChanged);
            // 
            // lbl_Designation
            // 
            this.lbl_Designation.AutoSize = true;
            this.lbl_Designation.Location = new System.Drawing.Point(11, 18);
            this.lbl_Designation.Name = "lbl_Designation";
            this.lbl_Designation.Size = new System.Drawing.Size(63, 13);
            this.lbl_Designation.TabIndex = 118;
            this.lbl_Designation.Text = "Designation";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.combo_Class);
            this.panel1.Controls.Add(this.combo_Section);
            this.panel1.Controls.Add(this.lbl_Section);
            this.panel1.Controls.Add(this.lbl_Class);
            this.panel1.Location = new System.Drawing.Point(45, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 74);
            this.panel1.TabIndex = 131;
            // 
            // combo_Class
            // 
            this.combo_Class.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_Class.FormattingEnabled = true;
            this.combo_Class.Location = new System.Drawing.Point(82, 13);
            this.combo_Class.Name = "combo_Class";
            this.combo_Class.Size = new System.Drawing.Size(102, 21);
            this.combo_Class.TabIndex = 107;
            this.combo_Class.SelectedIndexChanged += new System.EventHandler(this.txt_Qualification_TextChanged);
            this.combo_Class.Click += new System.EventHandler(this.combo_Class_Click);
            // 
            // combo_Section
            // 
            this.combo_Section.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_Section.FormattingEnabled = true;
            this.combo_Section.Location = new System.Drawing.Point(82, 40);
            this.combo_Section.Name = "combo_Section";
            this.combo_Section.Size = new System.Drawing.Size(102, 21);
            this.combo_Section.TabIndex = 111;
            this.combo_Section.SelectedIndexChanged += new System.EventHandler(this.txt_Qualification_TextChanged);
            this.combo_Section.Click += new System.EventHandler(this.combo_Section_Click);
            // 
            // lbl_Section
            // 
            this.lbl_Section.AutoSize = true;
            this.lbl_Section.Location = new System.Drawing.Point(11, 43);
            this.lbl_Section.Name = "lbl_Section";
            this.lbl_Section.Size = new System.Drawing.Size(43, 13);
            this.lbl_Section.TabIndex = 110;
            this.lbl_Section.Text = "Section";
            // 
            // lbl_Class
            // 
            this.lbl_Class.AutoSize = true;
            this.lbl_Class.Location = new System.Drawing.Point(11, 16);
            this.lbl_Class.Name = "lbl_Class";
            this.lbl_Class.Size = new System.Drawing.Size(32, 13);
            this.lbl_Class.TabIndex = 106;
            this.lbl_Class.Text = "Class";
            // 
            // combo_Status
            // 
            this.combo_Status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_Status.FormattingEnabled = true;
            this.combo_Status.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.combo_Status.Location = new System.Drawing.Point(346, 89);
            this.combo_Status.Name = "combo_Status";
            this.combo_Status.Size = new System.Drawing.Size(102, 21);
            this.combo_Status.TabIndex = 130;
            this.combo_Status.SelectedIndexChanged += new System.EventHandler(this.txt_Qualification_TextChanged);
            // 
            // lbl_Status
            // 
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.Location = new System.Drawing.Point(275, 92);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(37, 13);
            this.lbl_Status.TabIndex = 129;
            this.lbl_Status.Text = "Status";
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(478, 39);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(54, 24);
            this.btn_Search.TabIndex = 128;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // txt_Id
            // 
            this.txt_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Id.Location = new System.Drawing.Point(307, 39);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Size = new System.Drawing.Size(165, 24);
            this.txt_Id.TabIndex = 127;
            // 
            // lbl_Id
            // 
            this.lbl_Id.AutoSize = true;
            this.lbl_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Id.Location = new System.Drawing.Point(261, 42);
            this.lbl_Id.Name = "lbl_Id";
            this.lbl_Id.Size = new System.Drawing.Size(24, 18);
            this.lbl_Id.TabIndex = 126;
            this.lbl_Id.Text = "ID";
            // 
            // radioBtn_Staff
            // 
            this.radioBtn_Staff.AutoSize = true;
            this.radioBtn_Staff.Location = new System.Drawing.Point(82, 11);
            this.radioBtn_Staff.Name = "radioBtn_Staff";
            this.radioBtn_Staff.Size = new System.Drawing.Size(47, 17);
            this.radioBtn_Staff.TabIndex = 1;
            this.radioBtn_Staff.TabStop = true;
            this.radioBtn_Staff.Text = "Staff";
            this.radioBtn_Staff.UseVisualStyleBackColor = true;
            this.radioBtn_Staff.CheckedChanged += new System.EventHandler(this.radioBtn_Staff_CheckedChanged);
            // 
            // radioBtn_Student
            // 
            this.radioBtn_Student.AutoSize = true;
            this.radioBtn_Student.Location = new System.Drawing.Point(4, 11);
            this.radioBtn_Student.Name = "radioBtn_Student";
            this.radioBtn_Student.Size = new System.Drawing.Size(62, 17);
            this.radioBtn_Student.TabIndex = 0;
            this.radioBtn_Student.TabStop = true;
            this.radioBtn_Student.Text = "Student";
            this.radioBtn_Student.UseVisualStyleBackColor = true;
            this.radioBtn_Student.CheckedChanged += new System.EventHandler(this.radioBtn_Student_CheckedChanged);
            // 
            // panel_person
            // 
            this.panel_person.Controls.Add(this.radioBtn_Staff);
            this.panel_person.Controls.Add(this.radioBtn_Student);
            this.panel_person.Location = new System.Drawing.Point(45, 33);
            this.panel_person.Name = "panel_person";
            this.panel_person.Size = new System.Drawing.Size(143, 37);
            this.panel_person.TabIndex = 125;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(45, 158);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(700, 400);
            this.dataGridView1.TabIndex = 124;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // ViewDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.combo_Status);
            this.Controls.Add(this.lbl_Status);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.txt_Id);
            this.Controls.Add(this.lbl_Id);
            this.Controls.Add(this.panel_person);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ViewDetails";
            this.Size = new System.Drawing.Size(790, 590);
            this.Load += new System.EventHandler(this.ViewDetails_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_person.ResumeLayout(false);
            this.panel_person.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Qualification;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_Qualification;
        private System.Windows.Forms.TextBox txt_Designation;
        private System.Windows.Forms.Label lbl_Designation;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox combo_Class;
        private System.Windows.Forms.ComboBox combo_Section;
        private System.Windows.Forms.Label lbl_Section;
        private System.Windows.Forms.Label lbl_Class;
        private System.Windows.Forms.ComboBox combo_Status;
        private System.Windows.Forms.Label lbl_Status;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox txt_Id;
        private System.Windows.Forms.Label lbl_Id;
        private System.Windows.Forms.RadioButton radioBtn_Staff;
        private System.Windows.Forms.RadioButton radioBtn_Student;
        private System.Windows.Forms.Panel panel_person;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
