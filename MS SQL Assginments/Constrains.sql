create database DetailsTable
use [DetailsTable]
go
create table UserDetails(
ID  int NOT NULL Primary key, 
FirstName  varchar(255) , 
LastName  varchar(255) , 
Email  varchar(255) , 
City varchar(255) , 
Salary  numeric , 
Designation  varchar(255) , 
CreatedDate  datetime , 
ModifiedDate  datetime , 
IsActive  bit 
);
create table UserGroup
(
ID  int  not null primary key, 
Names  varchar(255), 
Descriptions varchar(1024), 
CreatedDate datetime,   
ModifiedDate  datetime, 
IsActive   bit, 
);

create table UserGroupTable
(
ID   int not null primary key , 
GroupId   int,  
UserId   int,  
ModifiedDate   datetime, 
IsActive   bit, 
);

alter table UserGroup
add constraint DF_UserGroup_Descriptions
Default 'No description' for Descriptions;
 

INSERT INTO UserDetails VALUES('1',  'Raj',  'K', 'raj@gmail.com', 'chennai', 20000, 'Tester', CAST(N'2023-03-11 7:31:09.000' AS DateTime), CAST(N'2023-04-16 11:20:08.000' AS DateTime), 0),
('2',  'Suresh',  'M', 'suresh@gmail.com', 'Salem', 80000, 'Developer', CAST(N'2023-01-11 2:30:09.000' AS DateTime), CAST(N'2023-02-10 9:12:07.000' AS DateTime), 1),
('3',  'Krish',  'T', 'Krish@gmail.com', 'Chennai', 100000, 'Engineer', CAST(N'2023-02-11 2:30:09.000' AS DateTime), CAST(N'2023-03-10 9:12:07.000' AS DateTime), 1);

INSERT INTO UserGroup VALUES('1',  'Raj','He is a good tester and identifies bug easily', CAST(N'2023-01-11 2:30:09.000' AS DateTime), CAST(N'2023-02-10 9:12:07.000' AS DateTime), 0) ,
('2',  'Suresh', 'Developer with good creative skills', CAST(N'2023-01-11 2:30:09.000' AS DateTime), CAST(N'2023-02-10 9:12:07.000' AS DateTime), 1),
('3',  'Krish', 'Creative Engineer', CAST(N'2023-01-11 2:30:09.000' AS DateTime), CAST(N'2023-02-10 9:12:07.000' AS DateTime), 1);

INSERT INTO UserGroupTable VALUES('1', '1', '1', CAST(N'2023-02-10 9:12:07.000' AS DateTime), 0) ,
('2', '2', '2', CAST(N'2023-01-11 2:30:09.000' AS DateTime), 1),
('3', '3', '3', CAST(N'2023-01-11 2:30:09.000' AS DateTime), 1);

INSERT INTO UserGroup(ID, Names,CreatedDate,ModifiedDate,IsActive ) VALUES(4, 'Guru', CAST(N'2023-01-11 2:30:09.000' AS DateTime), CAST(N'2023-02-10 9:12:07.000' AS DateTime), 1);


select * from UserDetails;
select * from UserGroup;
select * from UserGroupTable;
