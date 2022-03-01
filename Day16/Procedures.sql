select * from tblUser
--stored procedures
select * from Products

select * from products where CategoryID = 4

select * from products 
where CategoryID = 3

create procedure proc_GetProducts
as
begin
   select * from products
end


exec proc_GetProducts

create proc proc_GetProductByCategrory(@cid int)
as
begin
   select * from products where CategoryID = @cid
end

alter proc proc_GetProductByCategrory(@cid int,@uns int)
as
begin
   select * from products where CategoryID = @cid and UnitsInStock > @uns
end

exec proc_GetProductByCategrory 6, 3


create proc proc_CheckAndFetchProdByCategory(@cid int)
as
begin 
   if(@cid>0)
      select * from products where CategoryID = @cid
	else
	  print 'Invalid category id'
end

exec proc_CheckAndFetchProdByCategory -1
select * from Categories

--create a procedure that  will get teh the ctegory name and print the all teh products in that
create proc proc_GetProductsWithCategoryName(@cname varchar(20))
as
begin
  Select * from products where CategoryID =(select categoryid from Categories where CategoryName = @cname)
end

exec proc_GetProductsWithCategoryName 'Condiments'

--create a proc that will take a category id and print product name and category name

--create a proc that will take the name,password,role and age and insert into the user table
select * from tblUSer


create proc proc_InsertUser(@uname varchar(20),@upass varchar(20),@urole varchar(20),@uage int)
as
begin
  insert into tblUSer values(@uname,@upass,@urole,@uage)
end

create proc proc_GetCaretoryName(@cid int, @cname varchar(50) out)
as
begin
   set @cname = (Select CategoryName from Categories where CategoryID = @cid)
end

declare
@catName varchar(50)
begin
  exec proc_GetCaretoryName 1, @Catname out
  print 'Category name is '+@Catname
end


select * from Customers
--create a procedure that will take the customer name and give back the total number of orders placed by him/her

create proc proc_GetTotalNumberOfSale(@cname varchar(20),@ocount int out)
as
begin
  set @ocount = (select count(o.orderid)  From Customers c join Orders o
  on c.CustomerID = o.CustomerID where c.ContactName = @cname)
end

declare
@ccount int
begin
  exec proc_GetTotalNumberOfSale 'Janine Labrune',@ccount out
  print @Ccount
end


s