using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examination_System
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }



        private void btnLogIn_Click(object sender, EventArgs e)
        {
            lblValidate.Visible = false;
            if (comboBox1.SelectedIndex == 0)
            {
                this.Hide();

                Instructor_login form = new Instructor_login();
                form.Show();
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                this.Hide();
                Student_Login form = new Student_Login();
                form.Show();
            }
            else
            {
                lblValidate.Visible = true;
                lblValidate.Text = "Please Choose Your Role!";
            }
        }
    }
}
