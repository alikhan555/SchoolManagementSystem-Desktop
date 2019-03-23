namespace SchoolManagement.Accounts
{
    partial class GetAmount
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
            this.components = new System.ComponentModel.Container();
            this.timer_CurrentDateTime = new System.Windows.Forms.Timer(this.components);
            this.lbl_EnterId = new System.Windows.Forms.Label();
            this.txt_StudentId = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btn_SubmitFees = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_Amount = new System.Windows.Forms.Label();
            this.txt_Amount = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.Datepicker_SelectDate = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label1 = new System.Windows.Forms.Label();
            this.MonthYear = new System.Windows.Forms.Label();
            this.radioButton_Student = new System.Windows.Forms.RadioButton();
            this.radioButton_Staff = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lbl_EnterId
            // 
            this.lbl_EnterId.AutoSize = true;
            this.lbl_EnterId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EnterId.Location = new System.Drawing.Point(242, 63);
            this.lbl_EnterId.Name = "lbl_EnterId";
            this.lbl_EnterId.Size = new System.Drawing.Size(61, 18);
            this.lbl_EnterId.TabIndex = 148;
            this.lbl_EnterId.Text = "Enter ID";
            // 
            // txt_StudentId
            // 
            this.txt_StudentId.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_StudentId.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_StudentId.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_StudentId.BorderThickness = 1;
            this.txt_StudentId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_StudentId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_StudentId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_StudentId.isPassword = false;
            this.txt_StudentId.Location = new System.Drawing.Point(351, 57);
            this.txt_StudentId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_StudentId.Name = "txt_StudentId";
            this.txt_StudentId.Size = new System.Drawing.Size(210, 29);
            this.txt_StudentId.TabIndex = 147;
            this.txt_StudentId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btn_SubmitFees
            // 
            this.btn_SubmitFees.Location = new System.Drawing.Point(333, 392);
            this.btn_SubmitFees.Name = "btn_SubmitFees";
            this.btn_SubmitFees.Size = new System.Drawing.Size(114, 32);
            this.btn_SubmitFees.TabIndex = 144;
            this.btn_SubmitFees.Text = "Submit";
            this.btn_SubmitFees.UseVisualStyleBackColor = true;
            this.btn_SubmitFees.Click += new System.EventHandler(this.btn_SubmitFees_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label4.Location = new System.Drawing.Point(503, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 24);
            this.label4.TabIndex = 141;
            this.label4.Text = "/=";
            // 
            // lbl_Amount
            // 
            this.lbl_Amount.AutoSize = true;
            this.lbl_Amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Amount.Location = new System.Drawing.Point(262, 299);
            this.lbl_Amount.Name = "lbl_Amount";
            this.lbl_Amount.Size = new System.Drawing.Size(59, 18);
            this.lbl_Amount.TabIndex = 136;
            this.lbl_Amount.Text = "Amount";
            // 
            // txt_Amount
            // 
            this.txt_Amount.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Amount.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Amount.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Amount.BorderThickness = 1;
            this.txt_Amount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Amount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Amount.isPassword = false;
            this.txt_Amount.Location = new System.Drawing.Point(382, 293);
            this.txt_Amount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Amount.Name = "txt_Amount";
            this.txt_Amount.Size = new System.Drawing.Size(114, 29);
            this.txt_Amount.TabIndex = 135;
            this.txt_Amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Datepicker_SelectDate
            // 
            this.Datepicker_SelectDate.BackColor = System.Drawing.Color.Gray;
            this.Datepicker_SelectDate.BorderRadius = 0;
            this.Datepicker_SelectDate.ForeColor = System.Drawing.Color.White;
            this.Datepicker_SelectDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Datepicker_SelectDate.FormatCustom = null;
            this.Datepicker_SelectDate.Location = new System.Drawing.Point(380, 129);
            this.Datepicker_SelectDate.Name = "Datepicker_SelectDate";
            this.Datepicker_SelectDate.Size = new System.Drawing.Size(161, 29);
            this.Datepicker_SelectDate.TabIndex = 149;
            this.Datepicker_SelectDate.Value = new System.DateTime(2018, 12, 28, 22, 6, 34, 773);
            this.Datepicker_SelectDate.onValueChanged += new System.EventHandler(this.Datepicker_SelectDate_onValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(249, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 18);
            this.label1.TabIndex = 150;
            this.label1.Text = "Select Date";
            // 
            // MonthYear
            // 
            this.MonthYear.AutoSize = true;
            this.MonthYear.Location = new System.Drawing.Point(432, 170);
            this.MonthYear.Name = "MonthYear";
            this.MonthYear.Size = new System.Drawing.Size(65, 13);
            this.MonthYear.TabIndex = 151;
            this.MonthYear.Text = "Month_Year";
            // 
            // radioButton_Student
            // 
            this.radioButton_Student.AutoSize = true;
            this.radioButton_Student.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.radioButton_Student.Location = new System.Drawing.Point(313, 224);
            this.radioButton_Student.Name = "radioButton_Student";
            this.radioButton_Student.Size = new System.Drawing.Size(76, 22);
            this.radioButton_Student.TabIndex = 152;
            this.radioButton_Student.TabStop = true;
            this.radioButton_Student.Text = "Student";
            this.radioButton_Student.UseVisualStyleBackColor = true;
            //this.radioButton_Student.CheckedChanged += new System.EventHandler(this.radioButton_Student_CheckedChanged);
            // 
            // radioButton_Staff
            // 
            this.radioButton_Staff.AutoSize = true;
            this.radioButton_Staff.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.radioButton_Staff.Location = new System.Drawing.Point(421, 224);
            this.radioButton_Staff.Name = "radioButton_Staff";
            this.radioButton_Staff.Size = new System.Drawing.Size(56, 22);
            this.radioButton_Staff.TabIndex = 153;
            this.radioButton_Staff.TabStop = true;
            this.radioButton_Staff.Text = "Staff";
            this.radioButton_Staff.UseVisualStyleBackColor = true;
            // 
            // GetAmount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.radioButton_Staff);
            this.Controls.Add(this.radioButton_Student);
            this.Controls.Add(this.MonthYear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Datepicker_SelectDate);
            this.Controls.Add(this.lbl_EnterId);
            this.Controls.Add(this.txt_StudentId);
            this.Controls.Add(this.btn_SubmitFees);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_Amount);
            this.Controls.Add(this.txt_Amount);
            this.Name = "GetAmount";
            this.Size = new System.Drawing.Size(790, 500);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer_CurrentDateTime;
        private System.Windows.Forms.Label lbl_EnterId;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_StudentId;
        private System.Windows.Forms.Button btn_SubmitFees;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_Amount;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_Amount;
        private Bunifu.Framework.UI.BunifuDatepicker Datepicker_SelectDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label MonthYear;
        private System.Windows.Forms.RadioButton radioButton_Student;
        private System.Windows.Forms.RadioButton radioButton_Staff;
    }
}
