
--Create Database EmpDB
use EmpDB
go

create table EMP
(
	ID int,
	Name nvarchar(50)
	
)

insert into EMP values(1, 'Umesh')
insert into EMP values(2, 'Rehan')
insert into EMP values(3, 'Sarang')
insert into EMP values(4, 'Sahil')
insert into EMP values(5, 'Amit')
insert into EMP values(6, 'Prasad')

create table Student
(
	ID int IDENTITY(1,1),
	Name nvarchar(50),
	Rollno int
)

insert into Student values('Rehan', 313171)
insert into Student values('Sarang', 313172)
insert into Student values('Umesh', 313173)
insert into Student values('Prasad', 313174)



