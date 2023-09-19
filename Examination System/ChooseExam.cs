using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Examination_System
{
    public partial class ChooseExam : Form
    {
        public ChooseExam(int insid , int crsid)
        {
            InitializeComponent();
            instid = insid;
            idcrs = crsid;
        }
        SqlConnection SqlCN;
        SqlCommand sqlCmd;
        SqlDataAdapter DA;
        DataTable dt;
        int instid;
        int idcrs;

        private void ChooseExam_Load(object sender, EventArgs e)
        {
            SqlCN = new SqlConnection();

            SqlCN.ConnectionString = "Data Source=.;Initial Catalog=Examination_System; " +
                "Integrated Security = true ; TrustServerCertificate=true";

            sqlCmd = new SqlCommand();
            sqlCmd.Connection = SqlCN;

            sqlCmd.CommandText = $"select * from Exam where Crs_ID =@crsid";
            sqlCmd.Parameters.AddWithValue("@crsid", idcrs);
            SqlCN.Close();
            SqlCN.Open();
            DA = new SqlDataAdapter(sqlCmd);
            dt = new();
            DA.Fill(dt);
            dataGridView1.DataSource = dt;
            comexamid.DataSource = dt;
            comexamid.DisplayMember = "Exam_ID";
            comexamid.ValueMember = "Exam_ID";


            SqlCN.Close();

        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            this.Hide();
            ExamViewInstructor form = new (instid, int.Parse(comexamid.SelectedValue.ToString()), idcrs);
            form.Show();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            Instructor_Home form = new Instructor_Home(instid);
            form.Show();
        }
    }
}
