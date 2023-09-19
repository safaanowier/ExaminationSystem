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
    public partial class Result : Form
    {
        string stid;
        int examid;
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;
        Label[] labels = new Label[10];
        Label[] answers = new Label[10];
        public Result(string stud_id , int exam_id )
        {
            InitializeComponent();
            stid = stud_id;
            examid = exam_id;
        }

        private void Result_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection();
            conn.ConnectionString = "Data Source=.;Initial Catalog=Examination_System; " +
                "Integrated Security = true ; TrustServerCertificate=true";
            conn.Open();
            cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Exam_Correction";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("exam_id", examid));
            cmd.Parameters.Add(new SqlParameter("stud_id", stid));
            int grade = int.Parse(cmd.ExecuteScalar().ToString());
            label1.Text = "Your Exam Results is "+grade+" out of 20";
            label1.Font = new Font("tempus sans itc", 14, FontStyle.Italic);
            label1.ForeColor = Color.DodgerBlue;

            cmd.Parameters.Clear();
            cmd.CommandText = "Model_Answer";
            cmd.Parameters.Add(new SqlParameter("examid", examid));

           adapter = new SqlDataAdapter(cmd);
            dt = new();
            adapter.Fill(dt);
            int i = 0;
            foreach (DataRow item in dt.Rows)
            {
                labels[i] = new Label();
                labels[i].Text = item["q_name"].ToString();
                answers[i] = new Label();
                answers[i].Text = item["model_ans"].ToString();
                i++;
            }



            int plbl = 80;
            int pans = 120;
            this.AutoScroll = true;
            for (int a = 0; a < 10; a++)
            {
                labels[a].AutoSize = true;
                labels[a].Location = new Point(0, plbl);
                labels[a].Size = new Size(1000, 200);
                labels[a].Font = new Font("tempus sans itc", 14, FontStyle.Italic);
                this.Controls.Add(labels[a]);
               answers[a].Location = new Point(0, pans);
               answers[a].AutoSize = true;
                answers[a].ForeColor = Color.DodgerBlue;
                answers[a].Font = new Font("tempus sans itc", 14, FontStyle.Italic);
              this.Controls.Add(answers[a]);
                pans += 80;
                plbl += 80;
               

            }


        }
    }
}
