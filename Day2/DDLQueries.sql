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


create table tblArea

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


create database dbShop



sp_help tblProduct

create table tblSupplier