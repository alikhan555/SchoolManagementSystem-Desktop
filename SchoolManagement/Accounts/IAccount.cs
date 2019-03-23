using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Accounts
{
    public interface IAccount
    {


        void GetAmount(string month_year, int amount);

        bool CheckBalance(int id);

    }
}
