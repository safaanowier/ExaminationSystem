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
    public partial class Student_Login : Form
    {
        public Student_Login()
        {
            InitializeComponent();
        }
        SqlConnection SqlCN;
        SqlCommand sqlCmd;
        SqlDataAdapter DA;
        DataTable dt;

        private void btnSignUpStud_Click(object sender, EventArgs e)
        {
            SqlCN = new SqlConnection();

            SqlCN.ConnectionString = "Data Source=.;Initial Catalog=Examination_System; " +
                         "Integrated Security = true ; TrustServerCertificate=true";

            SqlCommand cmd = new SqlCommand("select Email, Password, National_ID from Student S where Email=@UserName and Password =@Password", SqlCN);




            cmd.Parameters.AddWithValue("@UserName", txtUserName.Text);
            cmd.Parameters.AddWithValue("@Password", txtPassword.Text);

            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            dt = new DataTable();
            sda.Fill(dt);

            //SqlCN.Open();
            //int i = cmd.ExecuteNonQuery();
            //SqlCN.Close();

            DataRow dr = dt.Rows[0];
            if (dt.Rows.Count > 0)
            {

                this.Hide();
                Student_Home form = new Student_Home();
                form.Show();

            }
            else
            {
                MessageBox.Show("Please enter Correct Username and Password");
            }

        }
    }
}
