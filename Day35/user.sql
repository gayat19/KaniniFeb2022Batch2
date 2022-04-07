create database dbStore05Mar2022

use dbStore05Mar2022



create table tblUser
(username varchar(200) primary key,
password varbinary(max),
passkey varbinary(max))

create proc proc_Login(@un varchar(200))
as
  select * from tbluser where username=@un

alter proc proc_register(@un varchar(20),@upass varbinary(max),@ukey varbinary(max))
as
  Insert into tblUser values(@un,@upass,@ukey)

  select * from tblUser