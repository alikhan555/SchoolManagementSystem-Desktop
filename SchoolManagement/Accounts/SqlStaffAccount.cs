using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Accounts
{
    public class SqlStaffAccount : IAccount
    {
        private int Id;

        public SqlStaffAccount(int id)
        {
            this.Id = id;
        }

        public SqlStaffAccount()
        {

        }


        public void GetAmount(string month_year, int amount)
        {
            DbClient.QueryExecute("update Staff set amount=" + amount + ",amountlog='" + month_year + "' WHERE Id=" + Id);
        }

        public bool CheckBalance(int id)
        {
            List<string> balance = new List<string>();
            balance = DbClient.GetColumnData("Staff", "amountlog", " Where id=" + id);
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

    }
}
