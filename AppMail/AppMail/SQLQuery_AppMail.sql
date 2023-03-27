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

 INSERT INTO Account (UserName,PassWord,FirstName,LastName,Type) VALUES('Admin','1','FirstNameAdmin','LastNameAdmin','1')
 GO
 INSERT INTO Account (UserName,PassWord,FirstName,LastName,Type) VALUES('User','1','FirstNameUser','LastNameUser','0')
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
	TimeReceive DateTime not null default GetDate(),
	UserNameAccount NVARCHAR(100) not null,

	FOREIGN KEY (UserNameAccount) REFERENCES dbo.Account(UserName)
)
GO

--
create procedure GetUserCredentials
(
	@isusername BIT OUTPUT,
	@ispassword BIT OUTPUT,
	@UserName NVARCHAR(50),
	@Password  NVARCHAR(1000)
)
AS
BEGIN
SET @isusername = 0
SET @ispassword = 0
IF EXISTS(SELECT * FROM Account WHERE UserName = @UserName and PassWord = @Password)
begin
set @isusername = 1
set @ispassword = 1
end
ELSE
	begin
		if exists(select * from Account where UserName = @UserName )
		begin
		set @isusername = 1
		end
		end

END
go

-- Chống SQL injection
 CREATE PROC USP_Login
 @userName nvarchar(100), @passWord nvarchar(1000)
 AS
 BEGIN
	SELECT * FROM dbo.Account WHERE UserName = @userName AND PassWord = @passWord
 END
 GO


