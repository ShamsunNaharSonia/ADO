CREATE TABLE [dbo].[Employee_t] (
    [EmployeeId]   INT          IDENTITY (200, 1) NOT NULL,
    [EmployeeName] VARCHAR (30) NOT NULL,
	
    [Password] INT NOT NULL, 
    PRIMARY KEY CLUSTERED ([EmployeeId] ASC)
);

