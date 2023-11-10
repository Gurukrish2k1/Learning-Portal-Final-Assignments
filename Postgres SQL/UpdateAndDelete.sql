
create table UserDetails(
ID serial Primary key NOT NULL, 
FirstName  varchar(255) , 
LastName  varchar(255) , 
Email  varchar(255) , 
City varchar(255) , 
Salary  numeric , 
Designation  varchar(255) , 
CreatedDate  date , 
ModifiedDate  date , 
IsActive  bit 
);

create table UserGroup(
ID  serial Primary key NOT NULL,
Names  varchar(255), 
Description varchar(1024) default 'No description', 
CreatedDate date,   
ModifiedDate  date, 
IsActive   bit 
);

create table UserGroupTable
(
ID  serial Primary key NOT NULL,
GroupId   integer,  
UserId   integer,  
ModifiedDate   date, 
IsActive   bit
);

 

INSERT INTO UserDetails(FirstName , 
LastName , 
Email , 
City , 
Salary , 
Designation , 
CreatedDate  , 
ModifiedDate  date , 
IsActive  bit) VALUES('Raj',  'K', 'raj@gmail.com', 'chennai', 20000, 'Tester', CAST(N'2023-03-11 7:31:09.000' AS date), CAST(N'2023-04-16 11:20:08.000' AS date), '0'),
( 'Suresh',  'M', 'suresh@gmail.com', 'Salem', 80000, 'Developer', CAST(N'2023-01-11 2:30:09.000' AS date), CAST(N'2023-02-10 9:12:07.000' AS date), '1'),
( 'Krish',  'T', 'Krish@gmail.com', 'Chennai', 100000, 'Engineer', CAST(N'2023-02-11 2:30:09.000' AS date), CAST(N'2023-03-10 9:12:07.000' AS date), '1');

INSERT INTO UserGroup VALUES('1',  'Raj','He is a good tester and identifies bug easily', CAST(N'2023-01-11 2:30:09.000' AS date), CAST(N'2023-02-10 9:12:07.000' AS date), '0') ,
('2',  'Suresh', 'Developer with good creative skills', CAST(N'2023-01-11 2:30:09.000' AS date), CAST(N'2023-02-10 9:12:07.000' AS date), '1'),
('3',  'Krish', 'Creative Engineer', CAST(N'2023-01-11 2:30:09.000' AS date), CAST(N'2023-02-10 9:12:07.000' AS date), '1');

INSERT INTO UserGroupTable VALUES('1', '1', '1', CAST(N'2023-02-10 9:12:07.000' AS date), '0') ,
('2', '2', '2', CAST(N'2023-01-11 2:30:09.000' AS date), '1'),
('3', '3', '3', CAST(N'2023-01-11 2:30:09.000' AS date),'1');

INSERT INTO UserGroup(ID, Names,CreatedDate,ModifiedDate,IsActive ) VALUES(4, 'Guru', CAST(N'2023-01-11 2:30:09.000' AS date), CAST(N'2023-02-10 9:12:07.000' AS date), '1');
INSERT INTO UserGroup(ID, Names,CreatedDate,ModifiedDate,IsActive ) VALUES(5, 'Report', CAST(N'2023-01-11 2:30:09.000' AS date), CAST(N'2023-02-10 9:12:07.000' AS date), '1');
INSERT INTO UserGroup(ID, Names,CreatedDate,ModifiedDate,IsActive ) VALUES(6, 'AI', CAST(N'2023-01-11 2:30:09.000' AS date), CAST(N'2023-02-10 9:12:07.000' AS date), '1');
INSERT INTO UserGroup(ID, Names,CreatedDate,ModifiedDate,IsActive ) VALUES(7, 'BI', CAST(N'2023-01-11 2:30:09.000' AS date), CAST(N'2023-02-10 9:12:07.000' AS date), '1');
INSERT INTO UserGroup(ID, Names,CreatedDate,ModifiedDate,IsActive ) VALUES(8, 'Bold', CAST(N'2023-01-11 2:30:09.000' AS date), CAST(N'2023-02-10 9:12:07.000' AS date), '1');

update UserDetails set IsActive = '1' where CreatedDate < '2023-03-11';
 
update UserDetails set ModifiedDate = CreatedDate where IsActive='1';
 
delete from UserGroupTable where GroupId = 2;
 
select * from UserDetails;
select * from UserGroup;
select * from UserGroupTable;

