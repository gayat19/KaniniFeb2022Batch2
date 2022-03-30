create database dbSample29Mar22

use dbSample29Mar22

create table tblEmployee
(id int identity(101,1) primary key,
name varchar(20),
age int,
salary float)

insert into tblEmployee(name,age,salary) values('Ramu',23,34567.6)
insert into tblEmployee(name,age,salary) values('Somu',31,56368.2)
insert into tblEmployee(name,age,salary) values('Bimu',33,98765.0)
insert into tblEmployee(name,age,salary) values('Rumu',21,24233.4)

select * from tblEmployee

create proc proc_UpdateSalary(@eid int,@esal float)
as
  update tblEmployee set salary=@esal where id=@eid
  
create proc proc_GetAllEmployees
as
  select * from tblEmployee

create proc proc_GetAllEmployeeById(@eid int)
as
  select * from tblEmployee where id=@eid

create proc proc_InsertEmployee(@ename varchar(20),@eage int,@esal float)
as
 insert into tblEmployee(name,age,salary) values(@ename,@eage,@esal)
 exec proc_InsertEmployee 'Himu',23,124234.33

create proc proc_DeleteEmployeeById(@eid int)
as
  Delete from tblEmployee where id=@eid

select * from tblEmployee