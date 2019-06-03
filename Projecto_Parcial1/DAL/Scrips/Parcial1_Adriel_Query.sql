
create database Parcial1_Adriel
go
use Parcial1_Adriel

create table Parcial
(
	ProductoId int primary key identity,
	Descripcion varchar(30),
	Existen int,
	Costo float,
	Valor_Inventario float
	
);

create table Parcial1
(
	Id int primary key identity,
	Valor_Inventario float
);

 SET IDENTITY_INSERT ValorInventarios ON
 insert into ValorInventarios(Id,Valor_Inventario) values('1','0');

 delete from ValorInventarios where Id = 1

select * from ValorInventarios
select * from Productoes