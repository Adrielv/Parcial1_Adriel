

create database Projecto_Parcial2Db
go
use Projecto_Parcial2Db

create table Parcial
(
	ProductoId int primary key identity,
	Descripcion varchar(30),
	Existen int,
	Costo float,
	Valor_Inventario float
	
);



