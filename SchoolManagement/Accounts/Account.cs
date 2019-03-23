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
    public partial class Account : UserControl
    {
        public Account()
        {
            InitializeComponent();
        }

        private void FeesSubmission_Click(object sender, EventArgs e)
        {
            feesSubmissionForm1.BringToFront();
        }

        private void btn_StaffSalary_Click(object sender, EventArgs e)
        {
        }

        private void btn_ViewAccounts_Click(object sender, EventArgs e)
        {
            //viewAccountDetails1.BringToFront();
        }

        private void btn_ViewDetails_Click(object sender, EventArgs e)
        {
            try
            {
                panel_MenuLine.Left = ((Bunifu.Framework.UI.BunifuThinButton2)sender).Left;
                panel_MenuLine.Width = ((Bunifu.Framework.UI.BunifuThinButton2)sender).Width;

            }
            catch { }
            finally { viewDetails1.BringToFront(); }

        }

        private void btn_GetAmount_Click(object sender, EventArgs e)
        {
            try
            {
                panel_MenuLine.Left = ((Bunifu.Framework.UI.BunifuThinButton2)sender).Left;
                panel_MenuLine.Width = ((Bunifu.Framework.UI.BunifuThinButton2)sender).Width;

            }
            catch { }
            finally { getAmount1.BringToFront(); }

        }
    }
}
