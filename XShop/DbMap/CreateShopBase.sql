USE Shop
GO
--CONSTRAINT FK_USERS_EMPLOYEES FOREIGN KEY (EMPLOYEEISN) REFERENCES EMPLOYEES (ISN)

GO
CREATE TABLE [dbo].[Department](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[CreationDate] [datetime] NOT NULL,	
	[LastModifyDate] [datetime] NOT NULL,

	CONSTRAINT PK_Department PRIMARY KEY CLUSTERED (Id)
);
GO

CREATE INDEX NCI_Department ON Department(Name)
GO
INSERT INTO Department([Name],[CreationDate],[LastModifyDate]) VALUES 
(N'Electronics','2016-01-06','2016-01-06')

GO

CREATE TABLE [dbo].[Product](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Date] [date] NOT NULL,
	[Description] [nvarchar](50) NULL,
	[DepartmentId] [int] Not Null,
	[CreationDate] [datetime] NOT NULL,	
	[LastModifyDate] [datetime] NOT NULL,

	CONSTRAINT PK_Product PRIMARY KEY CLUSTERED (Id),
	CONSTRAINT FK_Product_Department FOREIGN KEY(DepartmentId) REFERENCES [Department](Id)
);
GO
CREATE INDEX NCI_ProductName ON Product(Name)
GO
INSERT INTO Product([Name],[Date],[Description],[DepartmentId],[CreationDate],[LastModifyDate]) VALUES 
(N'TV','1990-11-22',N'asd',1,'2016-01-06','2016-01-06');

GO

ALTER PROCEDURE GetProducts

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	Select * from Product   
END
GO