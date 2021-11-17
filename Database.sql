CREATE DATABASE EPS
GO
use EPS
GO

CREATE TABLE USERS(
	UserID varchar(10) primary key,
	[Password] nvarchar(20) not null,
	FullName nvarchar(50) not null,
	BirthDay Date not null,
	Sex bit not null,
	Phone varchar(13) not null,
);

CREATE TABLE SUBJECTS(
	SubjectID int identity(1,1) primary key,
	SubName nvarchar(50),
	Descriptions varchar(max)
);

CREATE TABLE QUESTIONS(
	QuestionID int identity(1,1) primary key,
	Contents nvarchar(max),
	SubjectID int foreign key references SUBJECTS(SubjectID)
);
	
CREATE TABLE EXAMQUESTIONS(
	ExamQuestionID int identity(1,1) primary key,
	Quantity int not null,
	ExecutionTime varchar not null,
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
	UserID varchar(10),
	ExaminationID int,
	DateCreate datetime default GetDate(),
	Primary key(UserID, ExaminationID),
	foreign key(UserID) references USERS(UserID),
	foreign key(ExaminationID) references EXAMINATIONS(ExaminationID)
);


CREATE TABLE EXAMRESULTS(
	UserID varchar(10),
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
	AnswersContent nvarchar(max) not null,
	isCorrect bit not null,
	QuestionID int,
	foreign key(QuestionID) references QUESTIONS(QuestionID),
);


CREATE TABLE REPORTS(
	ReportID int identity(1,1) primary key,
	Contents varchar(max) not null,
	CreateAt datetime default GetDate()
);
GO

Insert into USERS VALUES ('6051071067', '1','Võ Đoàn Hoàng Long', '3/3/2001', 1, '0932765080')

Insert into SUBJECTS(SubName) VALUES(N'Lập trình hướng đối tượng'),
									(N'Cấu trúc dữ liệu giải thuật'),
									(N'Phân tích thiết kế hệ thống'),
									(N'Thiết kế cơ sở dữ liệu'),
									(N'Lập trình trực quan')



