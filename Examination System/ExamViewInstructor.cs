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
    public partial class ExamViewInstructor : Form
    {
        public ExamViewInstructor(int id, int r, int crs)
        {
            InitializeComponent();
            exid = id;
            insid = r;
            crsid = crs;
        }
        SqlConnection SqlCN;

        SqlCommand sqlCmd;
        SqlDataAdapter DA;
        DataTable dt;
        int exid;
        int insid;
        int crsid;

        GroupBox[] groupboxs = new GroupBox[10];
        RadioButton[] radioButtons = new RadioButton[40];

        private void ExamViewInstructor_Load(object sender, EventArgs e)
        {
            sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Connection = SqlCN;
            SqlCN.Open();
            sqlCmd.CommandText = "FormateExam";
            sqlCmd.Parameters.Add(new SqlParameter("exid", exid));

            DA = new SqlDataAdapter(sqlCmd);
            dt = new();
            DA.Fill(dt);
            int i = 0;
            int j = 0;
            foreach (DataRow item in dt.Rows)
            {
                groupboxs[i] = new GroupBox();
                groupboxs[i++].Text = item["ques"].ToString();

                radioButtons[j] = new RadioButton();
                radioButtons[j++].Text = item["q1"].ToString();

                radioButtons[j] = new RadioButton();
                radioButtons[j++].Text = item["q2"].ToString();

                radioButtons[j] = new RadioButton();
                radioButtons[j++].Text = item["q3"].ToString();

                radioButtons[j] = new RadioButton();
                radioButtons[j++].Text = item["q4"].ToString();

            }



            int plbl = 20;
            for (int a = 0; a < 10; a++)
            {
                int prad = 61;

                groupboxs[a].AutoSize = true;
                groupboxs[a].Location = new Point(0, plbl);
                groupboxs[a].Size = new Size(1000, 200);

                this.Controls.Add(groupboxs[a]);

                for (int b = (a * 4); b < (a * 4) + 4; b++)
                {
                    radioButtons[b].Location = new Point(0, prad);

                    radioButtons[b].AutoSize = true;
                    if (radioButtons[b].Text != " ")
                        groupboxs[a].Controls.Add((RadioButton)radioButtons[b]);
                    prad += 30;
                }

                plbl += 230;

            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChooseExam form = new ChooseExam(insid, crsid);
            form.Show();
        }

    }

    
}
