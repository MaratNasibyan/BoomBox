USE Kdram
GO
--**************************************HUMAN****************************************--
CREATE TABLE [dbo].[HUMAN](
	[ISN] [int] IDENTITY(1,1) NOT NULL,
	[NAME] [nvarchar](50) NOT NULL,
	[SURNAME] [nvarchar](50) NOT NULL,
	[PATRONYMIC] [nvarchar](50) NOT NULL,
	[DATEOFBIRTH] [date] NOT NULL,
	[IDCARD] [nvarchar](10) NULL,
	[SOCCARD] [nvarchar](10) NULL,
	[DESCRIPT] [nvarchar](50) NULL,
	[CREATIONDATE] [datetime] NOT NULL,	
	[LASTMODIFICATIONDATE] [datetime] NOT NULL,

	CONSTRAINT PK_HUMAN PRIMARY KEY CLUSTERED (ISN)
);
	
	CREATE INDEX NCI_HUMANNAME ON HUMAN(NAME)

INSERT INTO HUMAN([NAME],[SURNAME],[PATRONYMIC],[DATEOFBIRTH],[IDCARD],[SOCCARD],[DESCRIPT],[CREATIONDATE],[LASTMODIFICATIONDATE]) VALUES 
(N'Մարատ',N'Նասիբյան',N'Աշոտի','1990-11-22','123456','123456',N'լավա լոխ','2016-01-06','2016-01-06');

GO
CREATE PROCEDURE GetHumans

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	Select * from HUMAN   
END
GO



--****************************************************************************************--