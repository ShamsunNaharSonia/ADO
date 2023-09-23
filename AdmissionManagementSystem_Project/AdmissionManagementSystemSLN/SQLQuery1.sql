create table Employee_t(
EmployeeId int primary key Identity(200,1) not null,
EmployeeName varchar(30) not null
)
go

create table Department_t
(
	DepartmentId int primary key Identity(100,1)  not null,
	DepartmentName varchar(50) not null,
)
go

create table Semester_t
(
	SemesterId int primary key Identity(300,1) not null,
	SemesterName varchar(50) not null,
)
go

create table Registration_t
(
   StudentId int primary key Identity(1001,1)not null,
	RegistrationNo int not null,
	StudentName varchar(50) not null,
	FathersName varchar(50) not null,
	DateOfBirth datetime not null,
	Gender varchar (15) not null,
	
	AdmitFee decimal(18,0) not null,
	AdmitDate datetime not null,
	ContactNo varchar(15) not null,
	ImgPath varchar(200)  null,
	EmployeeId int references Employee_t(EmployeeId) on delete cascade on update cascade,
	DepartmentId int references Department_t(DepartmentId)on delete cascade on update cascade,
	SemesterId int references Semester_t(SemesterId)on delete cascade on update cascade
)
go

