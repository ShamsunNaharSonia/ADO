using AdmissionManagementSystem.Entities;
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
    public partial class TheMemorialUniversity : Form
    {
        string conStr = ConfigurationManager.ConnectionStrings["db"].ConnectionString;
        public TheMemorialUniversity()
        {
            InitializeComponent();
        }

       

       

       

        private void btnAdmission_Click(object sender, EventArgs e)
        {
          frmAdmission f1 = new frmAdmission();
            
            f1.Show();
        }

        private void btnStudentInfo_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you want to exit application", "Exit message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<FormViewModel> list = new List<FormViewModel>();
            using (SqlConnection con = new SqlConnection(conStr))
            {
                string SqlQuery = "SELECT rg.StudentId ,rg.EmployeeId,rg.SemesterId,rg.DepartmentId,rg.StudentName,rg.FathersName,rg.DateOfBirth,rg.RegistrationNo,rg.AdmitDate,rg.AdmitFee, de.DepartmentName, se.SemesterName,em.EmployeeName,rg.ImgPath FROM Registration_t rg JOIN Department_t de ON de.DepartmentId =rg.DepartmentId JOIN Semester_t se ON se.SemesterId=rg.SemesterId JOIN Employee_t em ON rg.EmployeeId=em.EmployeeId";
                SqlDataAdapter sda = new SqlDataAdapter(SqlQuery, con);
                DataTable dt = new DataTable();
                con.Open();
                sda.Fill(dt);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    FormViewModel objAdmit = new FormViewModel();
                    objAdmit.StudentId = Convert.ToInt32(dt.Rows[i]["StudentId"].ToString());
                    objAdmit.EmployeeId = Convert.ToInt32(dt.Rows[i]["EmployeeId"].ToString());
                    objAdmit.SemesterId = Convert.ToInt32(dt.Rows[i]["SemesterId"].ToString());
                    // objAdmit.EmployeeId = Convert.ToInt32(dt.Rows[i]["EmployeeId"].ToString());
                    objAdmit.DepartmentId = Convert.ToInt32(dt.Rows[i]["DepartmentId"].ToString());
                    objAdmit.StudentName = dt.Rows[i]["StudentName"].ToString();
                    objAdmit.FathersName = dt.Rows[i]["FathersName"].ToString();
                    objAdmit.DateOfBirth = Convert.ToDateTime(dt.Rows[i]["DateOfBirth"].ToString());
                    objAdmit.RegistrationNo = Convert.ToInt32(dt.Rows[i]["RegistrationNo"].ToString());
                    objAdmit.AdmitDate = Convert.ToDateTime(dt.Rows[i]["AdmitDate"].ToString());
                    // objAdmit.Quantity = Convert.ToInt32(dt.Rows[i]["Quantity"].ToString());
                     objAdmit.AdmitFee = Convert.ToDecimal(dt.Rows[i]["AdmitFee"].ToString());
                    objAdmit.DepartmentName = dt.Rows[i]["DepartmentName"].ToString();


                    objAdmit.SemesterName = dt.Rows[i]["SemesterName"].ToString();
                    objAdmit.EmployeeName = dt.Rows[i]["EmployeeName"].ToString();
                    objAdmit.ImgPath = dt.Rows[i]["ImgPath"].ToString();
                    // objAdmit.PurchaseId = Convert.ToInt32(dt.Rows[i]["PurchaseId"].ToString());
                    list.Add(objAdmit);
                }

            }
            using (AdmissionReportViewer form = new AdmissionReportViewer(list))
            {
                form.ShowDialog();
            }

        }

    }
}
