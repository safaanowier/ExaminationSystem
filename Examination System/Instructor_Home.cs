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
    public partial class Instructor_Home : Form
    {
        int ins_id;
        public Instructor_Home(int instructorid )
        {
            InitializeComponent();
            ins_id = instructorid;
        }

        private void btngenerate_Click(object sender, EventArgs e)
        {
            this.Hide();
            GenerateExam form = new GenerateExam(ins_id);
            form.Show();
        }

        private void btnshowexam_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChooseExam form = new ChooseExam(ins_id , 5);
            form.Show();

        }
    }
}
