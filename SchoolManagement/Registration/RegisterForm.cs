using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SchoolManagement.Accounts;

namespace SchoolManagement.Registration
{
    public partial class RegisterForm : UserControl
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btn_CaptureImage_Click(object sender, EventArgs e)
        {
            WebCamCapture capture = new WebCamCapture(pictureBox_ProfileImage);
            capture.ShowDialog();
        }

        private void btn_BrowseImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "JPEG files (*.jpeg)|*.jpeg|PNG files (*.png)|*.png|All Files (*.*)|*.*";
            ofd.Title = "Select profile picture";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox_ProfileImage.ImageLocation = ofd.FileName;
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (btn_Save.Text == "Enable") { EnableAllItems(); btn_Save.Text = "Update"; radioBtn_Staff.Enabled = false; radioBtn_Student.Enabled = false; }
            else if (txt_FullName.Text == "") MessageBox.Show("Full Name could not be empty.");
            else if (txt_cnic.Text == "") MessageBox.Show("CNIC could not be empty.");
            else if (pictureBox_ProfileImage.Image == null) MessageBox.Show("Photo could not be null.");
            else if (txt_Password.Text == "") MessageBox.Show("Password can not be empty.");
            else
            {
                Person person;

                if (radioBtn_Student.Checked == true)
                {
                    person = new Student(combo_Class.Text, combo_Section.Text, dateTime_DOB.Text, Convert.ToInt32(DbClient.GetLastId("Student")), txt_cnic.Text, txt_FullName.Text, txt_FatherName.Text, txt_FatherCnic.Text, txt_MobileNo.Text, txt_PhoneNo.Text, txt_Email.Text, txt_Address1.Text, txt_Address2.Text, StatusToBool(comboBox_Status.SelectedItem.ToString()), Picture.PictureBoxToByte(pictureBox_ProfileImage), txt_Password.Text);

                    if (btn_Save.Text == "Save")
                    {
                        person.Save();
                        MessageBox.Show("Saved successfully.");
                    }
                    else
                    {
                        person.Update();
                        MessageBox.Show("Update successfully.");
                    }
                    ClearFields();
                }

                else if (radioBtn_Staff.Checked == true)
                {
                    if (txt_Age.Text == "") MessageBox.Show("Age can not be empty");
                    else
                    {
                        person = new Staff(txt_Qualification.Text, txt_Program.Text, txt_Designation.Text, int.Parse(txt_Age.Text), MaritalStatusToBool(comboBox_MaritalStatus.SelectedItem.ToString()), Convert.ToInt32(DbClient.GetLastId("Staff")), txt_cnic.Text, txt_FullName.Text, txt_FatherName.Text, txt_FatherCnic.Text, txt_MobileNo.Text, txt_PhoneNo.Text, txt_Email.Text, txt_Address1.Text, txt_Address2.Text, StatusToBool(comboBox_Status.SelectedItem.ToString()), Picture.PictureBoxToByte(pictureBox_ProfileImage), txt_Password.Text);

                        if (btn_Save.Text == "Save")
                        {
                            person.Save();
                            MessageBox.Show("Saved successfully.");
                        }
                        else if (btn_Save.Text == "Update")
                        {
                            person.Update();
                            MessageBox.Show("Update successfully.");
                        }
                        ClearFields();
                    }
                }
            }
            FillNextID();
        }

        public void ForNewRegister()
        {
            btn_Save.Text = "Save";

            radioBtn_Student.Select();
            comboBox_Status.SelectedIndex = 0;
            comboBox_MaritalStatus.SelectedIndex = 1;

            radioBtn_Student.Checked = true;
        }

        public void ForUpdate(string id, string person)
        {
            btn_Save.Text = "Enable";
            DisableAllItems();
            lbl_PersonId.Text = id;

            string query = "SELECT * FROM " + person + " WHERE id='" + lbl_PersonId.Text + "'";
            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(query, DbClient._connection);
            System.Data.SqlClient.SqlDataReader sdr = cmd.ExecuteReader();
            sdr.Read();

            txt_FullName.Text = sdr["name"].ToString();
            txt_cnic.Text = sdr["cnic"].ToString();
            txt_FatherCnic.Text = sdr["fathercnic"].ToString();
            txt_FatherName.Text = sdr["fathername"].ToString();
            comboBox_Status.SelectedItem = BoolToStatus(bool.Parse(sdr["Status"].ToString()));
            txt_Address1.Text = sdr["Address1"].ToString();
            txt_Address2.Text = sdr["Address2"].ToString();
            txt_Email.Text = sdr["Email"].ToString();
            txt_MobileNo.Text = sdr["Mobile"].ToString();
            txt_PhoneNo.Text = sdr["contact"].ToString();
            Picture.ByteToPictureBox(pictureBox_ProfileImage, (byte[])sdr["photo"]);
            txt_Password.Text = sdr["Password"].ToString();

            switch (person)
            {
                case "Student":
                    {
                        dateTime_DOB.Text = sdr["dateofbirth"].ToString();
                        combo_Class.SelectedItem = sdr["Class"].ToString();
                        combo_Section.SelectedItem = sdr["Section"].ToString();
                        sdr.Close();

                        radioBtn_Student.Checked = true;
                        break;
                    }
                case "Staff":
                    {
                        txt_Qualification.Text = sdr["qualification"].ToString();
                        txt_Designation.Text = sdr["designation"].ToString();
                        txt_Program.Text = sdr["program"].ToString();
                        txt_Age.Text = sdr["age"].ToString();
                        comboBox_MaritalStatus.SelectedItem = BoolToMaritalStatus(bool.Parse(sdr["maritalstatus"].ToString()));
                        sdr.Close();

                        radioBtn_Staff.Checked = true;
                        break;
                    }
            }
        }

        public void ClearFields()
        {
            txt_FullName.Text = null; txt_FatherCnic.Text = null; txt_Email.Text = null; txt_FatherName.Text = null; txt_MobileNo.Text = null; txt_Password.Text = null; txt_Program.Text = null; txt_PhoneNo.Text = null; pictureBox_ProfileImage.Image = null;
            comboBox_MaritalStatus.SelectedIndex = 0; comboBox_Status.SelectedIndex = 0; combo_Class.SelectedIndex = -1; combo_Section.SelectedIndex = -1;
            txt_Address1.Text = null; txt_Address2.Text = null; txt_Age.Text = null; txt_cnic.Text = null; txt_Designation.Text = null; txt_Qualification.Text = null;
        }

        private void radioBtn_Staff_CheckedChanged(object sender, EventArgs e)
        {
            FillNextID();

            lbl_Class.Hide(); combo_Class.Hide(); lbl_Section.Hide(); combo_Section.Hide(); dateTime_DOB.Hide(); lbl_DOB.Hide();

            lbl_Qualification.Show(); txt_Qualification.Show(); lbl_Program.Show(); txt_Program.Show(); lbl_Designation.Show(); txt_Designation.Show(); comboBox_MaritalStatus.Show(); lbl_maritalStatus.Show(); txt_Age.Show(); lbl_Age.Show();
        }

        private void radioBtn_Student_CheckedChanged(object sender, EventArgs e)
        {
            FillNextID();

            lbl_Class.Show(); combo_Class.Show(); lbl_Section.Show(); combo_Section.Show(); dateTime_DOB.Show(); lbl_DOB.Show();

            lbl_Qualification.Hide(); txt_Qualification.Hide(); lbl_Program.Hide(); txt_Program.Hide(); lbl_Designation.Hide(); txt_Designation.Hide(); comboBox_MaritalStatus.Hide(); lbl_maritalStatus.Hide(); txt_Age.Hide(); lbl_Age.Hide();
        }

        public void FillNextID()
        {
            if (radioBtn_Staff.Checked == true)
            {
                int lastInsertId = (Convert.ToInt32(DbClient.GetLastId("Staff")) + 1);  // Get Last Insert Id
                lbl_PersonId.Text = lastInsertId.ToString();
            }

            else if (radioBtn_Student.Checked == true)
            {
                int lastInsertId = Convert.ToInt32(DbClient.GetLastId("Student")) + 1;  // Get Last Insert Id
                lbl_PersonId.Text = lastInsertId.ToString();
            }
        }

        public void DisableAllItems()
        {
            txt_FullName.Enabled = false; txt_FatherCnic.Enabled = false; txt_Email.Enabled = false; txt_FatherName.Enabled = false; txt_MobileNo.Enabled = false; txt_Password.Enabled = false; txt_Program.Enabled = false; txt_PhoneNo.Enabled = false; comboBox_MaritalStatus.Enabled = false; comboBox_Status.Enabled = false; combo_Class.Enabled = false; combo_Section.Enabled = false; txt_Address1.Enabled = false; txt_Address2.Enabled = false; txt_Age.Enabled = false; txt_cnic.Enabled = false; txt_Designation.Enabled = false; txt_Qualification.Enabled = false; btn_BrowseImage.Enabled = false; btn_CaptureImage.Enabled = false; dateTime_DOB.Enabled = false; radioBtn_Staff.Enabled = false; radioBtn_Student.Enabled = false;
        }
        public void EnableAllItems()
        {
            txt_FullName.Enabled = true; txt_FatherCnic.Enabled = true; txt_Email.Enabled = true; txt_FatherName.Enabled = true; txt_MobileNo.Enabled = true; txt_Password.Enabled = true; txt_Program.Enabled = true; txt_PhoneNo.Enabled = true; comboBox_MaritalStatus.Enabled = true; comboBox_Status.Enabled = true; combo_Class.Enabled = true; combo_Section.Enabled = true; txt_Address1.Enabled = true; txt_Address2.Enabled = true; txt_Age.Enabled = true; txt_cnic.Enabled = true; txt_Designation.Enabled = true; txt_Qualification.Enabled = true; btn_BrowseImage.Enabled = true; btn_CaptureImage.Enabled = true; dateTime_DOB.Enabled = true; radioBtn_Staff.Enabled = true; radioBtn_Student.Enabled = true;
        }

        bool MaritalStatusToBool(string status)
        {
            bool temp = false;
            switch (status)
            {
                case "Married":
                    {
                        temp = true;
                        break;
                    }
                case "Unmarried":
                    {
                        temp = false;
                        break;
                    }
                default:
                    {
                        temp = false;
                        break;
                    }
            }
            return temp;
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

        string BoolToStatus(bool status)
        {
            string temp;
            switch (status)
            {
                case true:
                    {
                        temp = "Active";
                        break;
                    }
                case false:
                    {
                        temp = "Inactive";
                        break;
                    }
                default:
                    {
                        temp = "Inactive";
                        break;
                    }
            }
            return temp;
        }

        string BoolToMaritalStatus(bool status)
        {
            string temp;
            switch (status)
            {
                case true:
                    {
                        temp = "Married";
                        break;
                    }
                case false:
                    {
                        temp = "Unmarried";
                        break;
                    }
                default:
                    {
                        temp = "Unmarried";
                        break;
                    }
            }
            return temp;
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