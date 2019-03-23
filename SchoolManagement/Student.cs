using System;
using System.Windows.Forms;
using SchoolManagement.Accounts;
using SchoolManagement.QuizSystem;

namespace SchoolManagement
{
    public class Student : Person
    {
        private string _class;
        private string _section;
        private string _dateofbirth;

        private string _query;
        public Student()
        {

        }

        public Student(int id, string clas)
        {
            this.id = id;
            this._class = clas;
        }


        public Student(string clas, string section, bool status)
        {
            this._class = clas;
            this._section = section;
            this._status = status;
        }

        public Student(int id)
        {
            this.id = id;
        }

        public Student(string clas, string section, string dateofbirth, int id, string cnic, string name, string fathername, string fathercnic, string mobile, string contact, string email, string address1, string address2, bool _status, byte[] photobyte, string password) : base(id, cnic, name, fathername, fathercnic, mobile, contact, email, address1, address2, _status, photobyte, password)
        {
            _class = clas;
            _section = section;
            _dateofbirth = dateofbirth;
        }

        public string ClassId
        {
            get
            {
                return _class;
            }
        }



        public override void Save()
        {
            _query = "INSERT INTO Student (name,cnic,fathername,fathercnic,dateofbirth,class,section,registerdate,status,mobile,contact,email,address1,address2,photo,password) VALUES('" + name + "','" + cnic + "','" + fathername + "','" + fathercnic + "','" + _dateofbirth + "','" + _class + "','" + _section + "','" + _registerdate + "','" + _status + "','" + mobile + "','" + contact + "','" + email + "','" + address1 + "','" + address2 + "',@img,'" + password + "')";

            DbClient.QueryExecute(_query, photobyte);
        }

        public override void Update()
        {
            _query = "UPDATE Student SET name='" + name + "' , cnic='" + cnic + "' , fathername='" + fathername + "' , fathercnic='" + fathercnic + "' , dateofbirth='" + _dateofbirth + "' , class='" + _class + "' , section='" + _section + "' , registerdate='" + _registerdate + "' , status='" + _status + "' , mobile='" + mobile + "' , contact='" + contact + "' , email='" + email + "' , address1='" + address1 + "' , address2='" + address2 + "' , photo=@img, password='" + password + "' WHERE id='" + id + "' ";

            DbClient.QueryExecute(_query, photobyte);
        }

        public override void ShowData(DataGridView dataGridView)
        {
            if (id == 0) _query = "SELECT id,name,fathername,cnic,mobile FROM Student WHERE class='" + _class + "' AND section='" + _section + "' AND status='" + _status + "'";
            else if (id != 0) _query = "SELECT id,name,fathername,cnic,mobile FROM Student WHERE id='" + id + "'";

            DbClient.DatGridFill(dataGridView, _query);
        }



        public override void GetAmount(IAccount account, string monthyear, int amount)
        {
            account.GetAmount(monthyear, amount);
        }


        public void TakeQuiz(IQuiz take)
        {
            take.TakeQuiz();
        }



    }
}