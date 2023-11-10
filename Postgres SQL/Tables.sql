
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

select * from UserDetails;
select * from UserGroup;
select * from UserGroupTable;

drop table UserGroups;
