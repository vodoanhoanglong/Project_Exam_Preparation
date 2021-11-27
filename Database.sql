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
	SubName nvarchar(50)
);

CREATE TABLE QUESTIONS(
	QuestionID int identity(1,1) primary key,
	Contents nvarchar(max),
	SubjectID int foreign key references SUBJECTS(SubjectID)
);
	
CREATE TABLE EXAMQUESTIONS(
	ExamQuestionID INT identity(1,1),
	Quantity int not null,
	ExecutionTime varchar(8) not null,
	SubjectID int,

	primary key(ExamQuestionID),
	foreign key(SubjectID) references SUBJECTS(SubjectID)
);



CREATE TABLE LISTQUESTION(
	ExamQuestionID INT,
	QuestionID INT,	
	CreateDate DateTime Default GETDATE(),

	PRIMARY KEY(ExamQuestionID,QuestionID),
	foreign key(QuestionID) references QUESTIONS(QuestionID),
	foreign key(ExamQuestionID) references EXAMQUESTIONS(ExamQuestionID)
);



CREATE TABLE EXAMRESULTS(
	ExamResultID varchar(14),
	UserID varchar(10),
	ExamQuestionID INT,
	ExamDate datetime default GetDate(),
	Points float not null,
	TimeComplete varchar(8) not null,
	Primary key(ExamResultID, UserID, ExamQuestionID),
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


Insert into USERS VALUES ('6051071067', '1','Võ Đoàn Hoàng Long', '3/3/2001', 1, '0932765080')

Insert into SUBJECTS(SubName) VALUES(N'Lập trình hướng đối tượng'),
									(N'Cấu trúc dữ liệu giải thuật'),
									(N'Phân tích thiết kế hệ thống'),
									(N'Thiết kế cơ sở dữ liệu'),
									(N'Lập trình trực quan')

SET IDENTITY_INSERT [dbo].[SUBJECTS] ON 
GO
INSERT [dbo].[SUBJECTS] ([SubjectID], [SubName]) VALUES (1, N'Lập trình hướng đối tượng')
GO
INSERT [dbo].[SUBJECTS] ([SubjectID], [SubName]) VALUES (2, N'Cấu trúc dữ liệu giải thuật')
GO
INSERT [dbo].[SUBJECTS] ([SubjectID], [SubName]) VALUES (3, N'Phân tích thiết kế hệ thống')
GO
INSERT [dbo].[SUBJECTS] ([SubjectID], [SubName]) VALUES (4, N'Thiết kế cơ sở dữ liệu')
GO
INSERT [dbo].[SUBJECTS] ([SubjectID], [SubName]) VALUES (5, N'Lập trình trực quan')
GO
SET IDENTITY_INSERT [dbo].[SUBJECTS] OFF
GO
SET IDENTITY_INSERT [dbo].[QUESTIONS] ON 
GO
INSERT [dbo].[QUESTIONS] ([QuestionID], [Contents], [SubjectID]) VALUES (1, N'OOP là gì', 1)
GO
INSERT [dbo].[QUESTIONS] ([QuestionID], [Contents], [SubjectID]) VALUES (2, N'Trong C++ có bao nhiêu hàm main()', 1)
GO
INSERT [dbo].[QUESTIONS] ([QuestionID], [Contents], [SubjectID]) VALUES (3, N'Lệnh cout trong C++ đi kèm với cặp dấu nào', 1)
GO
INSERT [dbo].[QUESTIONS] ([QuestionID], [Contents], [SubjectID]) VALUES (4, N'Chú thích 1 dòng lệnh t dùng dấu nào', 1)
GO
INSERT [dbo].[QUESTIONS] ([QuestionID], [Contents], [SubjectID]) VALUES (5, N'Kiểu số nguyên là kiểu dữ liệu nào', 1)
GO
INSERT [dbo].[QUESTIONS] ([QuestionID], [Contents], [SubjectID]) VALUES (6, N'C++ là gì', 1)
GO
SET IDENTITY_INSERT [dbo].[QUESTIONS] OFF
GO
SET IDENTITY_INSERT [dbo].[ANSWERS] ON 
GO
INSERT [dbo].[ANSWERS] ([AnswersID], [AnswersContent], [isCorrect], [QuestionID]) VALUES (1, N'ai biết', 0, 1)
GO
INSERT [dbo].[ANSWERS] ([AnswersID], [AnswersContent], [isCorrect], [QuestionID]) VALUES (2, N'i dont know', 0, 1)
GO
INSERT [dbo].[ANSWERS] ([AnswersID], [AnswersContent], [isCorrect], [QuestionID]) VALUES (3, N'Hướng đối tượng', 1, 1)
GO
INSERT [dbo].[ANSWERS] ([AnswersID], [AnswersContent], [isCorrect], [QuestionID]) VALUES (4, N'Framework', 0, 1)
GO
INSERT [dbo].[ANSWERS] ([AnswersID], [AnswersContent], [isCorrect], [QuestionID]) VALUES (5, N'1', 1, 2)
GO
INSERT [dbo].[ANSWERS] ([AnswersID], [AnswersContent], [isCorrect], [QuestionID]) VALUES (6, N'2', 0, 2)
GO
INSERT [dbo].[ANSWERS] ([AnswersID], [AnswersContent], [isCorrect], [QuestionID]) VALUES (7, N'3', 0, 2)
GO
INSERT [dbo].[ANSWERS] ([AnswersID], [AnswersContent], [isCorrect], [QuestionID]) VALUES (8, N'4', 0, 2)
GO
INSERT [dbo].[ANSWERS] ([AnswersID], [AnswersContent], [isCorrect], [QuestionID]) VALUES (9, N'>>', 0, 3)
GO
INSERT [dbo].[ANSWERS] ([AnswersID], [AnswersContent], [isCorrect], [QuestionID]) VALUES (10, N'\\', 0, 3)
GO
INSERT [dbo].[ANSWERS] ([AnswersID], [AnswersContent], [isCorrect], [QuestionID]) VALUES (11, N'||', 0, 3)
GO
INSERT [dbo].[ANSWERS] ([AnswersID], [AnswersContent], [isCorrect], [QuestionID]) VALUES (12, N'<<', 1, 3)
GO
INSERT [dbo].[ANSWERS] ([AnswersID], [AnswersContent], [isCorrect], [QuestionID]) VALUES (13, N'/* và */', 0, 4)
GO
INSERT [dbo].[ANSWERS] ([AnswersID], [AnswersContent], [isCorrect], [QuestionID]) VALUES (14, N'<<', 0, 4)
GO
INSERT [dbo].[ANSWERS] ([AnswersID], [AnswersContent], [isCorrect], [QuestionID]) VALUES (15, N'//', 1, 4)
GO
INSERT [dbo].[ANSWERS] ([AnswersID], [AnswersContent], [isCorrect], [QuestionID]) VALUES (16, N'??', 0, 4)
GO
INSERT [dbo].[ANSWERS] ([AnswersID], [AnswersContent], [isCorrect], [QuestionID]) VALUES (17, N'string', 0, 5)
GO
INSERT [dbo].[ANSWERS] ([AnswersID], [AnswersContent], [isCorrect], [QuestionID]) VALUES (18, N'boolean', 0, 5)
GO
INSERT [dbo].[ANSWERS] ([AnswersID], [AnswersContent], [isCorrect], [QuestionID]) VALUES (19, N'int', 1, 5)
GO
INSERT [dbo].[ANSWERS] ([AnswersID], [AnswersContent], [isCorrect], [QuestionID]) VALUES (20, N'char', 0, 5)
GO
INSERT [dbo].[ANSWERS] ([AnswersID], [AnswersContent], [isCorrect], [QuestionID]) VALUES (21, N'Java', 0, 6)
GO
INSERT [dbo].[ANSWERS] ([AnswersID], [AnswersContent], [isCorrect], [QuestionID]) VALUES (22, N'C#', 0, 6)
GO
INSERT [dbo].[ANSWERS] ([AnswersID], [AnswersContent], [isCorrect], [QuestionID]) VALUES (23, N'OOP', 1, 6)
GO
INSERT [dbo].[ANSWERS] ([AnswersID], [AnswersContent], [isCorrect], [QuestionID]) VALUES (24, N'POP', 0, 6)
GO
SET IDENTITY_INSERT [dbo].[ANSWERS] OFF
GO


