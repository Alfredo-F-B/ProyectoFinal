create database Hotel2012;

/*_______________TABLA USUARIO_______________________________*/
create table Usuario
(
	Id				int				not null identity (1,1) primary key,
	Nickname		varchar(64)		not null,
	password		varchar(64)		not null
);


/*_________________TABLA EMPLEADO_____________________________________*/
create table Empleado
(
	Id				int				not null identity(1,1) primary key,
	IdUsuario       int				not null,
	CI				varchar(8)		not null,
	ApPaterno		varchar(64)		not null,
	ApMaterno		varchar(64)		not null,
	Nombres			varchar(64)		not null,
	Sexo			varchar(1)		not null,
	FechaNacimiento datetime		not null,
	Nacionalidad	varchar(64)		not null,
	/*Fotografia	    varchar(1000)	not null,*/
	Direccion		varchar(64)		not null,
	Telefono		varchar(16)		not null,
	Celular			varchar(16)		not null,
	FechaRegistro	datetime		not null,
	foreign key(idUsuario)			references Usuario(id)
);

/*_________________TABLA EMPLEADO_____________________________________*/
create table Administrador
(
	Id				int				not null identity(1,1) primary key,
	IdUsuario       int				not null,
	CI				varchar(8)		not null,
	ApPaterno		varchar(64)		not null,
	ApMaterno		varchar(64)		not null,
	Nombres			varchar(64)		not null,
	Sexo			varchar(1)		not null,
	FechaNacimiento datetime		not null,
	Nacionalidad	varchar(64)		not null,
	/*Fotografia	    varchar(1000)	not null,*/
	Direccion		varchar(64)		not null,
	Telefono		varchar(16)		not null,
	Celular			varchar(16)		not null,
	FechaRegistro	datetime		not null,
	foreign key(idUsuario)			references Usuario(id)
);

/*__________________TABLA HABITACION___________________________________*/
create table Habitacion
(
	Id				int				not null identity(1,1) primary key,
	Numero			int				not null,
	Categoria		varchar(64)		not null, /*simple, doble, triple, matrimonial,ejecutivo*/
	Estado			varchar(64)		not null, /*reservado, libre, ocupado*/
	Descripcion		varchar(1000)	not null,
	/*Fotografia	    varchar(1000)	not null,*/
	Piso			varchar(20)		not null,
	Precio			float			not null,
	TipoPago		varchar(20)		not null,
	Fecha			datetime		not null,
	TvCable			varchar(20)		not null,
	Baño			varchar(20)		not null,
	Acondicionador	varchar(20)		not null,
	Calefaccion		varchar(20)		not null
);


-----------------CLIENTE PERSONA--------------
create table ClientePersona
(
	Id				int				not null identity(1,1) primary key,
	IdUsuario		int				not null,
	CI				int				not null,
	/*Fotografia	    varchar(1000)	not null,*/
	ApPaterno		varchar(64)		not null,
	ApMaterno		varchar(64)		not null,
	Nombre			varchar(64)		not null,
	Pasaporte		varchar(15)		not null,
	categoria		varchar(64)		not null,
	Telefono		varchar(16)		not null,
	Celular			varchar(16)		not null,
	Email			varchar(64)		not null,
	Direccion		varchar(64)		not null,
	Ciudad			varchar(64)		not null,
	Estado			varchar(64)		not null,
	Pais			varchar(64)		not null,
	Comentarios		varchar(1000)	not null,
	Cumpleanos		datetime		not null,
	foreign key		(idUsuario)			references Usuario(id)
);

------------------CLIENTE EMPRESA----------------
create table ClienteEmpresa
(
	Id			 int				not null identity(1,1) primary key,
	IdUsuario    int				not null,
	Nombre       varchar(64)		not null,
	NIT			 varchar(10)		not null,
	/*Fotografia	 varchar(1000)		not null,*/
	Telefono	 varchar(16)		not null,
	Email		 varchar(64)		not null,
	Direccion    varchar(64)		not null,
	Ciudad       varchar(64)		not null,
	Estado		 varchar(64)		not null,
	Pais         varchar(64)		not null,
	Contacto     varchar(64)		not null,
	foreign key	(idUsuario)			references Usuario(id)
);

-------------------CLIENTE AGENCIA----------------
create table ClienteAgencia
(
	Id			  int				not null identity(1,1) primary key,
	IdUsuario	  int				not null,
	Nombre		  Varchar(64)		not null,
	/*Fotografia	  varchar(1000)		not null,*/
	NIT			  varchar(10)		not null,
	telefono	  varchar(16)		not null,
	email		  varchar(64)		not null,
	direccion	  varchar(64)		not null,
	ciudad		  varchar(64)		not null,
	estado		  varchar(64)		not null,
	pais		  varchar(64)		not null,
	contacto      varchar(64)		not null,
	foreign key	 (idUsuario)			references Usuario(id)
);

/*______________TABLA RESERVA_______________________________________*/
create table Reserva
(
	Id				int				not null identity(1,1) primary key,
	IdHabitacion	int				not null,
	IdUsuario		int	 			not null,
	/*Fotografia	    varchar(1000)	not null,*/
	CantDias		int				not null,
	LLegada			date			not null,
	Salida			date			not null,
	Fecha			datetime		not null,
	TipoPago		varchar(64)		not null,
	/*Estado 			varchar(64)		not null,*//*Pending, Confirmed, Checked in:, Checked Out*/
	foreign key		(IdHabitacion)		references Habitacion (Id),
	foreign key		(idUsuario)			references Usuario(id)
);

/*__________________TABLA SERVICIO__________________________________*/
create table Servicio
(
	Id				int					not null identity(1,1) primary key,
	Categoria		varchar(64)			not null,
	Precio			float				not null,
	Descripcion		varchar(1000)		not null,
	Fecha			datetime			not null
);

/*__________________TABLA USUARIO SERVICIO__________________________________*/
create table ServicioUsuario
(
	IdUsuario		int					not null,
	IdServicio		int					not null,
	foreign key(IdUsuario)				references Usuario(Id),
	foreign key(IdServicio)				references Servicio(Id)
);

/*____________________TABLA MANTENIMIENTO______________________________*/
create table Mantenimiento
(
	Id				int					not null identity(1,1) primary key,
	IdEmpleado		int					not null,
	IdHabitacion	int					not null,
	Tipo			varchar (16)		not null,/*Preventivo, Correctivo, Mejora, Recambios*/
	Inicio			datetime			not null,
	Fin				datetime			not null,
	Material		text				not null,
	Costo			float				not null,
	Decripcion		varchar(1000)		not null,
	foreign key(idEmpleado)				references Empleado(id),
	foreign key(idHabitacion)			references Habitacion(id)
);

/*_______________TABLA FACTURA_________________________________*/
Create table Factura
(
	Id				int					not null identity(1,1) primary key,
	IdUsuario		int					not null,
	IdHabitacion	int					not null,
	IdServicio		int					not null,
	RUT				varchar(50)			not null,
	Ciudad			varchar(64)			not null,
	Nombre			varchar(64)			not null,
	Direccion		varchar(64)			not null,
	Telefono		varchar(16)			not null,
	Descuento		int	   				not null,
	ModoPago		varchar(50)			not null,
	Descripcion		varchar(1000)		not null,
	PrecioTotal		float				not null,
	foreign key(idUsuario)				references Usuario(id),
	foreign key (IdHabitacion)			references Habitacion(Id),		
	foreign key (IdServicio)			references Servicio(Id)
);

delete from Reserva

select id,Numero,Categoria,Estado from Habitacion where (Id=3)

select * from Usuario
select * from Administrador
select * from Empleado
select * from ClienteAgencia
select * from ClientePersona
select * from ClienteEmpresa
select * from Habitacion
select * from Reserva
select * from Servicio
select * from ServicioUsuario
select * from Factura
select * from Mantenimiento

delete from Reserva where Id=11

update Habitacion set Estado='Libre' where id=3

































drop table Usuario				/**/
drop table Administrador		/*usuario*/
drop table Empleado				/*usuario*/
drop table ClienteAgencia		/*cliente*/
drop table ClientePersona		/*cliente*/
drop table ClienteEmpresa		/*cliente*/
drop table Habitacion			/**/
drop table Reserva				/*cliente habitacion*/
drop table Servicio				/*cliente habitacion*/
drop table ServicioUsuario		/*servicio usuario*/
drop table Factura				/*cliente habitacion servicio*/
drop table Mantenimiento		/*empleado habitacion*/













