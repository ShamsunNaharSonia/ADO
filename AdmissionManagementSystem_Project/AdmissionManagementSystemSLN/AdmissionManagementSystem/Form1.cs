using AdmissionManagementSystem.Entities;
using AdmissionManagementSystem.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdmissionManagementSystem
{
    public partial class frmAdmission : Form
    {
        string conStr = ConfigurationManager.ConnectionStrings["db"].ConnectionString;
        int empId = 200;
        int StudentId = 0;
        string imgName;
        string filePath = "";
        string folderPath = @"C:\Users\ussl\Desktop\ID_1271720_Project\AdmissionManagementSystem_Project\AdmissionManagementSystemSLN\AdmissionManagementSystem\Resources\";
        string imagePathFromData;

        public frmAdmission()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmAdmission_Load(object sender, EventArgs e)
        {
            LoadEmployeeName();
            LoadComboDepartment();
            LoadComboSemester();
            pbStudent.Image = Resources.noimage;
            LoadGridView();
        }

        private void LoadGridView()
        {
            string sqlQuery = " select rg.StudentId,rg.RegistrationNo,rg.StudentName, rg.FathersName,rg.DateOfBirth,rg.Gender,de.DepartmentName,se.SemesterName,rg.AdmitFee,rg.AdmitDate,rg.ContactNo,em.EmployeeName,rg.ImgPath from Registration_t  rg join Semester_t se on se.SemesterId=rg.SemesterId join Employee_t em on em.EmployeeId=rg.EmployeeId join Department_t de on de.DepartmentId=rg.DepartmentId";
            SqlConnection con = new SqlConnection(conStr);
            SqlDataAdapter sda = new SqlDataAdapter(sqlQuery, con);
            DataTable dt = new DataTable();
            con.Open();
            sda.Fill(dt);
            dt.Columns.Add("Picture", Type.GetType("System.Byte[]"));
            foreach (DataRow dr in dt.Rows)
            {
                try
                {
                    dr["Picture"] = File.ReadAllBytes(dr["ImgPath"].ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            con.Close();
            dgvAdmission.RowTemplate.Height = 52;
            dgvAdmission.DataSource = dt;
            DataGridViewImageColumn dgvImage = new DataGridViewImageColumn();
            dgvImage = (DataGridViewImageColumn)dgvAdmission.Columns[13];
            dgvImage.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dgvAdmission.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void LoadComboSemester()
        {
            string sqlQuery = "SELECT * FROM Semester_t";
            SqlConnection con = new SqlConnection(conStr);
            SqlCommand cmd = new SqlCommand(sqlQuery, con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader, LoadOption.Upsert);
            if (dt != null)
            {
                cmbSemester.DisplayMember = "SemesterName";
                cmbSemester.ValueMember = "SemesterId";
                cmbSemester.DataSource = dt;
            }
            con.Close();
        }

        private void LoadComboDepartment()
        {
            string sqlQuery = "SELECT * FROM Department_t";
            SqlConnection con = new SqlConnection(conStr);
            SqlCommand cmd = new SqlCommand(sqlQuery, con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader, LoadOption.Upsert);
            if (dt != null)
            {
                cmbDepartment.DisplayMember = "DepartmentName";
                cmbDepartment.ValueMember = "DepartmentId";
                cmbDepartment.DataSource = dt;
            }

            con.Close();
        }

        private void LoadEmployeeName()
        {
            string userName = "";
            string sqlQuery = "SELECT EmployeeName FROM Employee_t WHERE EmployeeId='" + empId + "'";
            SqlConnection con = new SqlConnection(conStr);
            SqlCommand cmd = new SqlCommand(sqlQuery, con);
            con.Open();
            userName = (cmd.ExecuteScalar()).ToString();
            if (userName == "")
            {
                lblEmployeeName.Text = "Unknown";
            }
            lblEmployeeName.Text = userName;
            con.Close();
        }

       

       

        private void Clear()
        {
            txtDepartment.Text = "";
            txtSemester.Text = "";
            cmbDepartment.Text = "";
            cmbSemester.Text = "";
            txtRegNo.Clear();
            txtFatherName.Text = "";
            txtContactNo.Text = "";
            txtStudentName.Text = "";
            radioBtnMale.Checked = false;
            radioBtnFemale.Checked = false;
            txtAdmitFee.Text = "";

           pbStudent.Image = Resources.noimage;
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnAddDepartment_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtDepartment.Text) == true)
            {
                txtDepartment.Focus();
                errorProvider1.SetError(this.txtDepartment, "Please Enter Department Name");
                
            }
            else
            {
               Department objProduct = new Department();
                objProduct.DepartmentName = txtDepartment.Text;
                string sqlQuery = "Insert INTO Department_t (DepartmentName) VALUES ('" + objProduct.DepartmentName + "')";
                SqlConnection con = new SqlConnection(conStr);
                SqlCommand cmd = new SqlCommand(sqlQuery, con);
                con.Open();
                int rowCount = cmd.ExecuteNonQuery();
                if (rowCount > 0)
                {
                    MessageBox.Show("Department added successfully!", "Success", MessageBoxButtons.OK);
                    
                }
                else
                {
                    MessageBox.Show("Department Insertion failed!", "Failure", MessageBoxButtons.OK);
                   
                }
                con.Close();
                LoadComboDepartment();

            }
        }

        private void btnAddSemester_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtSemester.Text) == true)
            {
                txtSemester.Focus();
                errorProvider1.SetError(this.txtSemester, "Please Enter Semester Name");
             
            }
            else
            {
                Semester objProduct = new Semester();
                objProduct.SemesterName = txtSemester.Text;
                string sqlQuery = "Insert INTO Semester_t (SemesterName) VALUES ('" + objProduct.SemesterName + "')";
                SqlConnection con = new SqlConnection(conStr);
                SqlCommand cmd = new SqlCommand(sqlQuery, con);
                con.Open();
                int rowCount = cmd.ExecuteNonQuery();
                if (rowCount > 0)
                {
                    MessageBox.Show("Semester added successfully!", "Success", MessageBoxButtons.OK);
                   
                }
                else
                {
                    MessageBox.Show("Semester Insertion failed!", "Failure", MessageBoxButtons.OK);
                    
                }
                con.Close();
                LoadComboSemester();

            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image File(*.jpg; *.png; *.jpeg; *.gif; *.bmp)| *.jpg; *.png; *.jpeg; *.gif; *.bmp|all files|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                imgName = openFileDialog1.SafeFileName;
                pbStudent.Image = new Bitmap(openFileDialog1.FileName);
                filePath = openFileDialog1.FileName;
            }



        }

        

        private void btnSubmit_Click(object sender, EventArgs e)
        
        {
            string gender = "";
            if (radioBtnMale.Checked == true)
            {
                gender = radioBtnMale.Text;
            }
            else
            {
                gender = radioBtnFemale.Text;
            }

            Registration objReg = new Registration();
           objReg.AdmitFee=Convert.ToDecimal(txtAdmitFee.Text);
            objReg.SemesterId = Convert.ToInt16(cmbSemester.SelectedValue);
            objReg.StudentName= txtStudentName.Text;
            objReg.FathersName=txtFatherName.Text;
           objReg.ContactNo = txtContactNo.Text;
            objReg.DateOfBirth = Convert.ToDateTime(dtpDateOfBirth.Text);
            objReg.Gender = gender;
            objReg.EmployeeId = empId;
            objReg.RegistrationNo = Convert.ToInt16(txtRegNo.Text);
            objReg.AdmitDate = Convert.ToDateTime(dtpAdmitDate.Text);
            objReg.DepartmentId = Convert.ToInt16(cmbDepartment.SelectedValue);
            objReg.ImgPath = folderPath + Path.GetFileName(openFileDialog1.FileName);
            string sqlQuery = "Insert INTO Registration_t VALUES (@RegistrationNo,@StudentName,@FathersName,@DateOfBirth,@Gender,@AdmitFee,@AdmitDate,@ContactNo,@ImgPath,@EmployeeId,@DepartmentId,@SemesterId)";
            SqlConnection con = new SqlConnection(conStr);
            SqlCommand cmd = new SqlCommand(sqlQuery, con);
            if (filePath == "")
            {
                cmd.Parameters.AddWithValue("@ImagePath", "No Image Found");
            }
            else
            {
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@ImagePath", objReg.ImgPath);
                try
                {
                    File.Copy(filePath, Path.Combine(folderPath, Path.GetFileName(filePath)), true);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
                cmd.Parameters.AddWithValue("@RegistrationNo", objReg.RegistrationNo);
               
                cmd.Parameters.AddWithValue("@StudentName", objReg.StudentName);
                cmd.Parameters.AddWithValue("@FathersName", objReg.FathersName);
                cmd.Parameters.AddWithValue("@DateOfBirth", objReg.DateOfBirth);
                cmd.Parameters.AddWithValue("@Gender", objReg.Gender);
                cmd.Parameters.AddWithValue("@AdmitFee", objReg.AdmitFee);
                cmd.Parameters.AddWithValue("@AdmitDate", objReg.AdmitDate);
                
                

                cmd.Parameters.AddWithValue("@ContactNo", objReg.ContactNo);
                cmd.Parameters.AddWithValue("@ImgPath", objReg.ImgPath);
                cmd.Parameters.AddWithValue("@EmployeeId", objReg.EmployeeId);
                cmd.Parameters.AddWithValue("@DepartmentId", objReg.DepartmentId);
                cmd.Parameters.AddWithValue("@SemesterId", objReg.SemesterId);
                con.Open();
                int rowCount = cmd.ExecuteNonQuery();
                if (rowCount > 0)
                {
                    MessageBox.Show("Admitted successfully!", "Success", MessageBoxButtons.OK);
                    LoadGridView();

                }
                else
                {
                    MessageBox.Show("Admission failed!", "Failure", MessageBoxButtons.OK);
                    
                }
                con.Close();
                LoadGridView();
               
            


        }

        private void dgvAdmission_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lblStudentId.Text))
            {
                Registration objPurchase = new Registration();
                objPurchase.StudentId = Convert.ToInt16(lblStudentId.Text);
                string sqlQuery = "DELETE FROM  Registration_t WHERE StudentId=@StudentId";
                SqlConnection con = new SqlConnection(conStr);
                SqlCommand cmd = new SqlCommand(sqlQuery, con);
                cmd.Parameters.AddWithValue("@StudentId", objPurchase.StudentId);
                con.Open();
                int rowCount = cmd.ExecuteNonQuery();
                if (rowCount > 0)
                {
                    lblRegistrationNo.Text = "";
                    MessageBox.Show("Deleted successfully!", "Success", MessageBoxButtons.OK);
                    Clear();
                }
                else
                {
                    MessageBox.Show("Deletion failed!", "Failure", MessageBoxButtons.OK);
                    Clear();
                }
                con.Close();
                LoadGridView();
                Clear();
            }
            else
            {
                MessageBox.Show("Please select Student Id!", "Warning", MessageBoxButtons.OK);
            }
        }

        private void dgvAdmission_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int cellId = e.RowIndex;
            try
            {
                DataGridViewRow row = dgvAdmission.Rows[cellId];
                lblStudentId.Text = row.Cells[0].Value.ToString();
                txtRegNo.Text = row.Cells[1].Value.ToString();
                txtStudentName.Text = row.Cells[2].ToString();
                txtFatherName.Text = row.Cells[3].ToString();
                dtpDateOfBirth.Text = row.Cells[4].Value.ToString();

                cmbDepartment.Text = row.Cells[6].Value.ToString();
                cmbSemester.Text = row.Cells[7].Value.ToString();
                decimal AdmitFee = Convert.ToDecimal(row.Cells[8].Value.ToString());

                dtpAdmitDate.Text = row.Cells[9].Value.ToString();
                txtContactNo.Text = row.Cells[10].Value.ToString();
                lblEmployeeName.Text = row.Cells[11].Value.ToString();


                //int quantity = Convert.ToInt32(row.Cells[3].Value.ToString());
                // decimal unitPrice = totalPrice / quantity;
                // txtAdmitFee.Text = AdmitFee.ToString();
                
                if (imagePathFromData == "No Image")
                {
                    pbStudent.Image = Resources.noimage;
                }
                byte[] data = (byte[])row.Cells[13].Value;
                MemoryStream stream = new MemoryStream(data);
                pbStudent.Image = Image.FromStream(stream);
                imagePathFromData = row.Cells[12].Value.ToString();
                if (row.Cells[5].Value.ToString() == "Male")
                {
                    radioBtnMale.Checked = true;
                }
                else if (row.Cells[5].Value.ToString() == "Female")
                {
                    radioBtnFemale.Checked = true;
                }


            }
            catch (Exception)
            {

                throw;
            }



        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string gender = "";
            if (radioBtnMale.Checked == true)
            {
                gender = radioBtnMale.Text;
            }
            else
            {
                gender = radioBtnFemale.Text;
            }

            Registration objReg = new Registration();
            objReg.AdmitFee = Convert.ToDecimal(txtAdmitFee.Text);
            objReg.SemesterId = Convert.ToInt16(cmbSemester.SelectedValue);
            objReg.StudentName = txtStudentName.Text;
            objReg.FathersName = txtFatherName.Text;
            objReg.ContactNo = txtContactNo.Text;
            objReg.DateOfBirth = Convert.ToDateTime(dtpDateOfBirth.Text);
            objReg.Gender = gender;
            objReg.EmployeeId = empId;
            objReg.RegistrationNo = Convert.ToInt16(txtRegNo.Text);
            objReg.AdmitDate = Convert.ToDateTime(dtpAdmitDate.Text);
            objReg.DepartmentId = Convert.ToInt16(cmbDepartment.SelectedValue);
            objReg.ImgPath = folderPath + Path.GetFileName(openFileDialog1.FileName);
            string sqlQuery = "UPDATE Registration_t SET RegistrationNo=@RegistrationNo,StudentName=@StudentName,FathersName=@FathersName,DateOfBirth=@DateOfBirth,Gender=@Gender, AdmitFee=@AdmitFee,  AdmitDate = @AdmitDate,ContactNo=@ContactNo ,ImgPath=@ImgPath, EmployeeId=@EmployeeId,DepartmentId=@DepartmentId,SemesterId=@SemesterId, WHERE StudentId=@StudentId";
            SqlConnection con = new SqlConnection(conStr);
            SqlCommand cmd = new SqlCommand(sqlQuery, con);
            if (filePath == "")
            {
                cmd.Parameters.AddWithValue("@ImagePath", "No Image Found");
            }
            else
            {
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@ImagePath", objReg.ImgPath);
                try
                {
                    File.Copy(filePath, Path.Combine(folderPath, Path.GetFileName(filePath)), true);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            cmd.Parameters.AddWithValue("@StudentId", objReg.StudentId);
            cmd.Parameters.AddWithValue("@RegistrationNo", objReg.RegistrationNo);

            cmd.Parameters.AddWithValue("@StudentName", objReg.StudentName);
            cmd.Parameters.AddWithValue("@FathersName", objReg.FathersName);
            cmd.Parameters.AddWithValue("@DateOfBirth", objReg.DateOfBirth);
            cmd.Parameters.AddWithValue("@Gender", objReg.Gender);
            cmd.Parameters.AddWithValue("@AdmitFee", objReg.AdmitFee);
            cmd.Parameters.AddWithValue("@AdmitDate", objReg.AdmitDate);



            cmd.Parameters.AddWithValue("@ContactNo", objReg.ContactNo);
            cmd.Parameters.AddWithValue("@ImgPath", objReg.ImgPath);
            cmd.Parameters.AddWithValue("@EmployeeId", objReg.EmployeeId);
            cmd.Parameters.AddWithValue("@DepartmentId", objReg.DepartmentId);
            cmd.Parameters.AddWithValue("@SemesterId", objReg.SemesterId);
            con.Open();
            int rowCount = cmd.ExecuteNonQuery();
            if (rowCount > 0)
            {
                MessageBox.Show("Update successfully!", "Success", MessageBoxButtons.OK);
                LoadGridView();

            }
            else
            {
                MessageBox.Show("Update failed!", "Failure", MessageBoxButtons.OK);

            }
            con.Close();
            LoadGridView();


        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }


}
