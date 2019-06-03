
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

