using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdmissionManagementSystem.Entities
{
   public class Registration
    {
        public int StudentId { get; set; }
        public int RegistrationNo { get; set; }
        public string StudentName { get; set; }
        public string FathersName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public decimal AdmitFee { get; set; }
        public DateTime AdmitDate { get; set; }
        public string ContactNo { get; set; }
       
        public string ImgPath { get; set; }
        public int EmployeeId { get; set;}
        public int DepartmentId { get; set; }
        public int SemesterId { get; set; }
    }
}
