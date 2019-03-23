namespace SchoolManagement
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label_Teacher = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel_Student = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label_Student = new System.Windows.Forms.Label();
            this.panel_ImageStudent = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel_Student.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label_Teacher);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(312, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(263, 103);
            this.panel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(23, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "25";
            // 
            // label_Teacher
            // 
            this.label_Teacher.AutoSize = true;
            this.label_Teacher.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Teacher.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label_Teacher.Location = new System.Drawing.Point(15, 64);
            this.label_Teacher.Name = "label_Teacher";
            this.label_Teacher.Size = new System.Drawing.Size(64, 21);
            this.label_Teacher.TabIndex = 1;
            this.label_Teacher.Text = "Teacher";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(168, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(95, 103);
            this.panel2.TabIndex = 0;
            // 
            // panel_Student
            // 
            this.panel_Student.BackColor = System.Drawing.Color.White;
            this.panel_Student.Controls.Add(this.label1);
            this.panel_Student.Controls.Add(this.label_Student);
            this.panel_Student.Controls.Add(this.panel_ImageStudent);
            this.panel_Student.Location = new System.Drawing.Point(18, 15);
            this.panel_Student.Name = "panel_Student";
            this.panel_Student.Size = new System.Drawing.Size(263, 103);
            this.panel_Student.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(23, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "256";
            // 
            // label_Student
            // 
            this.label_Student.AutoSize = true;
            this.label_Student.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Student.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label_Student.Location = new System.Drawing.Point(15, 64);
            this.label_Student.Name = "label_Student";
            this.label_Student.Size = new System.Drawing.Size(64, 21);
            this.label_Student.TabIndex = 1;
            this.label_Student.Text = "Student";
            // 
            // panel_ImageStudent
            // 
            this.panel_ImageStudent.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_ImageStudent.BackgroundImage")));
            this.panel_ImageStudent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_ImageStudent.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_ImageStudent.Location = new System.Drawing.Point(168, 0);
            this.panel_ImageStudent.Name = "panel_ImageStudent";
            this.panel_ImageStudent.Size = new System.Drawing.Size(95, 103);
            this.panel_ImageStudent.TabIndex = 0;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_Student);
            this.Name = "Home";
            this.Size = new System.Drawing.Size(657, 561);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_Student.ResumeLayout(false);
            this.panel_Student.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_Teacher;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel_Student;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_Student;
        private System.Windows.Forms.Panel panel_ImageStudent;
    }
}
