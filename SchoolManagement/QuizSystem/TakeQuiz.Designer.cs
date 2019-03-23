namespace SchoolManagement.QuizSystem
{
    partial class TakeQuiz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TakeQuiz));
            this.AvailableQuiz = new System.Windows.Forms.ComboBox();
            this.btn_Next = new Bunifu.Framework.UI.BunifuFlatButton();
            this.radioButton_OptionD = new System.Windows.Forms.RadioButton();
            this.radioButton_OptionC = new System.Windows.Forms.RadioButton();
            this.radioButton_OptionB = new System.Windows.Forms.RadioButton();
            this.radioButton_OptionA = new System.Windows.Forms.RadioButton();
            this.lbl_QuizTitle = new System.Windows.Forms.Label();
            this.lbl_TotalQuestion = new System.Windows.Forms.Label();
            this.lbl_TotalQuestions = new System.Windows.Forms.Label();
            this.txt_Question = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btn_SubmitQuiz = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lbl_QuestionNo = new System.Windows.Forms.Label();
            this.txt_QuestionNo = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lbl_Class = new System.Windows.Forms.Label();
            this.lbl_SelectQuiz = new System.Windows.Forms.Label();
            this.combo_Class = new System.Windows.Forms.ComboBox();
            this.lbl_Score = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AvailableQuiz
            // 
            this.AvailableQuiz.FormattingEnabled = true;
            this.AvailableQuiz.Location = new System.Drawing.Point(7, 110);
            this.AvailableQuiz.Name = "AvailableQuiz";
            this.AvailableQuiz.Size = new System.Drawing.Size(121, 21);
            this.AvailableQuiz.TabIndex = 73;
            this.AvailableQuiz.SelectedValueChanged += new System.EventHandler(this.AvailableQuiz_SelectedValueChanged);
            this.AvailableQuiz.Click += new System.EventHandler(this.AvailableQuiz_Click);
            // 
            // btn_Next
            // 
            this.btn_Next.Activecolor = System.Drawing.SystemColors.HotTrack;
            this.btn_Next.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Next.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Next.BorderRadius = 0;
            this.btn_Next.ButtonText = "Next";
            this.btn_Next.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Next.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Next.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Next.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Next.Iconimage")));
            this.btn_Next.Iconimage_right = null;
            this.btn_Next.Iconimage_right_Selected = null;
            this.btn_Next.Iconimage_Selected = null;
            this.btn_Next.IconMarginLeft = 0;
            this.btn_Next.IconMarginRight = 0;
            this.btn_Next.IconRightVisible = true;
            this.btn_Next.IconRightZoom = 0D;
            this.btn_Next.IconVisible = true;
            this.btn_Next.IconZoom = 90D;
            this.btn_Next.IsTab = false;
            this.btn_Next.Location = new System.Drawing.Point(328, 440);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Normalcolor = System.Drawing.SystemColors.HotTrack;
            this.btn_Next.OnHovercolor = System.Drawing.SystemColors.HotTrack;
            this.btn_Next.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Next.selected = false;
            this.btn_Next.Size = new System.Drawing.Size(101, 36);
            this.btn_Next.TabIndex = 72;
            this.btn_Next.Text = "Next";
            this.btn_Next.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Next.Textcolor = System.Drawing.Color.White;
            this.btn_Next.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // radioButton_OptionD
            // 
            this.radioButton_OptionD.AutoSize = true;
            this.radioButton_OptionD.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.radioButton_OptionD.Location = new System.Drawing.Point(253, 337);
            this.radioButton_OptionD.Name = "radioButton_OptionD";
            this.radioButton_OptionD.Size = new System.Drawing.Size(78, 19);
            this.radioButton_OptionD.TabIndex = 71;
            this.radioButton_OptionD.TabStop = true;
            this.radioButton_OptionD.Text = "Option D";
            this.radioButton_OptionD.UseVisualStyleBackColor = true;
            // 
            // radioButton_OptionC
            // 
            this.radioButton_OptionC.AutoSize = true;
            this.radioButton_OptionC.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.radioButton_OptionC.Location = new System.Drawing.Point(253, 297);
            this.radioButton_OptionC.Name = "radioButton_OptionC";
            this.radioButton_OptionC.Size = new System.Drawing.Size(77, 19);
            this.radioButton_OptionC.TabIndex = 70;
            this.radioButton_OptionC.TabStop = true;
            this.radioButton_OptionC.Text = "Option C";
            this.radioButton_OptionC.UseVisualStyleBackColor = true;
            // 
            // radioButton_OptionB
            // 
            this.radioButton_OptionB.AutoSize = true;
            this.radioButton_OptionB.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.radioButton_OptionB.Location = new System.Drawing.Point(253, 255);
            this.radioButton_OptionB.Name = "radioButton_OptionB";
            this.radioButton_OptionB.Size = new System.Drawing.Size(77, 19);
            this.radioButton_OptionB.TabIndex = 69;
            this.radioButton_OptionB.TabStop = true;
            this.radioButton_OptionB.Text = "Option B";
            this.radioButton_OptionB.UseVisualStyleBackColor = true;
            // 
            // radioButton_OptionA
            // 
            this.radioButton_OptionA.AutoSize = true;
            this.radioButton_OptionA.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.radioButton_OptionA.Location = new System.Drawing.Point(253, 216);
            this.radioButton_OptionA.Name = "radioButton_OptionA";
            this.radioButton_OptionA.Size = new System.Drawing.Size(77, 19);
            this.radioButton_OptionA.TabIndex = 68;
            this.radioButton_OptionA.TabStop = true;
            this.radioButton_OptionA.Text = "Option A";
            this.radioButton_OptionA.UseVisualStyleBackColor = true;
            // 
            // lbl_QuizTitle
            // 
            this.lbl_QuizTitle.AutoSize = true;
            this.lbl_QuizTitle.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_QuizTitle.Location = new System.Drawing.Point(400, 15);
            this.lbl_QuizTitle.Name = "lbl_QuizTitle";
            this.lbl_QuizTitle.Size = new System.Drawing.Size(108, 25);
            this.lbl_QuizTitle.TabIndex = 67;
            this.lbl_QuizTitle.Text = "Quiz Title";
            // 
            // lbl_TotalQuestion
            // 
            this.lbl_TotalQuestion.AutoSize = true;
            this.lbl_TotalQuestion.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TotalQuestion.Location = new System.Drawing.Point(519, 75);
            this.lbl_TotalQuestion.Name = "lbl_TotalQuestion";
            this.lbl_TotalQuestion.Size = new System.Drawing.Size(18, 20);
            this.lbl_TotalQuestion.TabIndex = 66;
            this.lbl_TotalQuestion.Text = "0";
            // 
            // lbl_TotalQuestions
            // 
            this.lbl_TotalQuestions.AutoSize = true;
            this.lbl_TotalQuestions.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TotalQuestions.Location = new System.Drawing.Point(372, 75);
            this.lbl_TotalQuestions.Name = "lbl_TotalQuestions";
            this.lbl_TotalQuestions.Size = new System.Drawing.Size(128, 20);
            this.lbl_TotalQuestions.TabIndex = 65;
            this.lbl_TotalQuestions.Text = "Total Questions";
            // 
            // txt_Question
            // 
            this.txt_Question.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Question.BorderColorIdle = System.Drawing.Color.Gray;
            this.txt_Question.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Question.BorderThickness = 2;
            this.txt_Question.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Question.Enabled = false;
            this.txt_Question.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_Question.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Question.isPassword = false;
            this.txt_Question.Location = new System.Drawing.Point(376, 132);
            this.txt_Question.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Question.Name = "txt_Question";
            this.txt_Question.Size = new System.Drawing.Size(356, 32);
            this.txt_Question.TabIndex = 64;
            this.txt_Question.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btn_SubmitQuiz
            // 
            this.btn_SubmitQuiz.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_SubmitQuiz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_SubmitQuiz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_SubmitQuiz.BorderRadius = 0;
            this.btn_SubmitQuiz.ButtonText = "Submit Quiz";
            this.btn_SubmitQuiz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SubmitQuiz.DisabledColor = System.Drawing.Color.Gray;
            this.btn_SubmitQuiz.Enabled = false;
            this.btn_SubmitQuiz.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_SubmitQuiz.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_SubmitQuiz.Iconimage")));
            this.btn_SubmitQuiz.Iconimage_right = null;
            this.btn_SubmitQuiz.Iconimage_right_Selected = null;
            this.btn_SubmitQuiz.Iconimage_Selected = null;
            this.btn_SubmitQuiz.IconMarginLeft = 0;
            this.btn_SubmitQuiz.IconMarginRight = 0;
            this.btn_SubmitQuiz.IconRightVisible = true;
            this.btn_SubmitQuiz.IconRightZoom = 0D;
            this.btn_SubmitQuiz.IconVisible = true;
            this.btn_SubmitQuiz.IconZoom = 90D;
            this.btn_SubmitQuiz.IsTab = false;
            this.btn_SubmitQuiz.Location = new System.Drawing.Point(451, 440);
            this.btn_SubmitQuiz.Name = "btn_SubmitQuiz";
            this.btn_SubmitQuiz.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_SubmitQuiz.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_SubmitQuiz.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_SubmitQuiz.selected = false;
            this.btn_SubmitQuiz.Size = new System.Drawing.Size(129, 36);
            this.btn_SubmitQuiz.TabIndex = 63;
            this.btn_SubmitQuiz.Text = "Submit Quiz";
            this.btn_SubmitQuiz.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SubmitQuiz.Textcolor = System.Drawing.Color.White;
            this.btn_SubmitQuiz.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SubmitQuiz.Click += new System.EventHandler(this.btn_SubmitQuiz_Click);
            // 
            // lbl_QuestionNo
            // 
            this.lbl_QuestionNo.AutoSize = true;
            this.lbl_QuestionNo.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_QuestionNo.Location = new System.Drawing.Point(176, 137);
            this.lbl_QuestionNo.Name = "lbl_QuestionNo";
            this.lbl_QuestionNo.Size = new System.Drawing.Size(106, 20);
            this.lbl_QuestionNo.TabIndex = 62;
            this.lbl_QuestionNo.Text = "Question No";
            // 
            // txt_QuestionNo
            // 
            this.txt_QuestionNo.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_QuestionNo.BorderColorIdle = System.Drawing.Color.Gray;
            this.txt_QuestionNo.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_QuestionNo.BorderThickness = 2;
            this.txt_QuestionNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_QuestionNo.Enabled = false;
            this.txt_QuestionNo.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_QuestionNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_QuestionNo.isPassword = false;
            this.txt_QuestionNo.Location = new System.Drawing.Point(295, 135);
            this.txt_QuestionNo.Margin = new System.Windows.Forms.Padding(4);
            this.txt_QuestionNo.Name = "txt_QuestionNo";
            this.txt_QuestionNo.Size = new System.Drawing.Size(50, 26);
            this.txt_QuestionNo.TabIndex = 61;
            this.txt_QuestionNo.Text = "1";
            this.txt_QuestionNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lbl_Class
            // 
            this.lbl_Class.AutoSize = true;
            this.lbl_Class.Location = new System.Drawing.Point(40, 18);
            this.lbl_Class.Name = "lbl_Class";
            this.lbl_Class.Size = new System.Drawing.Size(65, 13);
            this.lbl_Class.TabIndex = 74;
            this.lbl_Class.Text = "Select Class";
            // 
            // lbl_SelectQuiz
            // 
            this.lbl_SelectQuiz.AutoSize = true;
            this.lbl_SelectQuiz.Location = new System.Drawing.Point(40, 80);
            this.lbl_SelectQuiz.Name = "lbl_SelectQuiz";
            this.lbl_SelectQuiz.Size = new System.Drawing.Size(61, 13);
            this.lbl_SelectQuiz.TabIndex = 76;
            this.lbl_SelectQuiz.Text = "Select Quiz";
            // 
            // combo_Class
            // 
            this.combo_Class.FormattingEnabled = true;
            this.combo_Class.Location = new System.Drawing.Point(7, 46);
            this.combo_Class.Name = "combo_Class";
            this.combo_Class.Size = new System.Drawing.Size(121, 21);
            this.combo_Class.TabIndex = 75;
            this.combo_Class.Click += new System.EventHandler(this.txt_Class_Click);
            // 
            // lbl_Score
            // 
            this.lbl_Score.AutoSize = true;
            this.lbl_Score.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Score.Location = new System.Drawing.Point(534, 263);
            this.lbl_Score.Name = "lbl_Score";
            this.lbl_Score.Size = new System.Drawing.Size(25, 28);
            this.lbl_Score.TabIndex = 77;
            this.lbl_Score.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(489, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 23);
            this.label2.TabIndex = 78;
            this.label2.Text = "Your Score";
            // 
            // TakeQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_Score);
            this.Controls.Add(this.lbl_SelectQuiz);
            this.Controls.Add(this.combo_Class);
            this.Controls.Add(this.lbl_Class);
            this.Controls.Add(this.AvailableQuiz);
            this.Controls.Add(this.btn_Next);
            this.Controls.Add(this.radioButton_OptionD);
            this.Controls.Add(this.radioButton_OptionC);
            this.Controls.Add(this.radioButton_OptionB);
            this.Controls.Add(this.radioButton_OptionA);
            this.Controls.Add(this.lbl_QuizTitle);
            this.Controls.Add(this.lbl_TotalQuestion);
            this.Controls.Add(this.lbl_TotalQuestions);
            this.Controls.Add(this.txt_Question);
            this.Controls.Add(this.btn_SubmitQuiz);
            this.Controls.Add(this.lbl_QuestionNo);
            this.Controls.Add(this.txt_QuestionNo);
            this.Name = "TakeQuiz";
            this.Size = new System.Drawing.Size(790, 500);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox AvailableQuiz;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Next;
        private System.Windows.Forms.RadioButton radioButton_OptionD;
        private System.Windows.Forms.RadioButton radioButton_OptionC;
        private System.Windows.Forms.RadioButton radioButton_OptionB;
        private System.Windows.Forms.RadioButton radioButton_OptionA;
        private System.Windows.Forms.Label lbl_QuizTitle;
        private System.Windows.Forms.Label lbl_TotalQuestion;
        private System.Windows.Forms.Label lbl_TotalQuestions;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_Question;
        private Bunifu.Framework.UI.BunifuFlatButton btn_SubmitQuiz;
        private System.Windows.Forms.Label lbl_QuestionNo;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_QuestionNo;
        private System.Windows.Forms.Label lbl_Class;
        private System.Windows.Forms.Label lbl_SelectQuiz;
        private System.Windows.Forms.ComboBox combo_Class;
        private System.Windows.Forms.Label lbl_Score;
        private System.Windows.Forms.Label label2;
    }
}
