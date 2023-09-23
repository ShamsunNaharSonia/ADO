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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string conStr = ConfigurationManager.ConnectionStrings["db"].ConnectionString;
            
            
            SqlConnection con = new SqlConnection(conStr);
            string sqlQuery = "select userName,userPassword from LogIN_t where userName='" + txtUserName.Text + "' and userPassword='" + txtPassword.Text + "'";

            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(sqlQuery, con);
            DataTable dt = new DataTable();

            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                this.Hide();
                TheMemorialUniversity mu = new TheMemorialUniversity();
                mu.Show();

                

            }
            else
            {
                MessageBox.Show("Invalid Username or Password ","Error ");
            }
            con.Close();
        }

       
       


        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmRegister fr = new FrmRegister();
            fr.Show();
        }

        

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmForgotPass fp = new frmForgotPass();
            fp.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }













        //private void checkBox1_CheckedChanged(object sender, EventArgs e)
        //{
        //    bool check = checkBox1.Checked;
        //    switch (check)
        //    {
        //        case true:

        //            txtPassword.UseSystemPasswordChar = false;
        //            break;

        //        default:
        //            txtPassword.UseSystemPasswordChar = true;
        //            break;

        //    }
        //}


    }
}
