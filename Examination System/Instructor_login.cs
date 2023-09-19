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
    public partial class Instructor_login : Form
    {
        public Instructor_login()
        {
            InitializeComponent();
        }

        SqlConnection SqlCN;
        SqlCommand sqlCmd;
        SqlDataAdapter DA;
        DataTable dt;

        private void btnSignUpIns_Click(object sender, EventArgs e)
        {
            SqlCN = new SqlConnection();

            SqlCN.ConnectionString = "Data Source=.;Initial Catalog=Examination_System; " +
                          "Integrated Security = true ; TrustServerCertificate=true";

            sqlCmd = new SqlCommand("select * from Instructor where Ins_Name=@UserName and Ins_ID =@Password", SqlCN);

            sqlCmd.Parameters.AddWithValue("@UserName", txtUserName.Text);
            sqlCmd.Parameters.AddWithValue("@Password", txtPassword.Text).ToString();

            DA = new SqlDataAdapter(sqlCmd);
            dt = new DataTable();
            DA.Fill(dt);
            SqlCN.Open();
            int i = sqlCmd.ExecuteNonQuery();
            SqlCN.Close();
            if (dt.Rows.Count > 0)
            {
                this.Hide();

                Instructor_Home form = new (int.Parse(txtPassword.Text));
                form.Show();
            }
            else
            {
                MessageBox.Show("Please enter Correct Username and Password");
            }
        }
    }
}
