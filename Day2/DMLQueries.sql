use dbCompany2Feb22

--ctrl+K+C -c comment
select * from tblArea

insert into tblArea values('XXX','1234')
--insert into tblArea values('XXX','1234')
--insert into tblArea values(null,'1234')
insert into tblArea(arealocation, zip_code) values('YYY','4321')
insert into tblArea( zip_code, arealocation) values('4334','III')

insert into tblArea( zip_code, arealocation) values('8800','LLL'),('9977','KKK')

insert into tblEmployee values('E001','ABC','XXX','9876543210',234566,'NOthing to say')
insert into tblEmployee values('E002','EFG','KKK','7654321098',876654,'Very Good')
insert into tblEmployee values('E003','HIJ','LLL','6677889900',8906654,'')
insert into tblEmployee values('E004','LMN','XXX','5544332211',876877,null)

insert into tblEmployee values('E0045','LMN','XXX','5544332211',876877,null)

insert into tblSkills values('C#','PL'),('SQL','RDBMS'),('GIT','SCM'),('Java','Web')

select * from tblSkills
select * from tblEmployee

insert into tblEmployeeSkills values('E001','C#',7),('E001','SQL',8),('E001','Git',7)
insert into tblEmployeeSkills values('E002','Git',7),('E002','SQL',8),('E002','Java',7)

select * from tblEmployeeSkills


update tblEmployeeSkills set skill_level = 7 where Employee_Id='E002' and Skill_Name = 'Java'

update tblEmployeeSkills set skill_level = 9 where Employee_Id='E002' 

delete from tblEmployeeSkills  where Employee_Id='E002' and Skill_Name = 'Java'
delete from tblEmployeeSkills 

--Create - Insert
--Update - Update
--Delete - delete


delete from tblEmployee where id='E001'

