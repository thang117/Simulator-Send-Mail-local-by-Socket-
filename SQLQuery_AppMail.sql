create database AppMail
go

use AppMail
go

--Account
--Mail

 CREATE TABLE Account
 (
	UserName NVARCHAR(100) PRIMARY KEY,
	PassWord NVARCHAR(1000) NOT NULL DEFAULT 0,
	FirstName NVARCHAR(100) NOT NULL DEFAULT N'FirstNameUser',
	LastName NVARCHAR(100) NOT NULL DEFAULT N'LastNameUser',	
	MailAddress NVARCHAR(1000) NOT NULL DEFAULT 0,

	Type INT NOT NULL DEFAULT 0 -- 1:admin || 0: staff


)
 GO

 
 INSERT INTO Account (UserName,PassWord,FirstName,LastName,Type) VALUES('Admin1','1962026656160185351301320480154111117132155','FirstNameAdmin','LastNameAdmin','1')
 GO
 INSERT INTO Account (UserName,PassWord,FirstName,LastName,Type) VALUES('User1','1962026656160185351301320480154111117132155','FirstNameUser','LastNameUser','0')
 GO



CREATE TABLE Mail
(
	id INT IDENTITY PRIMARY KEY,
	AddressSend NVARCHAR(1000) not null,
	SubjectMail NVARCHAR(1000) not null,
	ContentMail NVARCHAR(Max) not null,
	
	UserNameAccount NVARCHAR(100) not null,
	status int not null default 0 --0 chưa đọc , 1: đã đọc

	FOREIGN KEY (UserNameAccount) REFERENCES dbo.Account(UserName)
)
GO

CREATE TABLE MailReceived
(
	id INT IDENTITY PRIMARY KEY,
	TimeReceive NVarchar(100) not null default GetDate(),
	idMail int not null

	FOREIGN KEY (idMail) REFERENCES dbo.Mail(id)
)
go

CREATE TABLE MailSent
(
	id INT IDENTITY PRIMARY KEY,
	TimeSend NVarchar(100) not null default GetDate(),
	idMail int not null

	FOREIGN KEY (idMail) REFERENCES dbo.Mail(id)
)
go

-----------------------------------

-- Chống SQL injection + Login
 CREATE PROC USP_Login
 @userName nvarchar(100), @passWord nvarchar(1000)
 AS
 BEGIN
	SELECT * FROM dbo.Account WHERE UserName = @userName AND PassWord = @passWord
 END
 GO

 --SELECT TOP 1 *  FROM dbo.Account ORDER BY UserName DESC

 --SELECT TOP 1 id  FROM dbo.Mail ORDER BY id DESC
 --SELECT * FROM dbo.Mail WHERE id=(SELECT max(id) FROM Mail);
 --SELECT * FROM dbo.Mail as M , dbo.MailReceived as MR WHERE UserNameAccount = N'user1' AND M.id = MR.idMail

 --Select TimeReceive From dbo.MailReceived Where idMail = 8