SELECT rg.StudentId,rg.RegistrationNo, rg.DateOfBirth, rg.AdmitDate, rg.AdmitFee,

                dp.DepartmentName, se.SemesterName, em.EmployeeName,rg.ImgPath FROM Registration_t rg JOIN Department_t dp 
               
                ON dp.DepartmentId=rg.DepartmentId JOIN Semester_t se 
                ON rg.SemesterId=se.SemesterId JOIN Employee_t em
                ON rg.EmployeeId=em.EmployeeId