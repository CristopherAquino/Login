create database MyCompany;
use MyCompany;

create table Users(
UserID int primary key identity(1,1),
LoginName varchar (100) unique not null,
Password varchar (100) not null,
FirstName varchar(100) not null,
LastName varchar(100) not null,
Position varchar (100) not null,
Email varchar(150)not null
); 
insert into Users values ('admin','admin','Jackson','Collins','Administrator','Support@SystemAll.biz');
insert into Users values ('Ben','abc123456','Benjamin','Thompson','Receptionist','BenThompson@MyCompany.com');
insert into Users values ('Kathy','abc123456','Kathrine','Smith','Accounting','KathySmith@MyCompany.com');