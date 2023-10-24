--create database prn211
--use prn211
create table [Subject](
	[subjectId] int primary key not null,
	[subjectName] nvarchar (max) not null,
)
insert into [Subject] values
(1, 'PRN'),
(2, 'PRJ'),
(3, 'SWP')

create table Student(
	[studentId] int primary key not null,
	[studentName] nvarchar (max) not null,
)
insert into Student values
(1, 'Maria Anders'),
(2, 'Ana Trujillo'),
(3, 'Antonio Moreno'),
(4, 'Thomas Hardy'),
(5, 'Christina Berglund'),
(6, 'Hanna Moos'),
(7, 'Frederique Citeaux'),
(8, 'Marten Sommer'),
(9, 'Laurence Lebihan'),
(10, 'Elizabeth Lincoln'),
(11, 'Victoria Ashworth'),
(12, 'Patricio Simpson'),
(13, 'Francisco Chang'),
(14, 'Yang Wang'),
(15, 'Pedro Afonso'),
(16, 'Elizabeth Brown'),
(17, 'Sven Ottlieb'),
(18, 'Janine Labrune'),
(19, 'Ann Devono'),
(20, 'Roland Mendel'),
(21, 'Aria Cruz'),
(22, 'Diego Roel'),
(23, 'Martine Rance'),
(24, 'Maria Larsson'),
(25, 'Peter Franken'),
(26, 'Carine Schmitt'),
(27, 'Paolo Accorti'),
(28, 'Lino Rodriguez'),
(29, 'Eduardo Saavedra'),
(30, 'Jose Pedro Freyre')

--drop table StudentSubject
create table StudentSubject(
    [studentId] int,
    [subjectId] int,
    primary key ([studentId], [subjectId]),
    foreign key ([studentId]) references Student([studentId]),
    foreign key ([subjectId]) references [Subject]([subjectId])
)
DECLARE @counter INT
SET @counter = 1

WHILE @counter <= 60
BEGIN
    INSERT INTO StudentSubject ([studentId], [subjectId])
    VALUES (
        (ABS(CHECKSUM(NEWID())) % 30) + 1,
        (ABS(CHECKSUM(NEWID())) % 3) + 1  
    )
    
    SET @counter = @counter + 1
END
--drop table Class
create table Class(
	[classId] int primary key not null,
	[className] nvarchar (max) not null,
)
insert into Class values
(1, 'SE1729'),
(2, 'SE1730'),
(3, 'SE1731')
--drop table ClassStudentSubject
CREATE TABLE ClassStudentSubject (
    [classId] INT NOT NULL,
    [studentId] INT NOT NULL,
    [subjectId] INT NOT NULL,
    PRIMARY KEY ([classId], [studentId], [subjectId]),
    FOREIGN KEY ([classId]) REFERENCES Class([classId]),
    FOREIGN KEY ([studentId]) REFERENCES Student([studentId]),
    FOREIGN KEY ([subjectId]) REFERENCES [Subject]([subjectId])
)
--select * from StudentSubject where subjectId = 1
insert into ClassStudentSubject values
(1, 1, 1),
(1, 4, 1),
(1, 6, 1),
(1, 9, 1),
(1, 11, 1),
(1, 12, 1),
(1, 13, 1),
(1, 15, 1),
(1, 18, 1),
(1, 20, 1),
(1, 21, 1),
(1, 22, 1),
(1, 23, 1),
(1, 24, 1),
(1, 25, 1),
(1, 27, 1),
--select * from StudentSubject where subjectId = 2
(2, 1, 2),
(2, 2, 2),
(2, 3, 2),
(2, 4, 2),
(2, 11, 2),
(2, 13, 2),
(2, 14, 2),
(2, 15, 2),
(2, 17, 2),
(2, 19, 2),
(2, 21, 2),
(2, 22, 2),
(2, 23, 2),
(2, 24, 2),
(2, 27, 2),
(2, 28, 2),
--select * from StudentSubject where subjectId = 3
(3, 1, 3),
(3, 2, 3),
(3, 12, 3),
(3, 16, 3),
(3, 17, 3),
(3, 20, 3),
(3, 21, 3),
(3, 25, 3),
(3, 30, 3)
--drop table Score
create table Score(
	[scoreId] int primary key not null,
	[lab1] int,
	[lab2] int,
	[assignment] int,
	[theoryExam] int,
	[practicalExam] int
)
DECLARE @counterr INT
SET @counterr = 1

WHILE @counterr <= 90
BEGIN
    INSERT INTO Score ([scoreId], [lab1], [lab2], [assignment], [theoryExam], [practicalExam])
    VALUES (
        @counterr,
        ABS(CHECKSUM(NEWID())) % 10 + 1,  -- Random value between 1 and 10 for lab1
        ABS(CHECKSUM(NEWID())) % 10 + 1,  -- Random value between 1 and 10 for lab2
        ABS(CHECKSUM(NEWID())) % 10 + 1,  -- Random value between 1 and 10 for assignment
        ABS(CHECKSUM(NEWID())) % 10 + 1,  -- Random value between 1 and 10 for theoryExam
        ABS(CHECKSUM(NEWID())) % 10 + 1   -- Random value between 1 and 10 for practicalExam
    )
    
    SET @counterr = @counterr + 1
END
drop table ScoreSubjectStudent
create table ScoreSubjectStudent(
	[sssId] int primary key,
	[scoreId] INT NOT NULL,
    [studentId] INT NOT NULL,
    [subjectId] INT NOT NULL,
    FOREIGN KEY ([scoreId]) REFERENCES Score([scoreId]),
    FOREIGN KEY ([studentId]) REFERENCES Student([studentId]),
    FOREIGN KEY ([subjectId]) REFERENCES [Subject]([subjectId])
)
insert into ScoreSubjectStudent values

(1, 1, 1, 1),
(2, 2, 1, 2),
(3, 3, 1, 3),
(4, 4, 2, 1),
(5, 5, 2, 2),
(6, 6, 2, 3),
(7, 7, 3, 1),
(8, 8, 3, 2),
(9, 9, 3, 3),
(10, 10, 4, 1),
(11, 11, 4, 2),
(12, 12, 4, 3),
(13, 13, 5, 1),
(14, 14, 5, 2),
(15, 15, 5, 3),
(16, 16, 6, 1),
(17, 17, 6, 2),
(18, 18, 6, 3),
(19, 19, 7, 1),
(20, 20, 7, 2),
(21, 21, 7, 3),
(22, 22, 8, 1),
(23, 23, 8, 2),
(24, 24, 8, 3),
(25, 25, 9, 1),
(26, 26, 9, 2),
(27, 27, 9, 3),
(28, 28, 10, 1),
(29, 29, 10, 2),
(30, 30, 10, 3),
(31, 31, 11, 1),
(32, 32, 11, 2),
(33, 33, 11, 3),
(34, 34, 12, 1),
(35, 35, 12, 2),
(36, 36, 12, 3),
(37, 37, 13, 1),
(38, 38, 13, 2),
(39, 39, 13, 3),
(40, 40, 14, 1),
(41, 41, 14, 2),
(42, 42, 14, 3),
(43, 43, 15, 1),
(44, 44, 15, 2),
(45, 45, 15, 3),
(46, 46, 16, 1),
(47, 47, 16, 2),
(48, 48, 16, 3),
(49, 49, 17, 1),
(50, 50, 17, 2),
(51, 51, 17, 3),
(52, 52, 18, 1),
(53, 53, 18, 2),
(54, 54, 18, 3),
(55, 55, 19, 1),
(56, 56, 19, 2),
(57, 57, 19, 3),
(58, 58, 20, 1),
(59, 59, 20, 2),
(60, 60, 20, 3),
(61, 61, 21, 1),
(62, 62, 21, 2),
(63, 63, 21, 3),
(64, 64, 22, 1),
(65, 65, 22, 2),
(66, 66, 22, 3),
(67, 67, 23, 1),
(68, 68, 23, 2),
(69, 69, 23, 3),
(70, 70, 24, 1),
(71, 71, 24, 2),
(72, 72, 24, 3),
(73, 73, 25, 1),
(74, 74, 25, 2),
(75, 75, 25, 3),
(76, 76, 26, 1),
(77, 77, 26, 2),
(78, 78, 26, 3),
(79, 79, 27, 1),
(80, 80, 27, 2),
(81, 81, 27, 3),
(82, 82, 28, 1),
(83, 83, 28, 2),
(84, 84, 28, 3),
(85, 85, 29, 1),
(86, 86, 29, 2),
(87, 87, 29, 3),
(88, 88, 30, 1),
(89, 89, 30, 2),
(90, 90, 30, 3)
select * from Class
select * from ClassStudentSubject
select * from Score
select * from ScoreSubjectStudent
select * from Student
select * from StudentSubject
select * from [Subject]

select 
