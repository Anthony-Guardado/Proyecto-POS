--Creacion de la DB del Proyecto Pos
--Sobre la Cafeteria Dulce Aroma
create database Cafeteria_Dulce_AromaDB;

--Creacion de tablas independientes
create table Categoria(
Id int primary key identity(1,1),
Nombre varchar(100) not null
);

create table TipoPago(
Id int primary key identity(1,1),
Nombre varchar(100) not null
);

create table Cliente(
Id int primary key identity(1,1),
NombreCompleto varchar(100) not null,
Dui int not null,
Telefono int not null,
Email varchar(100) not null,
Estado bit not null,
);

create table Usuario(
Id int primary key identity(1,1),
Usuario Varchar(100) not null,
Clave VARBINARY(64) not null,
Estado bit not null
);

--Tablas dependientes
create table Producto(
Id int primary key identity(1,1),
Nombre varchar(100) not null,
Precio decimal(10,2) not null,
Id_Categoria int,
Stock int not null,
Estado bit not null,
constraint FK_Producto_Categoria foreign key (Id_Categoria) references Categoria(Id)
);

create table Venta(
Id int primary key identity(1,1),
FechaVenta date not null,
MontoTotal decimal(10,2) not null,
Id_TipoPago int,
Id_Cliente int,
Stock int not null,
Estado bit not null,
constraint FK_Venta_Cliente foreign key (Id_Cliente) references Cliente(Id),
constraint FK_Venta_TipoPago foreign key (Id_TipoPago) references TipoPago(Id)
);

--Tabla intermedia
create table DetalleVenta(
Id int primary key identity (1,1),
Cantidad int not null, 
PrecioUnitario decimal(10,2) not null,
SubTotal decimal(10,2) not null,
Id_Venta int,
Id_Producto int,
constraint FK_DetalleVenta_Venta foreign key (Id_Venta) references Venta(Id),
constraint FK_DetalleVenta_Producto foreign key (Id_Producto) references Producto(Id),

);
