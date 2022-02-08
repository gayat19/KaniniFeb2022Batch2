use Northwind

select * from products

select * from Categories

select * from Products where CategoryID 
= (select CategoryID from Categories where CategoryName = 'Confections')

select ProductName,CategoryName from 
Products join Categories
on Products.CategoryID = Categories.CategoryID

--Print the Orderdate and the customer name
select OrderDate, CompanyName, ContactName  from Orders join Customers on Orders.CustomerID = Customers.CustomerID

  --Print the Order date and the Employee's First Name

select FirstName,OrderDatefrom Orders join Employeeson Orders.EmployeeID= Employees.EmployeeID

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
select * from Customers where CustomerID not in(select distinct CustomerID from Orders)


select OrderDate, CompanyName, ContactName  from Orders join Customers on Orders.CustomerID = Customers.CustomerID  select OrderDate, CompanyName, ContactName  from Orders right outer join Customers on Orders.CustomerID = Customers.CustomerIDSelect ProductName,OrderDate,Quantity,od.UnitPrice,(Quantity*od.UnitPrice) 'Total Price'from  Orders o join [Order Details] odon o.OrderID = od.OrderIDjoin Products p on od.ProductID = p.ProductID--Print the product name, category namea and teh supplier nameSelect ProductName,CategoryName,CompanyName,ContactNamefrom  Products p join Suppliers son p.SupplierID = s.SupplierIDjoin Categories c on p.CategoryID = c.CategoryID--print the  customer name, Order date, Product Name(hint - join 4 tables)select ContactName, CompanyName, OrderDate, ProductNamefrom Orders o join [Order Details] od on od.OrderID=o.OrderIDjoin Customers c on c.CustomerID=o.CustomerIDjoin Products p on p.ProductID=od.ProductIDwhere c.Country = 'Mexico'---company name and teh numebr of ordersselect CompanyName,count(o.orderid) 'Number of orders'from Orders o join Customers con o.CustomerID = c.CustomerIDgroup by CompanyNameselect CompanyName,count(o.orderid) 'Number of orders'from Orders o join Customers con o.CustomerID = c.CustomerIDgroup by CompanyNameorder by 2select CompanyName,count(o.orderid) 'Number of orders'from Orders o join Customers con o.CustomerID = c.CustomerIDgroup by CompanyNameorder by [Number of orders]select CompanyName,count(o.orderid) 'Number of orders'from Orders o join Customers con o.CustomerID = c.CustomerIDgroup by CompanyNameorder by count(o.orderid)select CompanyName,count(o.orderid) 'Number of orders'from Orders o join Customers con o.CustomerID = c.CustomerIDwhere c.Country = 'Mexico'group by CompanyNamehaving count(o.orderid) >2order by count(o.orderid)select * from Employeesselect concat(firstname,' ',lastname) 'Employee Name'from Employees--Employee name, manager nameselect emp.EmployeeId 'Employee Id', emp.firstname 'Employee Name',emp.reportsto 'Manager ID' , mgr.FirstName 'Manager Name'from Employees emp join Employees mgron emp.reportsto = mgr.EmployeeIDselect * from employeesselect * from productsselect * from employees cross join products