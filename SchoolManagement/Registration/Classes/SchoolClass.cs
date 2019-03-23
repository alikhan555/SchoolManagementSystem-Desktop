using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Registration.Classes
{
    public class SchoolClass
    {
        private int classId;
        private string name;

        public SchoolClass(string name)
        {
            this.name = name;
        }


        public bool CreateClass()
        {
            DbClient.QueryExecute("INSERT INTO Class(name) VALUES(' " + name + "  ')");
            return true;
        }


    }
}
