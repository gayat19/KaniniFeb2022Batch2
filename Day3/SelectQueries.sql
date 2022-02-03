use Northwind

select * from Products

select ProductName from Products
select ProductName, UnitPrice from Products
select ProductName, QuantityPerUnit from Products

select ProductName Name_Of_The_Product, UnitPrice from Products

select ProductName 'Name Of The Product', UnitPrice from Products


--Products that are available in stock
select * from products where UnitsInStock>0

select * from Products where UnitPrice <=20

--Select Products that are no more available
select* from Products where Discontinued=1

select * from Products where UnitPrice >=20 and UnitPrice <= 40
select * from Products where UnitPrice between 20 and  40

select * from Orders

--select teh orders that have frright more than 50
select * from Orders where Freight >= 50
--select teh orders that have shipped after 1996-07-11 00:00:00.000
select * from Orders where ShippedDate >= '1996-07-11'
--select teh orders that have been sold by employee 3select * from Orders where EmployeeID = 3

select * from Orders where ShipRegion is not Null
--Select the orders which have been shipped by Hanari Carnesselect * from Orders where ShipName ='Hanari Carnes'----Select the orders which have not been  shipped by Rattlesnake Canyon Groceryselect * from Orders where ShipName != 'Rattlesnake Canyon Grocery'select * from Orders where ShipName ='Hanari Carnes' or ShipName = 'Rattlesnake Canyon Grocery'or ShipName = 'Chop-suey Chinese'select * from Orders where ShipName  in ('Hanari Carnes','Rattlesnake Canyon Grocery','Chop-suey Chinese')select * from Orders where ShipName not in ('Hanari Carnes','Rattlesnake Canyon Grocery','Chop-suey Chinese')--Wild card % - 0 or any number of any char--Wild card _ - one charselect * from Products where ProductName like '_h%'--select the product names of those products whcih have names --that have e in to and are priced more than 15 per unit select * from products where productname like '%e%' and UnitPrice >=15 select avg(unitprice) 'Average Unit Price' from Products select round(123.5645,0) select round(avg(unitprice),2) 'Average Unit Price' from Products --Oleh's Solution --Print the total units in hand of all the products(Hint sum)  select sum(UnitsInStock) 'Total Units In Hand' from Products --Print the average price of all product in category 2 select round(avg(unitprice),2) 'Average Unit Price In Category 2' from Products where CategoryID=2 -- print the total units in stock of all teh products that have been discontinuedselect sum(UnitsInStock) 'Total Units In Stock Of Discontinued' from Products where Discontinued = 1 select round(avg(unitprice),2) 'Average Unit Price In Category 2',  sum(UnitsInStock) 'Total Units In Stock'  from Products where CategoryID=2 select round(avg(unitprice),2) 'Average Unit Price In Category 2',  sum(UnitsInStock) 'Total Units In Stock'  from Products where CategoryID=2 select * from Products where SOUNDEX(Productname) = soundex('Chaai') --too,to,two --four fore --so, soo, sow select SupplierID, count(productId) 'Number od products supplied' from products group by SupplierID --LIst the categoryIds and the average unit price of each select CategoryId, round(avg(UnitPrice),2) 'Avarage Price Of Category' from Productsgroup by CategoryId--select teh number of order given by each customerselect CustomerID, count(CustomerID) 'Number of orders' from Ordersgroup by CustomerID--select the total freight paid by every ship(shipname)select ShipName, sum(Freight)'Total Freight Paid' from Ordersgroup by ShipName--select the first orderd date of every customer(hing-minimum)select CustomerID, min(OrderDate)'First Order Date' from Ordersgroup by CustomerIDselect ShipName, sum(Freight)'Total Freight Paid' from Orderswhere ShipName like '%a%'group by ShipName having sum(Freight)>100select * from Products order by UnitPriceselect * from Products order by UnitPrice descselect * from Products order by CategoryID , SupplierIDselect * from Productswhere UnitPrice>10order by CategoryID , SupplierIDselect ShipName, sum(Freight)'Total Freight Paid' from Orderswhere ShipName like '%a%'group by ShipName having sum(Freight)>100order by sum(Freight) descselect ShipName, sum(Freight)'Total Freight Paid' from Orderswhere ShipName like '%a%'group by ShipName having sum(Freight)>100order by 2 desc-----Sub queriesselect * from Categoriesselect * from productsselect CategoryId from Categories where CategoryName = 'Confections'select * from products where CategoryID = 3select * from products where CategoryID = (select CategoryId from Categories where CategoryName = 'Confections')select * from products where CategoryID in (select CategoryId from Categories where CategoryName like  'C%')select * from Customers--select all the orders which are orders by customers who come from Mexicoselect * from Orders where CustomerID in (select CustomerID from Customers where Country='Mexico')select shipname from Orders order by 1select distinct shipname from Orders