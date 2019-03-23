using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SchoolManagement
{
    public partial class Login : Form
    {
        public static Person logged;
        string conn = @"Data Source=SHEILD-PC\SQLEXPRESS;Initial Catalog='School Management System';Integrated Security=True;MultipleActiveResultSets=true;";

        public Login()
        {
            InitializeComponent();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (txt_LoginId.Text != "" && txt_LoginPass.Text != "")
            {

                SqlConnection sql = new SqlConnection(conn);
                sql.Open();
                string query = "select * from Student where id=" + int.Parse(txt_LoginId.Text) + " and password='" + txt_LoginPass.Text + "' ";
                SqlCommand cmd = new SqlCommand(query, sql);
                using (SqlDataReader dr = cmd.ExecuteReader())
                {

                    if (dr.HasRows == true)
                    {
                        this.Hide();
                        Form_Dashboard home = new Form_Dashboard();
                        home.Show();

                        logged = new Student();

                    }
                    else
                    {


                        MessageBox.Show("Login Failed");
                    }
                }

                sql.Close();



                SqlConnection sqlStaff = new SqlConnection(conn);
                sqlStaff.Open();
                string querystaff = "select * from Staff where id=" + int.Parse(txt_LoginId.Text) + " and password='" + txt_LoginPass.Text + "' ";
                SqlCommand cmdstaff = new SqlCommand(query, sql);
                using (SqlDataReader drstaff = cmdstaff.ExecuteReader())
                {

                    if (drstaff.HasRows == true)
                    {
                        this.Hide();
                        Form_Dashboard home = new Form_Dashboard();
                        home.Show();
                        logged = new Staff();

                    }

                    else
                    {


                        MessageBox.Show("Login Failed");
                    }
                }






                sqlStaff.Close();



            }



            else
            {
                MessageBox.Show("Please Enter Your Login Information");
            }


        }
    }
}
