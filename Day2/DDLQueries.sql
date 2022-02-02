create database dbCompany2Feb22

use dbCompany2Feb22

create table tblSkills
(skillname varchar(20),
skill_description varchar(50))

sp_help tblSkills

alter table tblSkills
alter column skillname varchar(20) not null

alter table tblSkills
add constraint pk_skill primary key(skillname)

drop table tblSkills

--Primary key constraint name not given so it take a random number
create table tblSkills
(skillname varchar(20)  primary key,
skill_description varchar(50))
--with teh constraint name
create table tblSkills
(skillname varchar(20) constraint pk_skill primary key,
skill_description varchar(50))

alter table tblSkills
add industryRating int

alter table tblSkills
drop column industryRating 


create table tblArea(arealocation varchar(10) constraint pk_location primary key,zip_code char(4) not null)

sp_help tblArea

create table tblEmployee
(id char(4) constraint pk_employeeid primary key,
name varchar(20) not null,
location varchar(10) constraint fk_location foreign key references tblArea(arealocation),
phone varchar(12),
salary float,
remarks varchar(1000))

sp_help tblEmployee

create table tblEmployeeSkills
(Employee_Id char(4) references tblEmployee(id),
Skill_Name varchar(20),
skill_level int,
constraint pk_emp_skill primary key(Employee_id,skill_name),
constraint fk_skill foreign key(Skill_name) references tblSkills(skillname))



sp_help tblEmployeeSkills


create database dbShopuse dbShopcreate table tblCodes(zip_code char(3) constraint pk_zipcode primary key,area varchar(10) not null,city varchar(10) not null,state varchar(20) not null)create table tblProduct(id char(4) constraint pk_productid primary key,name varchar(50) not null,price_per_unit float constraint chk_Prod_price  check(price_per_unit>0),stock_available int )



sp_help tblProduct

create table tblSupplier(Supplier_ID char(3) not Null constraint pk_sid primary key,Name Varchar(20) Not null,Phone Varchar(12) Not null,email varchar(50),Address varchar(30),Zip char(3) not null constraint fk_zip foreign key references  tblCodes(zip_code))sp_help tblSupplierdrop table tblProductSuppliercreate table tblProductSupplier (  po_number int,  product_id char(4) references tblProduct(id),  supplier_id char(3) references tblSupplier(Supplier_ID),  date date not null,  quantity int not null default(1),  constraint pl_productsupplier primary key (po_number, product_id, supplier_id))