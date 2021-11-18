
alter table reservacion modify column costo float;
Alter table hotel modify column telefono varchar(10);
--Modficacion columna de telefono de tablas de telefono 12/11/2021 17:29 - Kevin Duran
Alter table telefono_administrador modify telefono varchar(10);
Alter table telefono_cliente modify telefono varchar(10);
Alter table telefono_huesped modify telefono varchar(10);
Alter table telefono_empleado modify telefono varchar(10);


CREATE TABLE Genero (
	genero varchar(10) NOT NULL,
	Constraint pk_genero PRIMARY KEY(genero),
	Constraint Ch_genero CHECK(genero='Hombre' or genero='Mujer')	
	);

CREATE TABLE Cliente (
  ID_Cliente INT(8) NOT NULL,
  Nombre VARCHAR(30) NULL,
  Paterno VARCHAR(30) NULL,
  Materno VARCHAR(30) NULL,
  Constraint pk_cliente PRIMARY KEY(ID_Cliente)
);

CREATE TABLE Pais (
  ID_Pais INT(3) NOT NULL,
  Pais VARCHAR(30) NULL,
  Constraint pk_pais PRIMARY KEY(ID_Pais)
);

CREATE TABLE Login (
  Cuenta VARCHAR(10) NOT NULL,
  Contraseña VARCHAR(10) NULL,
  Tipo INT(1) NULL,
  Constraint pk_Login PRIMARY KEY(Cuenta)
);

CREATE TABLE Categoria (
  ID_Categoria INT(1) NOT NULL,
  Precio FLOAT(5) NULL,
  No_Camas_M INT(1) NULL,
  No_Camas_I INT(1) NULL,
  Constraint pk_categoria PRIMARY KEY(ID_Categoria)
);

CREATE TABLE Telefono_Cliente (
  Telefono INT(10) NOT NULL,
  ID_Cliente INT(8) NOT NULL,
  Constraint pk_telefono_cliente PRIMARY KEY(Telefono),
  Constraint fk_telefono_cliente FOREIGN KEY(ID_Cliente) REFERENCES Cliente(ID_Cliente)
);

CREATE TABLE Administrador (
  ID_Administrador INT(8) NOT NULL,
  Cuenta VARCHAR(10) NOT NULL,
  Nombre VARCHAR(30) NULL,
  Paterno VARCHAR(30) NULL,
  Materno VARCHAR(30) NULL,
  Constraint pk_administrador PRIMARY KEY(ID_Administrador),
  Constraint fk_administrador_cuenta FOREIGN KEY(Cuenta) REFERENCES Login(Cuenta)
);

CREATE TABLE Empleado (
  ID_Empleado INT(8) NOT NULL,
  Cuenta VARCHAR(10) NOT NULL,
  Nombre VARCHAR(30) NULL,
  Apellido_paterno VARCHAR(30) NULL,
  Apellido_materno VARCHAR(30) NULL,
  Constraint pk_empleado PRIMARY KEY(ID_Empleado),
  Constraint fk_empleado_cuenta FOREIGN KEY(Cuenta) REFERENCES Login(Cuenta)
);

CREATE TABLE Estado (
  ID_Estado INT(3) NOT NULL,
  ID_Pais INT(3) NOT NULL,
  Estado VARCHAR(30) NULL,
  Constraint pk_estado PRIMARY KEY(ID_Estado),
  Constraint fk_estado_pais FOREIGN KEY(ID_Pais) REFERENCES Pais(ID_Pais)
);

CREATE TABLE Correo_Cliente (
  Correo VARCHAR(30) NOT NULL,
  ID_Cliente INT(8) NOT NULL,
  Constraint pk_correo_cliente PRIMARY KEY(Correo),
  Constraint fk_correo_cliente FOREIGN KEY(ID_Cliente) REFERENCES Cliente(ID_Cliente)
);

CREATE TABLE Correo_Empleado (
  Correo VARCHAR(30) NOT NULL,
  ID_Empleado INT(8) NOT NULL,
  Constraint pk_correo_empleado PRIMARY KEY(Correo),
  Constraint fk_correo_empleado FOREIGN KEY(ID_Empleado) REFERENCES Empleado(ID_Empleado)
);

CREATE TABLE Reservacion (
  ID_Reservacion INT(8) NOT NULL,
  ID_Empleado INT(8) NOT NULL,
  ID_Cliente INT(8) NOT NULL,
  Fecha_Entrada DATE NULL,
  Fecha_Salida DATE NULL,
  Fecha_Reservacion DATE NULL,
  Costo FLOAT(5) NULL,
  No_Dias INT(2) NULL,
  No_habitaciones INT(2) NULL,
  Constraint pk_reservaciones PRIMARY KEY(ID_Reservacion),
  Constraint fk_reservaciones_empleado FOREIGN KEY(ID_Empleado) REFERENCES Empleado(ID_Empleado),
  Constraint fk_reservaciones_cliente FOREIGN KEY(ID_Cliente) REFERENCES Cliente(ID_Cliente)
);

CREATE TABLE Huesped (
  ID_Huesped INT(8) NOT NULL,
  ID_Reservacion INT(8) NOT NULL,
  Nombre VARCHAR(30) NULL,
  Apellido_paterno VARCHAR(30) NULL,
  Apellido_materno VARCHAR(30) NULL,
  Edad INT(2) NULL,
  Constraint pk_huesped PRIMARY KEY(ID_Huesped),
  Constraint fk_huesped_reservaciones FOREIGN KEY(ID_Reservacion) REFERENCES Reservacion(ID_Reservacion)
);

CREATE TABLE Telefono_Huesped (
  Telefono INT(10) NOT NULL,
  ID_Huesped INT(8) NOT NULL,
  Constraint pk_telefono_huesped PRIMARY KEY(Telefono),
  Constraint fk_telefono_huesped FOREIGN KEY(ID_Huesped) REFERENCES Huesped(ID_Huesped)
);

CREATE TABLE Telefono_Empleado (
  Telefono INT(10) NOT NULL,
  ID_Empleado INT(8) NOT NULL,
  Constraint pk_telefono_empleado PRIMARY KEY(Telefono),
  Constraint fk_telefono_empleado FOREIGN KEY(ID_Empleado) REFERENCES Empleado(ID_Empleado)
);

CREATE TABLE Telefono_Administrador (
  Telefono INT(10) NOT NULL,
  ID_Administrador INT(8) NOT NULL,
  Constraint pk_telefono_administrador PRIMARY KEY(Telefono),
  Constraint fk_telefono_administrador FOREIGN KEY(ID_Administrador) REFERENCES Administrador(ID_Administrador)
);

CREATE TABLE Ciudad (
  ID_Ciudad INT(3) NOT NULL,
  ID_Estado INT(3) NOT NULL,
  Colonia VARCHAR(30) NULL,
  Constraint pk_ciudad PRIMARY KEY(ID_Ciudad),
  Constraint fk_ciudad_estado FOREIGN KEY(ID_Estado) REFERENCES Estado(ID_Estado)
);

CREATE TABLE Colonia (
  ID_Colonia INT(3) NOT NULL,
  ID_Ciudad INT(3) NOT NULL,
  Nombre VARCHAR(30) NULL,
  Codigo_Postal INT(5) NULL,
  Constraint pk_colonia PRIMARY KEY(ID_Colonia),
  Constraint fk_colonia_ciudad FOREIGN KEY(ID_Ciudad) REFERENCES Ciudad(ID_Ciudad)
);

CREATE TABLE Cancelacion (
  ID_Cancelacion INT(8) NOT NULL,
  ID_Reservacion INT(8) NOT NULL,
  Rembolso FLOAT(5) NULL,
  Fecha_Cancelacion DATE NULL,
  Constraint pk_cancelacion PRIMARY KEY(ID_Cancelacion),
  Constraint fk_cancel_reserv FOREIGN KEY(ID_Reservacion) REFERENCES Reservacion(ID_Reservacion)
);

CREATE TABLE Ubicacion (
  ID_Ubicacion INT(4) NOT NULL,
  ID_Colonia INT(3) NOT NULL,
  Direccion VARCHAR(50) NULL,
  Constraint pk_ubicacion PRIMARY KEY(ID_Ubicacion),
  Constraint fk_ubicacion_colonia FOREIGN KEY(ID_Colonia) REFERENCES Colonia(ID_Colonia)
);

CREATE TABLE Hotel (
  ID_Hotel INT(8) NOT NULL,
  ID_Ubicacion INT(4) NOT NULL,
  Nombre VARCHAR(40) NULL,
  No_Estrellas INT(1) NULL,
  Email VARCHAR(30) NULL,
  Telefono INT(10) NULL,
  Constraint pk_hotel PRIMARY KEY(ID_Hotel),
  Constraint fk_hotel_ubicacion FOREIGN KEY(ID_Ubicacion) REFERENCES Ubicacion(ID_Ubicacion)
);

CREATE TABLE Habitacion (
  No_Habitacion INT(4) NOT NULL,
  ID_Categoria INT(1) NOT NULL,
  ID_Hotel INT(8) NOT NULL,
  Disponibilidad BOOL NULL,
  Capacidad INT(1) NULL,
  Constraint pk_habitacion PRIMARY KEY(No_Habitacion),
  Constraint fk_habitacion_categoria FOREIGN KEY(ID_Categoria) REFERENCES Categoria(ID_Categoria),
  Constraint fk_habitacion_hotel FOREIGN KEY(ID_Hotel) REFERENCES Hotel(ID_Hotel)
);

CREATE TABLE Habitacion_has_Reservacion (
  ID_Reservacion INT(8) NOT NULL,
  No_Habitacion INT(4) NOT NULL,
  Constraint pk_habitacion_reserv PRIMARY KEY(ID_Reservacion, No_Habitacion)
);

