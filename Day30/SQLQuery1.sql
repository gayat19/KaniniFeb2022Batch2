use dbCUstomerManagement

create table tblUSer
(loginid varchar(20) primary key,
password varchar(20),
role varchar(10) check(role in ('user','admin')))

create proc proc_InsertUser(@uname varchar(20),@upass varchar(20),@urole varchar(20))
as
begin
   insert into tblUser values(@uname,@upass,@urole)
end

exec  proc_InsertUser 'Bimu','1111','fsd'

select * from tblUSer

create proc proc_LoginCheck(@uname varchar(20),@upass varchar(20))
as
begin
  select role from tbluser where loginid=@uname and password=@upass
end

exec proc_LoginCheck 'Ramu','1234'
exec proc_LoginCheck 'Ramu','1111'