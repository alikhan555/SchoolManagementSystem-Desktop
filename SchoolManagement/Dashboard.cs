using System;
using System.Windows.Forms;
using SchoolManagement.ReportsStats;

namespace SchoolManagement
{
    public partial class Form_Dashboard : Form
    {

        public Form_Dashboard()
        {
            InitializeComponent();

            // Bring To Front Home User Control


            home1.BringToFront();


        }

        private void btn_MinimizeApplication_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;

        }

        private void btn_CloseApplication_Click(object sender, EventArgs e)
        {
            timer_Exit.Start();
            //Application.Exit();
        }

        private void btn_Registeration_Click(object sender, EventArgs e)
        {
            register1.BringToFront();
        }

        private void btn_Dashboard_Click(object sender, EventArgs e)
        {

            home1.BringToFront();

        }

        private void timer_Minimize_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0.0)
            {
                this.Opacity -= 0.025;
            }
            else
            {
                timer_Exit.Stop();
                Application.Exit();

            }
        }

        private void btn_BackupRestore_Click(object sender, EventArgs e)
        {
            dB_Migrator1.BringToFront();
        }

        private void home1_Load(object sender, EventArgs e)
        {

        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_ManageAccounts_Click(object sender, EventArgs e)
        {
            account1.BringToFront();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Reports_Click(object sender, EventArgs e)
        {
            statsMain1.BringToFront();
        }
    }
}
