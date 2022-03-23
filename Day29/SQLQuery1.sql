create database dbCUstomerManagement
use dbcustomermanagement

create table tblCUstomer
(id int identity(101,1) primary key,
name varchar(20),
age int,
phone varchar(15),
pic varchar(100))

create proc pro_InsertCustomer(@cname varchar(20),@cage int,@cpic varchar(100),@cphone varchar(15))
as
begin
   insert into tblCUstomer(name,age,pic,phone) values(@cname,@cage,@cpic,@cphone)
end

pro_InsertCustomer 'Ramu',23,'/images/Pic1.jpg','9876543210'

select * from tblCUstomer

create proc proc_GetAllCustomers
as
  select * from tblCUstomer