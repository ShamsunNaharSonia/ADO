CREATE  table logIN_t(
    userId      int primary key      IDENTITY (1, 1) NOT NULL,
    fullName       VARCHAR (30) NOT NULL,
    contact     VARCHAR (30) NOT NULL,
    email        VARCHAR (30) NOT NULL,
    userName     VARCHAR (50) NOT NULL,
    userPassword VARCHAR (10) NOT NULL
   
)