create database VbDotNet
create table Register(
Id int primary key identity(1,1),
FirstName varchar(60),
MiddleName varchar(60),
LastName varchar (60),
Gender char(20),
Address varchar(120),
PinCode int,
State varchar (45)
)
select * from Register