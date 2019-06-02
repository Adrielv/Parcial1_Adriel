

create database Projecto_ParcialDb
go
use Projecto_ParcialDb

create table Parcial
(
	ProductoId int primary key identity,
	Descripcion varchar(30),
	Existen float,
	Costo float,
	
);

create table ParcialT2
(
	Id int primary key identity,
	Valor_Inventario float

);

