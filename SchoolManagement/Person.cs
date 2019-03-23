using System;
using System.Windows.Forms;
using SchoolManagement.Accounts;

namespace SchoolManagement
{
    public abstract class Person
    {
        protected int id;
        protected string cnic;
        protected string name;
        protected string fathername;
        protected string fathercnic;
        protected string mobile;
        protected string contact;
        protected string email;
        protected string address1;
        protected string address2;
        protected string _registerdate;
        protected string password;
        protected bool _status;
        protected byte[] photobyte;

        public Person()
        {

        }

        public Person(int id, string cnic, string name, string fathername, string fathercnic, string mobile, string contact, string email, string address1, string address2, bool _status, byte[] photobyte, string password)
        {
            _registerdate = DateTime.Now.ToShortDateString();
            this.id = id;
            this.cnic = cnic;
            this.name = name;
            this.fathername = fathername;
            this.fathercnic = fathercnic;
            this.mobile = mobile;
            this.contact = contact;
            this.email = email;
            this.address1 = address1;
            this.address2 = address2;
            this._status = _status;
            this.photobyte = photobyte;
            this.password = password;
        }

        public int Id
        {
            get
            {
                return id;
            }
        }



        public abstract void Save();

        public abstract void Update();

        public abstract void ShowData(DataGridView dataGridView);

        public abstract void GetAmount(IAccount account, string monthyear, int amount);

    }
}