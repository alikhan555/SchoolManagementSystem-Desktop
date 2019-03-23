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
    public partial class Register : UserControl
    {
        public Register()
        {
            InitializeComponent();
        }

        private void btn_ViewDetails_Click(object sender, EventArgs e)
        {
            try
            {
                panel_MenuLine.Left = ((Bunifu.Framework.UI.BunifuThinButton2)sender).Left;
                panel_MenuLine.Width = ((Bunifu.Framework.UI.BunifuThinButton2)sender).Width;

            }
            catch{ }
            finally{ viewDetails1.BringToFront(); }
             

        }

        private void btn_NewStudent_Click(object sender, EventArgs e)
        {
            try
            {
                panel_MenuLine.Left = ((Bunifu.Framework.UI.BunifuThinButton2)sender).Left;
                panel_MenuLine.Width = ((Bunifu.Framework.UI.BunifuThinButton2)sender).Width;

            }
            catch { }
            finally { registerForm1.BringToFront(); registerForm1.ForNewRegister(); }



        }


        private void btn_ClassesSections_Click(object sender, EventArgs e)
        {
            try
            {
                panel_MenuLine.Left = ((Bunifu.Framework.UI.BunifuThinButton2)sender).Left;
                panel_MenuLine.Width = ((Bunifu.Framework.UI.BunifuThinButton2)sender).Width;

            }
            catch { }
            finally { class1.BringToFront(); }
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }
    }
}
