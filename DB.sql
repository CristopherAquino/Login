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
)

insert into Users values ('admin','admin','Jackson','Collins','Administrator','Support@SystemAll.biz');
insert into Users values ('Ben','abc123456','Benjamin','Thompson','Receptionist','BenThompson@MyCompany.com');
insert into Users values ('Kathy','abc123456','Kathrine','Smith','Accounting','KathySmith@MyCompany.com');

CREATE TABLE Clientes (
  ID int IDENTITY(1,1) primary key,
  Nombre nvarchar(20) NOT NULL,
  Apellido nvarchar(23) NOT NULL,
  Direccion nvarchar(100) NOT NULL,
  Ciudad nvarchar(100) NOT NULL,
  Email nvarchar(100) NOT NULL,
  Telefono nvarchar(25) NOT NULL,
  Ocupacion nvarchar(70) NOT NULL
)

--PROCEDIMIENTO
CREATE PROC VerRegistros
@Condicion nvarchar(30)
as
select *from Clientes where ID like @Condicion+'%' or Nombre like @Condicion+'%' 


insert into Clientes values(N'Olimpo',N'Garibay',N'1473 Mahlon Street',N'Southfield',N'OlimpoGaribayLimon@rhyta.com',N'734-227-9161',N'Roustabout');
insert into Clientes values(N'Normando',N'Segovia',N'505 Reppert Coal Road',N'Southfield',N'NormandoSegoviaLozano@teleworm.us',N'586-819-7304',N'Agronomist');
insert into Clientes values(N'Cuasimodo',N'Acevedo',N'3129 Eagle Drive',N'Southfield',N'CuasimodoAcevedoPaz@cuvox.de',N'734-758-1113',N'Management accountant');
insert into Clientes values(N'Tilo',N'Quintero',N'1026 Park Avenue',N'Sacramento',N'TiloQuinteroRoybal@superrito.com',N'916-479-8297',N'Grader operator');
insert into Clientes values(N'Efraim',N'Fajardo',N'4402 Oakway Lane',N'Los Angeles',N'EfraimFajardoCuellar@fleckens.hu',N'818-329-2608',N'Metal pourer');
insert into Clientes values(N'Viviano',N'Maestas',N'118 Water Street',N'Walnut Creek',N'VivianoMaestasColunga@rhyta.com',N'925-287-1169',N'School and college counselor');
insert into Clientes values(N'Denisse',N'Alva',N'2916 Glendale Avenue',N'Northridge',N'DenisseAlvaRoque@teleworm.us',N'818-727-3647',N'Sports book runner');
insert into Clientes values(N'Saustin',N'Gracia',N'356 Marcus Street',N'Gadsden',N'SaustinGraciaPerea@einrot.com',N'256-549-8973',N'Education and training manager');
insert into Clientes values(N'Malva',N'Correa',N'271 Brown Street',N'Oakland',N'MalvaCorreaResendez@gustr.com',N'925-984-4729',N'Tool and die maker');
insert into Clientes values(N'Sein',N'Vallejo',N'2172 Moore Avenue',N'Fort Worth',N'SeinVallejoYanez@einrot.com',N'817-782-5307',N'Word processor');
insert into Clientes values(N'Olimpo',N'Gallardo',N'4747 Briarwood Road',N'Joplin',N'OlimpoGallardoBriseno@armyspy.com',N'417-825-8900',N'Geologist');
insert into Clientes values(N'Lalita',N'Villalpando',N'2272 Reeves Street',N'Brussels',N'LalitaVillalpandoEchevarria@einrot.com',N'920-825-8672',N'Management analyst');