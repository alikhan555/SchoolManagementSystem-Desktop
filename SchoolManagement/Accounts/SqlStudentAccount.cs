using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SchoolManagement.Accounts
{
    public class SqlStudentAccount : IAccount
    {
        private int studentId;

        public SqlStudentAccount(int studentid)
        {
            this.studentId = studentid;
        }

        public SqlStudentAccount()
        {

        }


        public void GetAmount(string month_year, int amount)
        {

            DbClient.QueryExecute("update Student set amount=" + amount + ", amountlog='" + month_year + "' WHERE Id=" + studentId);


        }



        public bool CheckBalance(int id)
        {
            List<string> balance = new List<string>();
            balance = DbClient.GetColumnData("Student", "amountlog", " Where id=" + id);
            string[] stamp = balance[0].Split('/');
            string submitMonth = stamp[0];
            string currentMonth = DateTime.Now.Month.ToString();
            string prevMonth = DateTime.Now.AddMonths(-1).ToString();
            if (submitMonth == currentMonth || submitMonth == prevMonth)
            {
                return true;
            }
            else
            {
                return false;
            }


        }





        /* public void ShowAccountData(DataGridView dataGridView, int id, string monthYear, bool status, string _class, string _section)
         {
             List<string> studentIDs = new List<string>();

             if (id == 0) studentIDs = DbClient.GetColumnData("Student", "id", "WHERE class='" + _class + "' AND section='" + _section + "' AND status='" + status + "'");
             else if (id != 0) studentIDs.Add(id.ToString());


             DataTable dt = new DataTable();
             dt.Columns.Add("ID", typeof(string));
             dt.Columns.Add(monthYear, typeof(string));

             foreach (string studentID in studentIDs)
             {
                 string query = "SELECT [StudentID],[" + monthYear + "] FROM StudentAccount WHERE StudentID=" + studentID + "";
                 SqlCommand cmd = new SqlCommand(query, DbClient._connection);
                 SqlDataReader sdr = cmd.ExecuteReader();
                 sdr.Read();

                 DataRow dr = dt.NewRow();

                 dr["ID"] = sdr[0].ToString();
                 if (sdr[1] != DBNull.Value) dr[monthYear] = sdr[1].ToString();
                 else dr[monthYear] = "Not Submited";
                 dt.Rows.Add(dr);
                 sdr.Close();
             }

             dataGridView.DataSource = dt;
         }*/
    }
}
