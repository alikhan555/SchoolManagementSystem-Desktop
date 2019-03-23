using System;
using System.Windows.Forms;
using SchoolManagement.Accounts;
using SchoolManagement.QuizSystem;

namespace SchoolManagement
{
    public class Staff : Person
    {
        public string qualification;
        private string _program;
        private string _designation;
        private int _age;
        private bool _maritalstatus;

        string _query;
        public Staff()
        {

        }
        public Staff(string designation, string qualification, bool status)
        {
            this._designation = designation;
            this.qualification = qualification;
            this._status = status;
        }

        public Staff(int id)
        {
            this.id = id;
        }

        public Staff(string qualification, string program, string designation, int age, bool martialstatus, int id, string cnic, string name, string fathername, string fathercnic, string mobile, string contact, string email, string address1, string address2, bool _status, byte[] photoByte, string password) : base(id, cnic, name, fathername, fathercnic, mobile, contact, email, address1, address2, _status, photoByte, password)
        {
            this.qualification = qualification;
            this._program = program;
            this._designation = designation;
            this._age = age;
            this._maritalstatus = martialstatus;
        }

        public override void Save()
        {
            _query = "INSERT INTO Staff (name,cnic,fathername,fathercnic,age,registerdate,qualification,program,designation,maritalstatus,status,mobile,contact,email,address1,address2,photo,password) VALUES('" + name + "','" + cnic + "','" + fathername + "','" + fathercnic + "','" + _age + "','" + _registerdate + "','" + qualification + "','" + _program + "','" + _designation + "','" + _maritalstatus + "','" + _status + "','" + mobile + "','" + contact + "','" + email + "','" + address1 + "','" + address2 + "',@img,'" + password + "')";

            DbClient.QueryExecute(_query, photobyte);
        }

        public override void Update()
        {
            _query = "UPDATE Staff SET name='" + name + "' , cnic='" + cnic + "' , fathername='" + fathername + "' , fathercnic='" + fathercnic + "' , age='" + _age + "' , registerdate='" + _registerdate + "' , qualification='" + qualification + "' , program='" + _program + "' , designation='" + _designation + "' , maritalstatus='" + _maritalstatus + "' , status='" + _status + "' , mobile='" + mobile + "' , contact='" + contact + "' , email='" + email + "' , address1='" + address1 + "' , address2='" + address2 + "' , photo=@img , password='" + password + "' WHERE id='" + id + "'";

            DbClient.QueryExecute(_query, photobyte);
        }





        public override void ShowData(DataGridView dataGridView)
        {
            if (id == 0) _query = "SELECT id,name,cnic,fathername,mobile FROM Staff WHERE designation='" + _designation + "' AND status='" + _status + "' AND qualification='" + qualification + "'";

            else if (id != 0) _query = "SELECT id,name,cnic,fathername,mobile FROM Staff WHERE id='" + id + "'";

            DbClient.DatGridFill(dataGridView, _query);
        }


        public override void GetAmount(IAccount account, string monthyear, int amount)
        {
            account.GetAmount(monthyear, amount);
        }


        public void CreateQuiz(IQuiz createQuiz)
        {
            createQuiz.CreateQuiz();
        }

    }
}