create database Projecto_Parcial1Db
go
use Projecto_Parcial1Db

create table Parcial1
(
	ProductoId int primary key identity,
	Descripcion varchar(30),
	Existen int,
	Costo int,
	Valor_Inventario int
);

