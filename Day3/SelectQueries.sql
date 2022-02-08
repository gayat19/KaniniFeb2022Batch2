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
--select teh orders that have been sold by employee 3

select * from Orders where ShipRegion is not Null
