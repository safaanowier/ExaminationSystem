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
    public partial class Student_Home : Form
    {
        public Student_Home(string stid = "11111111111111")
        {
            InitializeComponent();
            std_id = stid;
        }
        string std_id;

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Exam exam = new Exam();
            exam.Show();
        }
    }
}
