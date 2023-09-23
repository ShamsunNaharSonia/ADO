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
    public partial class FrmRegister : Form
    {
        string conStr = ConfigurationManager.ConnectionStrings["db"].ConnectionString;
        public FrmRegister()
        {
            InitializeComponent();
        }

        private void btnRegSave_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(conStr);
            string sqlQuery = "insert into LogIN_t values(@fullName,@contact,@email,@userName,@userPassword)";


            SqlCommand cmd = new SqlCommand(sqlQuery, con);
            


            cmd.Parameters.AddWithValue("@fullName", txtname.Text);
            cmd.Parameters.AddWithValue("@contact", txtcontact.Text);
            cmd.Parameters.AddWithValue("@email", txtemail.Text);
            cmd.Parameters.AddWithValue("@userName", txtusername.Text);
            cmd.Parameters.AddWithValue("@userPassword", txtpassword.Text);

            con.Open();
            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Registered Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Registered Failed", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
}
