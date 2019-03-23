using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SchoolManagement
{
    public partial class DB_Migrator : UserControl
    {
        public DB_Migrator()
        {
            InitializeComponent();            
        }

        private void btn_Backup_Click(object sender, EventArgs e)
        {
            lbl_Message.Text = "Database is being backup...";
            try
            {
                DB_Migrate.Backup(DbClient._connection, DbClient.DBName);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            lbl_Message.Text = "Database has been backed up.";
        }

        private void btn_Restore_Click(object sender, EventArgs e)
        {
            lbl_Message.Text = "Database is being Restore...";
            try
            {
                DB_Migrate.Restore(DbClient._connection, DbClient.DBName);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            lbl_Message.Text = "Database has been Restored.";
        }
    }
}