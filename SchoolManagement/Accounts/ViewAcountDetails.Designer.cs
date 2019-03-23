namespace SchoolManagement.Accounts
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.radioBtn_Staff = new System.Windows.Forms.RadioButton();
            this.radioBtn_Student = new System.Windows.Forms.RadioButton();
            this.btn_Search = new System.Windows.Forms.Button();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.lbl_Id = new System.Windows.Forms.Label();
            this.combo_Class = new System.Windows.Forms.ComboBox();
            this.combo_Section = new System.Windows.Forms.ComboBox();
            this.lbl_Section = new System.Windows.Forms.Label();
            this.lbl_Class = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_person = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel_person.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 146);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(700, 342);
            this.dataGridView1.TabIndex = 133;
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
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(447, 17);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(54, 24);
            this.btn_Search.TabIndex = 137;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // txt_Id
            // 
            this.txt_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Id.Location = new System.Drawing.Point(276, 17);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Size = new System.Drawing.Size(165, 24);
            this.txt_Id.TabIndex = 136;
            // 
            // lbl_Id
            // 
            this.lbl_Id.AutoSize = true;
            this.lbl_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Id.Location = new System.Drawing.Point(230, 20);
            this.lbl_Id.Name = "lbl_Id";
            this.lbl_Id.Size = new System.Drawing.Size(24, 18);
            this.lbl_Id.TabIndex = 135;
            this.lbl_Id.Text = "ID";
            // 
            // combo_Class
            // 
            this.combo_Class.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_Class.FormattingEnabled = true;
            this.combo_Class.Location = new System.Drawing.Point(82, 13);
            this.combo_Class.Name = "combo_Class";
            this.combo_Class.Size = new System.Drawing.Size(102, 21);
            this.combo_Class.TabIndex = 107;
            // 
            // combo_Section
            // 
            this.combo_Section.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_Section.FormattingEnabled = true;
            this.combo_Section.Location = new System.Drawing.Point(82, 40);
            this.combo_Section.Name = "combo_Section";
            this.combo_Section.Size = new System.Drawing.Size(102, 21);
            this.combo_Section.TabIndex = 111;
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
            // panel1
            // 
            this.panel1.Controls.Add(this.combo_Class);
            this.panel1.Controls.Add(this.combo_Section);
            this.panel1.Controls.Add(this.lbl_Section);
            this.panel1.Controls.Add(this.lbl_Class);
            this.panel1.Location = new System.Drawing.Point(14, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 74);
            this.panel1.TabIndex = 140;
            // 
            // panel_person
            // 
            this.panel_person.Controls.Add(this.radioBtn_Staff);
            this.panel_person.Controls.Add(this.radioBtn_Student);
            this.panel_person.Location = new System.Drawing.Point(14, 11);
            this.panel_person.Name = "panel_person";
            this.panel_person.Size = new System.Drawing.Size(143, 37);
            this.panel_person.TabIndex = 134;
            // 
            // ViewDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.txt_Id);
            this.Controls.Add(this.lbl_Id);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_person);
            this.Name = "ViewDetails";
            this.Size = new System.Drawing.Size(790, 500);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_person.ResumeLayout(false);
            this.panel_person.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton radioBtn_Staff;
        private System.Windows.Forms.RadioButton radioBtn_Student;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox txt_Id;
        private System.Windows.Forms.Label lbl_Id;
        private System.Windows.Forms.ComboBox combo_Class;
        private System.Windows.Forms.ComboBox combo_Section;
        private System.Windows.Forms.Label lbl_Section;
        private System.Windows.Forms.Label lbl_Class;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_person;
    }
}
