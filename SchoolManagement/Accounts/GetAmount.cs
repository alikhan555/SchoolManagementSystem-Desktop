using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagement.Accounts
{
    public partial class GetAmount : UserControl
    {
        public GetAmount()
        {
            InitializeComponent();
            MonthYear.Text = DateTime.Now.ToShortDateString();
        }

        private void btn_SubmitFees_Click(object sender, EventArgs e)
        {
            if (txt_Amount.Text != "" && txt_StudentId.Text != "" && MonthYear.Text != "Month_Year")
            {
                int id = int.Parse(txt_StudentId.Text);
                Person person = new Student();
                if (radioButton_Student.Checked == true)
                {
                    try
                    {
                        person.GetAmount(new SqlStudentAccount(id), MonthYear.Text, int.Parse(txt_Amount.Text));
                        MessageBox.Show("Fees Submitted Sucessfully");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error " + ex.Message);
                    }
                }


                else if (radioButton_Staff.Checked == true)
                {
                    try
                    {
                        person.GetAmount(new SqlStaffAccount(id), MonthYear.Text, int.Parse(txt_Amount.Text));
                        MessageBox.Show("Salary Recieved!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error " + ex.Message);
                    }
                }


            }

            else
            {
                MessageBox.Show("Please Enter Required Information");
            }
        }

        private void Datepicker_SelectDate_onValueChanged(object sender, EventArgs e)
        {

            MonthYear.Text = Datepicker_SelectDate.Value.ToShortDateString();

        }




    }
}
