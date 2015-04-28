use Register;
GO

CREATE TABLE dbo.Users
	(UserId int PRIMARY KEY IDENTITY NOT NULL,
	 UserName varchar(50) NOT NULL,
	 FirstName varchar(10) NOT NULL,
	 LastName varchar(20) NOT NULL,
	 CityAddress varchar(40) NULL,
	 ContactNumber varchar(15) NULL)
GO