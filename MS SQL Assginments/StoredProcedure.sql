create database DetailsTable
use [DetailsTable]
go

create table UserDetails(
ID  int NOT NULL Primary key IDENTITY, 
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

create table UserGroup1
(
ID  int  not null primary key IDENTITY, 
Names  varchar(255), 
Descriptions varchar(1024) NULL, 
CreatedDate datetime,   
ModifiedDate  datetime, 
IsActive   bit, 
);

create table UserGroup2
(
ID   int not null primary key IDENTITY, 
GroupId   int,  
UserId   int,  
FOREIGN KEY (UserId) REFERENCES UserDetails(ID), 
FOREIGN KEY (GroupId) REFERENCES UserGroup1(ID), 
ModifiedDate   datetime, 
IsActive   bit, 
);


INSERT INTO UserDetails VALUES('Raj',  'K', 'raj@gmail.com', 'chennai', 20000, 'Tester', CAST(N'2023-03-11 7:31:09.000' AS DateTime), CAST(N'2023-04-16 11:20:08.000' AS DateTime), 0),
('Suresh',  'M', 'suresh@gmail.com', 'Salem', 80000, 'Developer', CAST(N'2023-01-11 2:30:09.000' AS DateTime), CAST(N'2023-02-10 9:12:07.000' AS DateTime), 1),
('Krish',  'T', 'Krish@gmail.com', 'Chennai', 100000, 'Engineer', CAST(N'2023-02-11 2:30:09.000' AS DateTime), CAST(N'2023-03-10 9:12:07.000' AS DateTime), 1);

INSERT INTO UserGroup1 VALUES('BOLD BI','It is a good product', CAST(N'2023-01-11 2:30:09.000' AS DateTime), CAST(N'2023-02-10 9:12:07.000' AS DateTime), 0) ,
('BOLD Desk', 'It is a good product', CAST(N'2023-01-11 2:30:09.000' AS DateTime), CAST(N'2023-02-10 9:12:07.000' AS DateTime), 1);
INSERT INTO UserGroup1(Descriptions,CreatedDate,ModifiedDate,IsActive ) VALUES('It is a good product', CAST(N'2023-01-11 2:30:09.000' AS DateTime), CAST(N'2023-02-10 9:12:07.000' AS DateTime), 1);

INSERT INTO UserGroup2 VALUES('1', '1', CAST(N'2023-02-10 9:12:07.000' AS DateTime), 0) ,
( '2', '2', CAST(N'2023-01-11 2:30:09.000' AS DateTime), 1),
('3', '3', CAST(N'2023-01-11 2:30:09.000' AS DateTime), 1);

create procedure spUserDesignation
@Designation varchar(30)
As
Begin
	select * from UserDetails where Designation=@Designation
End

spUserDesignation 'Developer'


create procedure spGetByCreatedDate
@createdDate datetime
As
Begin
	select * from UserDetails where CreatedDate>@createdDate order by CreatedDate;
End

spGetByCreatedDate '2023-02-11'


create procedure spGetByGroupName
As
Begin
	select UserDetails.*,UserGroup1.Names as [Group Name] from UserDetails inner join UserGroup1 on UserGroup1.ID=UserDetails.ID;
End

spGetByGroupName 


alter procedure spNoNullGroupName
As
Begin
	select UserDetails.*, UserGroup1.* from UserDetails inner join UserGroup1 on UserDetails.ID=UserGroup1.ID where UserGroup1.CreatedDate>'2023-01-11' and UserGroup1.Names is not null;
End

spNoNullGroupName

select * from UserDetails;
select * from UserGroup1;
select * from UserGroup2;

