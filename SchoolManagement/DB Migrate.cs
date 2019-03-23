using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SchoolManagement
{
    class DB_Migrate
    {
        public static void Backup(SqlConnection con, string databaseName)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Backup Files (*.bak)|*.bak";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                if (con.State == ConnectionState.Closed) con.Open();
                SqlCommand cmd = new SqlCommand("BACKUP DATABASE [" + databaseName + "] TO DISK = '" + sfd.FileName + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public static void Restore(SqlConnection con, string databaseName)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Backup File(*.bak)|*.bak";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if (con.State == ConnectionState.Closed) con.Open();
                SqlCommand cmd1 = new SqlCommand("ALTER DATABASE [" + databaseName + "] SET SINGLE_USER WITH ROLLBACK IMMeDIATE", con);
                cmd1.ExecuteNonQuery();
                
                SqlCommand cmd2 = new SqlCommand("USE MASTER RESTORE DATABASE [" + databaseName + "] FROM DISK='" + ofd.FileName + "' WITH REPLACE", con);
                cmd2.ExecuteNonQuery();

                SqlCommand cmd3 = new SqlCommand("ALTER DATABASE [" + databaseName + "] SET MULTI_USER", con);
                cmd3.ExecuteNonQuery();

                con.Close();
            }
        }
    }
}