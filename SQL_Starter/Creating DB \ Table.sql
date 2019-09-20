Create database School

USE School

CREATE TABLE Students
(
    ID int primary key NOT NULL IDENTITY(1,5000),
    FirstName varchar(5),
    LastName varchar(10),
	  Birthday date,
	  Gender varchar(10)
); 

alter table Students
alter column FirstName nvarchar(20) not null

alter table Students
alter column LastName nvarchar(20) not null

alter table Students
add Phone varchar(13) unique not null

alter table Students
add EMail varchar(20) unique not null

alter table Students
add Country varchar(30) not null

alter table Students
add GPA real not null 
