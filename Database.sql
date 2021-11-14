CREATE DATABASE BTL;
GO
use BTL
GO

CREATE TABLE  ACCOUNTS(
	AccountID int identity(1,1) primary key,
	LoginName varchar(30)	 unique not null,
	Passwords varchar(30) not null,
	Roles varchar(20) default 'Standard'
);

CREATE TABLE USERS(
	UserID int identity(1,1) primary key,
	FullName nvarchar(50) not null,
	Age int not null,
	Emails varchar(50) not null,
	Schools varchar(50) not null,
	Phone varchar(13) not null,
	AccountID int,
	foreign key(AccountID) references ACCOUNTS(AccountID)
);

CREATE TABLE SUBJECTS(
	SubjectID int identity(1,1) primary key,
	SubName varchar(20),
	Descriptions varchar(max)
);

CREATE TABLE QUESTIONS(
	QuestionID int identity(1,1) primary key,
	Contents varchar(max),
	Images varchar(max),
	Levels int not null,
	Forms bit,
	SubjectID int foreign key references SUBJECTS(SubjectID)
);

CREATE TABLE EXAMQUESTIONS(
	ExamQuestionID int identity(1,1) primary key,
	HardRate int,
	EasyRate int,
	Quantity int not null,
	ExecutionTime datetime not null,
	QuestionID int,
	SubjectID int,
	foreign key(QuestionID) references QUESTIONS(QuestionID),
	foreign key(SubjectID) references SUBJECTS(SubjectID)
);

CREATE TABLE EXAMINATIONS(
	ExaminationID int identity(1,1) primary key,
	ExaminationName Nvarchar(50) not null,
	TimeStart datetime not null,
	TimeEnd datetime not null,
	PINCode Varchar(50) not null,
	ExamQuestionID int,
	foreign key(ExamQuestionID) references EXAMQUESTIONS(ExamQuestionID)
);

CREATE TABLE CADIDATELIST(
	UserID int,
	ExaminationID int,
	DateCreate datetime default GetDate(),
	Primary key(UserID, ExaminationID),
	foreign key(UserID) references USERS(UserID),
	foreign key(ExaminationID) references EXAMINATIONS(ExaminationID)
);


CREATE TABLE EXAMRESULTS(
	UserID int,
	ExamQuestionID int,
	ExamDate datetime default GetDate(),
	Points float not null,
	TimeComplete time not null,
	Primary key(UserID, ExamQuestionID),
	foreign key(UserID) references USERS(UserID),
	foreign key(ExamQuestionID) references EXAMQUESTIONS(ExamQuestionID)
);

CREATE TABLE ANSWERS(
	AnswersID int identity(1,1) primary key,
	AnswersContent varchar(50) not null,
	isCorrect bit not null,
	QuestionID int,
	foreign key(QuestionID) references QUESTIONS(QuestionID),
);


CREATE TABLE REPORTS(
	ReportID int identity(1,1) primary key,
	Contents varchar(max) not null,
	CreateAt datetime default GetDate()
);

-- TAO LOGIN HOANG LONG
CREATE LOGIN HoangLong
WITH PASSWORD = 'hoanglong' MUST_CHANGE,
CHECK_EXPIRATION = ON

CREATE LOGIN ThanhHoa
WITH PASSWORD = 'thanhhoa' MUST_CHANGE,
CHECK_EXPIRATION = ON

CREATE LOGIN PhuocNhat
WITH PASSWORD = 'phuocnhat' MUST_CHANGE,
CHECK_EXPIRATION = ON

CREATE LOGIN VuTrieu
WITH PASSWORD = 'vutrieu' MUST_CHANGE,
CHECK_EXPIRATION = ON

CREATE LOGIN GiaMinh
WITH PASSWORD = 'giaminh' MUST_CHANGE,
CHECK_EXPIRATION = ON

-- TAO USER
CREATE USER HoangLong -- neu ten user va login giong nhau
CREATE USER ThanhHoa 
CREATE USER PhuocNhat 
CREATE USER VuTrieu
CREATE USER GiaMinhhh FOR LOGIN GiaMinh -- neu ten user va login khac nhau

-- CAP QUYEN ALL CHO USER HoangLong tren Table Users va co the chuyen tiep quyen nay
GRANT ALL ON USERS TO HoangLong WITH GRANT OPTION
-- CAP QUYEN TRUY VAN DATA chi cot FullName va Age CHO USER ThanhHoa tren Table Users
GRANT SELECT (FullName, Age) ON USERS TO ThanhHoa
-- CAP QUYEN TRUY VAN, INSERT, UPDATE cho User PhuocNhat tren Table Users va co the chuyen tiep cac quyen nay
GRANT SELECT, INSERT, UPDATE ON USERS TO PhuocNhat WITH GRANT OPTION

-- THU HOI QUYEN CUA USER PhuocNhat va cac User duoc PhuocNhat cap quyen
REVOKE SELECT, INSERT, UPDATE ON USERS FROM PhuocNhat CASCADE

-- TAO QUYEN THEM, SUA XOA CHO NHOM NGUOI QUAN LY
CREATE ROLE [Manager]
GO

--Ngoai ra, con co quyen sao luu vao khoi phuc du lieu.
alter role db_backupoperator ADD MEMBER [Manager]
alter role db_datawriter ADD MEMBER [Manager]
alter role db_datareader ADD MEMBER [Manager]
GO

-- TAO QUYEN DOC DU LIEU CHO NHOM NGUOI DUNG
CREATE ROLE [Standard]
GO
alter role db_datareader ADD MEMBER [Standard]
GO

-- 1. TAO PROC THEM USER VÀO CÁC NHÓM QUYỀN
CREATE PROC sp_SetAccountRole(@LoginName varchar(30), @Passwords varchar(30), @Roles varchar(20)=null)
AS
	declare @sql nvarchar(max)
	set @sql = 'use BTL' + ';' +
           'create login ' + @LoginName + 
               ' with password = ''' + @Passwords + '''; ' +
           'create user ' + @LoginName + ';'
exec (@sql)
if @Roles = 'Manager'
	exec sp_addrolemember 'Manager', @LoginName
else exec sp_addrolemember 'Standard', @LoginName
GO

-- 2. Kiểm tra tên người thi, số điểm, ngày thi

CREATE PROC sp_KTThongTinThi(@UserID int, @ExamQuestionID int)
AS
DECLARE @MaND int;
DECLARE @MaDe int;
DECLARE @HoTen nvarchar(50);
DECLARE @SoDiem float;
DECLARE @NgayThi datetime;
SELECT @MaND = USERS.UserID, @MaDe = EXAMRESULTS.ExamQuestionID, @HoTen = USERS.FullName, @SoDiem = EXAMRESULTS.Points, @NgayThi = EXAMRESULTS.ExamDate
FROM USERS, EXAMRESULTS WHERE @UserID = USERS.UserID AND @ExamQuestionID = EXAMRESULTS.ExamQuestionID AND USERS.UserID = EXAMRESULTS.UserID
Print 'Ma nguoi dung: '+ str(@MaND)
Print 'Ma de: '+ str(@MaDe)
PRINT 'Ho ten: '+ @HoTen
PRINT 'Diem: '+ str(@SoDiem)
PRINT 'Ngay Thi: '+ Convert(varchar(20),@NgayThi,100)
GO
-- 3. Kiểm tra số người tham gia 1 kỳ thi

CREATE PROC sp_SoNguoi(@ExaminationID int)
AS
DECLARE @soNguoiThamGia int;
SELECT @soNguoiThamGia = COUNT(UserID) FROM CADIDATELIST WHERE 
ExaminationID = @ExaminationID
Print 'So nguoi tham gia ky thi ' + str(@ExaminationID) + ' la:' + str(@soNguoiThamGia) 
GO
-- 4. Kiểm tra số lượng câu hỏi cho từng cấp độ

CREATE PROC sp_SLCauHoi(@Levels int)
AS
DECLARE @soLuongCauHoi int;
SELECT @soLuongCauHoi = COUNT(QuestionID) FROM QUESTIONS WHERE 
Levels = @Levels
Print 'So luong cau hoi cap do ' + str(@Levels) + ' la:' + str(@soLuongCauHoi)
GO
-- 5. Xếp loại năng lực dựa vào điểm thi

CREATE PROC sp_XepLoai(@ExamQuestionID int)
AS
SELECT USERS.UserID, EXAMRESULTS.ExamQuestionID, USERS.FullName, EXAMRESULTS.ExamDate, EXAMRESULTS.Points,
XepLoai = CASE
WHEN Points >=0 and Points <=4 THEN 'Yeu'
WHEN Points >=5 and Points <=6.5 THEN 'Trung Binh'
ELSE 'Gioi'
END
FROM USERS, EXAMRESULTS WHERE @ExamQuestionID = EXAMRESULTS.ExamQuestionID AND USERS.UserID = EXAMRESULTS.UserID
GO
-- 6. Kiếm tra thí sinh rớt thi

CREATE PROC sp_KiemTraRot(@UserID int, @ExamQuestionID int)
AS
DECLARE @XepLoai float;
DECLARE @MaND int;
DECLARE @MaDe int;
DECLARE @HoTen nvarchar(50);
DECLARE @NgayThi datetime;
SELECT @MaND = USERS.UserID, @MaDe = EXAMRESULTS.ExamQuestionID, @HoTen = USERS.FullName, @NgayThi = EXAMRESULTS.ExamDate, @XepLoai = Points
FROM USERS, EXAMRESULTS WHERE @UserID = USERS.UserID AND @ExamQuestionID = EXAMRESULTS.ExamQuestionID AND USERS.UserID = EXAMRESULTS.UserID
IF @XepLoai >=5 BEGIN
Print 'Ma nguoi dung: '+ str(@MaND)
Print 'Ma de: '+ str(@MaDe)
PRINT 'Ho ten: '+ @HoTen
PRINT 'Diem: '+ str(@XepLoai)
PRINT 'Ngay Thi: '+ Convert(varchar(20),@NgayThi,100)
PRINT 'Xep loai: Dat'
END
ELSE BEGIN
Print 'Ma nguoi dung: '+ str(@MaND)
Print 'Ma de: '+ str(@MaDe)
PRINT 'Ho ten: '+ @HoTen
PRINT 'Diem: '+ str(@XepLoai)
PRINT 'Ngay Thi: '+ Convert(varchar(20),@NgayThi,100)
PRINT 'Xep loai: Khong dat'
END
GO
-- 7. Cập nhật câu hỏi

CREATE PROC sp_CapNhatCauHoi(@QuestionID int, @Contents varchar(MAX), @Images varchar(MAX), @Levels int, @Forms bit, @SubjectID int)
AS
UPDATE QUESTIONS SET Contents = @Contents, Images = @Images, Levels = @Levels,  Forms = @Forms, SubjectID = @SubjectID
WHERE QuestionID = @QuestionID
Print 'Cap nhat thanh cong'
GO
-- 8. Thêm câu hỏi mới

CREATE PROC sp_ThemCauHoi(@Contents varchar(MAX), @Images varchar(MAX), @Levels int, @Forms bit, @SubjectID int)
AS
INSERT INTO QUESTIONS(Contents, Images, Levels, Forms, SubjectID)
VALUES (@Contents, @Images, @Levels, @Forms, @SubjectID)
Print 'Them thanh cong' 
GO
-- 9. Xóa câu hỏi

CREATE PROC sp_XoaCauHoi(@QuestionID int)
AS
DELETE FROM QUESTIONS
WHERE @QuestionID = QuestionID
Print 'Xoa thanh cong'
GO
-- 10. Cho biết họ tên các bạn sinh viên thuộc trường nào đó

CREATE PROC sp_KTTruong(@UserID int)
AS
DECLARE @MaND int;
DECLARE @HoTen nvarchar(50);
DECLARE @Tuoi int;
DECLARE @Truong varchar(50);
SELECT @MaND = UserID, @HoTen = FullName, @Tuoi = Age, @Truong = Schools
FROM USERS WHERE @UserID = UserID
Print 'Ma nguoi dung: '+ str(@MaND)
PRINT 'Ho ten: '+ @HoTen
PRINT 'Tuoi: '+ str(@Tuoi)
PRINT 'Truong: ' + @Truong
GO


-- TẠO TRIGGER ĐỂ KIỂM TRA XEM TÀI KHOẢN THUỘC NHÓM QUYỀN NÀO
CREATE TRIGGER tr_CheckAccount ON ACCOUNTS
FOR INSERT, UPDATE
AS
	DECLARE @LoginName varchar(30),
			@Passwords varchar(30)
	SELECT @LoginName = I.LoginName, @Passwords = I.Passwords FROM INSERTED I
	IF @LoginName = 'utc2_teacher1' AND @Passwords = 'utc2_welcom'
			EXEC sp_SetAccountRole @LoginName, @Passwords, 'Manager'
	ELSE EXEC sp_SetAccountRole @LoginName, @Passwords
GO

INSERT INTO ACCOUNTS(LoginName,Passwords) VALUES('utc2_teacher1', 'utc2_welcom')
GO

-- TẠO TRIGGER ĐỂ GIỚI HẠN SỐ LƯỢNG THÍ SINH THAM GIA 1 CUỘC THI
CREATE TRIGGER tr_CheckCandidate ON CADIDATELIST
FOR INSERT
AS
	DECLARE @Quantity int
	SELECT @Quantity = COUNT(*) FROM CADIDATELIST C, INSERTED I WHERE I.ExaminationID = C.ExaminationID
	IF @Quantity > 25
		BEGIN
			PRINT 'Candidate not more than 25'
			ROLLBACK TRAN
		END
GO

-- TẠO TRIGGER BẮT BUỘC THỜI GIAN BẮT ĐẦU CỦA CUỘC THI PHẢI BÉ HƠN THỜI GIAN KẾT THÚC
CREATE TRIGGER tr_CheckTimeExamination ON EXAMINATIONS
FOR INSERT, UPDATE 
AS
	DECLARE @TimeStart datetime,
			@TimeEnd   datetime
	SELECT @TimeStart = I.TimeStart, @TimeEnd = I.TimeEnd FROM INSERTED I
	IF @TimeStart > @TimeEnd
		BEGIN
			PRINT 'Time start must be bigger than time end'
			ROLLBACK TRAN
		END
GO

-- TẠO TRIGGER GIỚI HẠN TỐI THIỂU 10 CÂU HỎI TRONG 1 BÀI THI
CREATE TRIGGER tr_LimitQuestion ON EXAMQUESTIONS
FOR INSERT, UPDATE
AS
	DECLARE @QuestionQuantity int
	SELECT @QuestionQuantity = I.Quantity FROM INSERTED I
	IF @QuestionQuantity < 10 
		BEGIN
			PRINT 'The number of questions cannot be less than 10'
			ROLLBACK TRAN
		END
GO

-- TẠO TRIGGER KHÔNG CHO PHÉP XÓA CUỘC THI KHI NÓ ĐANG DIỄN RA
CREATE TRIGGER tr_DeleteNotAllowed ON EXAMINATIONS
FOR DELETE
AS
	DECLARE @TimeStart datetime,
			@TimeEnd   datetime
	SELECT @TimeStart = D.TimeStart, @TimeEnd = D.TimeEnd FROM DELETED D
	IF GETDATE() BETWEEN @TimeStart AND @TimeEnd
		BEGIN
			PRINT 'Contest cannot be deleted while it is in progress'
			ROLLBACK TRAN
		END
GO

-- SAO LƯU CƠ SỞ DỮ LIỆU
-- BACKUP
BACKUP DATABASE [BTL] 
TO DISK = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\Backup\BTL.bak' 
WITH NOFORMAT, NOINIT,  
NAME = N'BTL-Full Database Backup', SKIP, NOREWIND, NOUNLOAD,  STATS = 10
GO
-- RESTORE
USE [master]
RESTORE DATABASE [BTL] 
FROM DISK = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\Backup\BTL.bak' WITH  FILE = 1,  NOUNLOAD,  STATS = 5
GO