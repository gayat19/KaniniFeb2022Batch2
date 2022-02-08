use Northwind

select * from products

select * from Categories

select * from Products where CategoryID 
= (select CategoryID from Categories where CategoryName = 'Confections')

select ProductName,CategoryName from 
Products join Categories
on Products.CategoryID = Categories.CategoryID

--Print the Orderdate and the customer name
select OrderDate, CompanyName, ContactName

  --Print the Order date and the Employee's First Name

select FirstName,OrderDate

select * from Employees

select distinct EmployeeId from Orders

select * from Employees where EmployeeID not in (select distinct EmployeeId from Orders)

select * from [Order Details]

select distinct ProductId from [Order Details]
select count(distinct ProductId) 'Number of products' from [Order Details]
select count(ProductId) 'Total products' from [Order Details]

select * from products where  ProductID not in 
(select distinct ProductId from [Order Details])

--Find the customers who have never placed any order
select * from Customers where CustomerID not in


select OrderDate, CompanyName, ContactName