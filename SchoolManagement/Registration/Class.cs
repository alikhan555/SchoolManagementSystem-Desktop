using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SchoolManagement.Registration.Classes;
using System.IO;

namespace SchoolManagement.Registration
{
    public partial class Class : UserControl
    {
        public Class()
        {
            InitializeComponent();



        }

        private void btn_CreateClass_Click(object sender, EventArgs e)
        {
            if (txt_Class.Text != "")
            {

                var Class = new SchoolClass(txt_Class.Text);
                if (Class.CreateClass() == true)
                {
                    MessageBox.Show("Class Created Sucessfully");
                    Directory.CreateDirectory("Quiz/" + txt_Class.Text);
                    txt_Class.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Empty! Plz enter class name");
            }
        }

        private void btn_CreateSection_Click(object sender, EventArgs e)
        {
            if (txt_Section.Text != "")
            {

                DbClient.QueryExecute("insert into Section (name) VALUES('" + txt_Section.Text + "')");
                MessageBox.Show("Section Created Sucessfully");
                txt_Section.Text = "";


            }
            else
            {
                MessageBox.Show("Empty! Plz enter Section name");
            }

        }
    }
}
