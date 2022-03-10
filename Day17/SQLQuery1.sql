alter  proc proc_GetAllProducts
as
begin
   select ProductID,ProductName, QuantityPerUnit, UnitPrice,UnitsInStock from Products
end

exec proc_GetAllProducts

select * from tblUSer

alter proc proc_LoginCheck(@uname varchar(20),@pass varchar(20), @urole varchar(20) out )
as
begin
	set @urole = (select role from tblUSer where username = @uname and password = @pass)
	if(@urole is null)
	  set @urole = 'invalid'
end

declare
@urole varchar(20)
begin
  exec proc_LoginCheck 'Bimu', 'somu12' , @urole out
  print @urole
end

create proc proc_Register(@uname varchar(20),@upass varchar(20),@Urole varchar(20),@uage int)
as
begin
   insert into tblUser values(@uname,@upass,@Urole,@uage)
end

exec proc_Register 'Jimu','jimu123','user',22