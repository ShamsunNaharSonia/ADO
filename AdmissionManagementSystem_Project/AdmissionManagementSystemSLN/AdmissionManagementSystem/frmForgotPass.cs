using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdmissionManagementSystem
{
    public partial class frmForgotPass : Form
    {
        string conStr = ConfigurationManager.ConnectionStrings["db"].ConnectionString;
        public frmForgotPass()
        {
            InitializeComponent();
        }

        private void btnshowPass_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conStr);
            string sqlQuery = "select userPassword from LogIN_t where userName=@userName and contact=@contact";


            SqlCommand cmd = new SqlCommand(sqlQuery, con);
            cmd.Parameters.AddWithValue("@userName", txtusername.Text);
            cmd.Parameters.AddWithValue("@contact", txtMobile.Text);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txtPassword.Text = dr[0].ToString();
            }
            else
            {
                MessageBox.Show("invalid Username or Contact number");
            }
            dr.Close();
            con.Close();

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
