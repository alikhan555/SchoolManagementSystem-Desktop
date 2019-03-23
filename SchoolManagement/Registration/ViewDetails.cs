using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagement.Registration
{
    public partial class ViewDetails : UserControl
    {
        public ViewDetails()
        {
            InitializeComponent();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (radioBtn_Student.Checked == true)
            {
                Person person = new Student(int.Parse(txt_Id.Text));
                person.ShowData(dataGridView1);
            }
            else if (radioBtn_Staff.Checked == true)
            {
                Person person = new Staff(int.Parse(txt_Id.Text));
                person.ShowData(dataGridView1);
            }
        }

        private void radioBtn_Student_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Show();
            panel2.Hide();
            lbl_Status.Show();
            combo_Status.Show();
            txt_Id.Enabled = true;
            btn_Search.Enabled = true;
        }

        private void radioBtn_Staff_CheckedChanged(object sender, EventArgs e)
        {
            panel2.Show();
            panel1.Hide();
            lbl_Status.Show();
            combo_Status.Show();
            txt_Id.Enabled = true;
            btn_Search.Enabled = true;
        }

        private void ViewDetails_Load(object sender, EventArgs e)
        {
            DbClient.FillCombo(combo_Section, "Section", "name");

            txt_Id.Enabled = false;
            btn_Search.Enabled = false;
            panel1.Hide();
            panel2.Hide();
            lbl_Status.Hide();
            combo_Status.Hide();
            radioBtn_Student.Checked = true;
            combo_Section.SelectedIndex = 0;
        }

        private void txt_Qualification_TextChanged(object sender, EventArgs e)
        {
            if (radioBtn_Student.Checked == true && combo_Class.SelectedIndex != -1 && combo_Section.SelectedIndex != -1 && combo_Status.SelectedIndex != -1)
            {
                Person person = new Student(combo_Class.SelectedItem.ToString(), combo_Section.SelectedItem.ToString(), StatusToBool(combo_Status.SelectedItem.ToString()));
                person.ShowData(dataGridView1);
            }

            if (radioBtn_Staff.Checked == true && txt_Designation.Text != "" && txt_Qualification.Text != "" && combo_Status.SelectedIndex != -1)
            {
                Person person = new Staff(txt_Designation.Text, txt_Qualification.Text, StatusToBool(combo_Status.SelectedItem.ToString()));
                person.ShowData(dataGridView1);

            }
        }


        bool StatusToBool(string status)
        {
            bool temp = false;
            switch (status)
            {
                case "Active":
                    {
                        temp = true;
                        break;
                    }
                case "Inactive":
                    {
                        temp = false;
                        break;
                    }
                default:
                    {
                        temp = true;
                        break;
                    }
            }
            return temp;
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            string person = "";
            if (radioBtn_Staff.Checked == true) person = "Staff";
            else if (radioBtn_Student.Checked == true) person = "Student";
            WindowsForm wf = new WindowsForm(dataGridView1.CurrentRow.Cells[0].Value.ToString(), person);
            wf.Show();
        }

        private void combo_Class_Click(object sender, EventArgs e)
        {
            combo_Class.Items.Clear();
            DbClient.FillCombo(combo_Class, "Class", "name");
        }

        private void combo_Section_Click(object sender, EventArgs e)
        {
            combo_Section.Items.Clear();
            DbClient.FillCombo(combo_Section, "Section", "name");

        }
    }
}