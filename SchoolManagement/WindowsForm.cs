using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagement
{
    public partial class WindowsForm : Form
    {
        public WindowsForm(string id, string person)
        {
            InitializeComponent();
            registerForm1.ForUpdate(id, person);
        }

        private void WindowsForm_Load(object sender, EventArgs e)
        {
            registerForm1.BringToFront();
            
        }
    }
}
