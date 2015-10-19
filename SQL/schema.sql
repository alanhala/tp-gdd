USE [GD2C2015]
GO

/****** Object:  Schema [JUST_DO_IT]    Script Date: 10/5/2015 3:43:38 PM ******/
CREATE SCHEMA [JUST_DO_IT]
GO

/******DROP TABLES******/

if EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'JUST_DO_IT.Rol_Funcionalidad'))
	drop table JUST_DO_IT.Rol_Funcionalidad

GO

if EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'JUST_DO_IT.Roles'))
	drop table JUST_DO_IT.Roles

GO

if EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'JUST_DO_IT.Butacas'))
	drop table JUST_DO_IT.Butacas

GO

if EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'JUST_DO_IT.Funcionalidades'))
	drop table JUST_DO_IT.Funcionalidades

GO

if EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'JUST_DO_IT.Puntos'))
	drop table JUST_DO_IT.Puntos

GO

if EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'JUST_DO_IT.Compras'))
	drop table JUST_DO_IT.Compras

GO

if EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'JUST_DO_IT.Paquete'))
	drop table JUST_DO_IT.Paquete

GO

if EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'JUST_DO_IT.Pasajes'))
	drop table JUST_DO_IT.Pasajes

GO

if EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'JUST_DO_IT.Vuelos'))
	drop table JUST_DO_IT.Vuelos

GO

if EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'JUST_DO_IT.Rutas'))
	drop table JUST_DO_IT.Rutas

GO

if EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'JUST_DO_IT.Usuarios'))
	drop table JUST_DO_IT.Usuarios

GO

if EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'JUST_DO_IT.Aeronaves'))
	drop table JUST_DO_IT.Aeronaves

GO

if EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'JUST_DO_IT.Ciudades'))
	drop table JUST_DO_IT.Ciudades

GO

/******CREACION DE TABLAS******/

CREATE TABLE JUST_DO_IT.Ciudades(
	id NUMERIC(18,0) IDENTITY(1,1),
	nombre NVARCHAR(255) NOT NULL,
	PRIMARY KEY (id)
)

GO

CREATE TABLE JUST_DO_IT.Rutas(
	id NUMERIC(18,0) IDENTITY(1,1),
	codigo NUMERIC(18,0) NOT NULL,
	precio_baseKG NUMERIC(18,2) NOT NULL,
	precio_basePasaje NUMERIC(18,2) NOT NULL,
	ciu_id_origen NUMERIC(18,0) NOT NULL,
	ciu_id_destino NUMERIC(18,0) NOT NULL,
	tipo_servicio NVARCHAR(255),
	PRIMARY KEY(id),
	FOREIGN KEY (ciu_id_origen) REFERENCES JUST_DO_IT.Ciudades,
	FOREIGN KEY (ciu_id_destino) REFERENCES JUST_DO_IT.Ciudades
) 

GO

CREATE TABLE JUST_DO_IT.Usuarios(
	id NUMERIC(18,0) IDENTITY(1,1),
	dni NUMERIC(18,0) NOT NULL,
	nombre NVARCHAR(255) NOT NULL,
	apellido NVARCHAR(255) NOT NULL,
	direccion NVARCHAR(255) NOT NULL,
	telefono NUMERIC(18,0) NOT NULL,
	mail NVARCHAR(255) NOT NULL,
	fecha_nacimiento DATETIME NOT NULL,
	PRIMARY KEY(id)
)

GO

CREATE TABLE JUST_DO_IT.Vuelos(
	id NUMERIC(18,0) IDENTITY(1,1),
	fecha_salida DATETIME NOT NULL, 
	fecha_llegada DATETIME,
	fecha_llegada_estimada DATETIME NOT NULL,
	ruta_id NUMERIC(18,0) NOT NULL,
	PRIMARY KEY (id),
	FOREIGN KEY (ruta_id) references JUST_DO_IT.Rutas
)

GO

CREATE TABLE JUST_DO_IT.Pasajes(
	id NUMERIC(18,0) IDENTITY(1,1),
	codigo NUMERIC(18,0) NOT NULL,
	precio NUMERIC(18,0) NOT NULL,
	fecha_compra DATETIME NOT NULL,
	vuelo_id NUMERIC(18,0) NOT NULL,
	pasajero NUMERIC(18,0) NOT NULL,
	comprador NUMERIC(18,0) NOT NULL
	PRIMARY KEY (id)
	FOREIGN KEY (vuelo_id) REFERENCES JUST_DO_IT.Vuelos,
	FOREIGN KEY (pasajero) REFERENCES JUST_DO_IT.Usuarios,
	FOREIGN KEY (comprador) REFERENCES JUST_DO_IT.Usuarios
)

GO

CREATE TABLE JUST_DO_IT.Paquete(
	id NUMERIC(18,0) IDENTITY(1,1),
	codigo NUMERIC(18,0) NOT NULL,
	precio NUMERIC(18,2) NOT NULL,
	kg NUMERIC(18,0) NOT NULL,
	fecha_compra DATETIME NOT NULL,
	vuelo_id NUMERIC(18,0) NOT NULL,
	PRIMARY KEY(id),
	FOREIGN KEY(vuelo_id) REFERENCES JUST_DO_IT.Vuelos
)

GO

CREATE TABLE JUST_DO_IT.Puntos(
	id NUMERIC(18,0) IDENTITY(1,1),
	millas NUMERIC(18,0) NOT NULL,
	vencimiento DATETIME NOT NULL,
	dni NUMERIC(18,0) NOT NULL,
	PRIMARY KEY(id),
	FOREIGN KEY(dni) REFERENCES JUST_DO_IT.Usuarios
)

GO

CREATE TABLE JUST_DO_IT.Aeronaves(
	matricula NVARCHAR(255) UNIQUE NOT NULL,
	modelo NVARCHAR(255) NOT NULL,
	kgs_disponibles NUMERIC(18,0) NOT NULL,
	fabricante NVARCHAR(255) NOT NULL,
	tipo_servicio NVARCHAR(255) CHECK (tipo_servicio in ('Semi-Cama', 'Cama', 'Premium', 'Ejecutivo', 'Común')),
	fecha_alta DATETIME,
	numero NUMERIC(18,0),
	baja_fuera_servicio BINARY,
	baja_vida_util BINARY,
	fecha_fuera_servicio DATETIME,
	fecha_reinicio_servicio DATETIME,
	fecha_baja_definitiva DATETIME,
	PRIMARY KEY(matricula)
)

GO

CREATE TABLE JUST_DO_IT.Roles(
	id NUMERIC(18,0) IDENTITY(1,1),
	nombre varchar(50) NOT NULL,
	PRIMARY KEY (id)
)

GO

CREATE TABLE JUST_DO_IT.Funcionalidades(
	id NUMERIC(18,0) IDENTITY(1,1),
	descripcion NVARCHAR(255),
	PRIMARY KEY (id)
)

CREATE TABLE JUST_DO_IT.Rol_Funcionalidad(
	id NUMERIC(18,0) IDENTITY(1,1),
	id_rol NUMERIC(18,0) NOT NULL,
	id_funcionalidad NUMERIC(18,0) NOT NULL,
	FOREIGN KEY (id_rol) REFERENCES JUST_DO_IT.Roles,
	FOREIGN KEY (id_funcionalidad) REFERENCES JUST_DO_IT.Funcionalidades
)

GO

CREATE TABLE JUST_DO_IT.Compras(
	id NUMERIC(18,0) IDENTITY(1,1),
	fecha_devolucion DATETIME,
	codigo_pasaje NUMERIC(18,0) NOT NULL,
	motivo_cancelacion NVARCHAR(255),
	PRIMARY KEY (id),
	FOREIGN KEY (codigo_pasaje) REFERENCES JUST_DO_IT.Pasajes
)

GO

CREATE TABLE JUST_DO_IT.Butacas(
	id NUMERIC(18,0) IDENTITY(1,1),
	numero INT,
	piso NUMERIC(18,0),
	tipo nvarchar(10) CHECK (tipo in ('Pasillo', 'Ventanilla')),
	PRIMARY KEY (id)
)

GO

/******NORMALIZACION******/

INSERT INTO JUST_DO_IT.Usuarios(nombre, apellido, dni, direccion, telefono, mail, fecha_nacimiento) 
	SELECT  DISTINCT Cli_Nombre, Cli_Apellido, Cli_Dni, Cli_Dir, Cli_Telefono, Cli_Mail, Cli_Fecha_Nac
		FROM gd_esquema.Maestra

INSERT INTO JUST_DO_IT.Ciudades(nombre)
	SELECT DISTINCT Ruta_Ciudad_Origen AS Ciudad FROM gd_esquema.Maestra
	UNION
	SELECT DISTINCT Ruta_Ciudad_Destino As Ciudad FROM gd_esquema.Maestra

INSERT INTO JUST_DO_IT.Aeronaves(matricula, modelo, kgs_disponibles, fabricante)
	SELECT DISTINCT Aeronave_Matricula, Aeronave_Modelo, Aeronave_KG_Disponibles, Aeronave_Fabricante
		FROM gd_esquema.Maestra

INSERT INTO JUST_DO_IT.Roles(nombre) VALUES ('Administrativo')
INSERT INTO JUST_DO_IT.Roles(nombre) VALUES ('Cliente')

INSERT INTO JUST_DO_IT.Rutas(codigo, precio_baseKG, precio_basePasaje, ciu_id_origen, ciu_id_destino)
	SELECT Ruta_Codigo, MAX(Ruta_Precio_BaseKG), MAX(Ruta_Precio_BasePasaje), ciudades1.id, ciudades2.id
		FROM JUST_DO_IT.Ciudades AS ciudades1, JUST_DO_IT.Ciudades AS ciudades2, gd_esquema.Maestra AS maestra
			WHERE ciudades1.nombre = maestra.Ruta_Ciudad_Origen AND ciudades2.nombre = maestra.Ruta_Ciudad_Destino 
				 GROUP BY Ruta_Codigo, ciudades1.id, ciudades2.id

INSERT INTO JUST_DO_IT.Butacas(numero, piso, tipo)
	SELECT DISTINCT Butaca_Nro, Butaca_Piso, Butaca_Tipo 
		FROM gd_esquema.Maestra
			WHERE Butaca_Tipo <> '0'

INSERT INTO JUST_DO_IT.Vuelos(fecha_salida, fecha_llegada, fecha_llegada_estimada, ruta_id)
	SELECT maestra.FechaSalida, maestra.FechaLLegada, maestra.Fecha_LLegada_Estimada, rutas.id
		FROM gd_esquema.Maestra AS maestra, (SELECT r.id, codigo, ciudades1.nombre AS ciudad_origen, ciudades2.nombre AS ciudad_destino
												FROM JUST_DO_IT.Rutas AS r, JUST_DO_IT.Ciudades AS ciudades1, JUST_DO_IT.Ciudades AS ciudades2
													WHERE r.ciu_id_destino = ciudades2.id AND r.ciu_id_origen = ciudades1.id) AS rutas
			WHERE maestra.Ruta_Codigo = rutas.codigo AND maestra.Ruta_Ciudad_Origen = rutas.ciudad_origen AND maestra.Ruta_Ciudad_Destino = rutas.ciudad_destino

INSERT INTO JUST_DO_IT.Pasajes(codigo, precio, fecha_compra, vuelo_id, pasajero, comprador)
	SELECT maestra.Pasaje_Codigo, maestra.Pasaje_Precio, maestra.Pasaje_FechaCompra, vuelos.id, usuarios.id, usuarios.id
		FROM gd_esquema.Maestra AS maestra, JUST_DO_IT.Usuarios AS usuarios, JUST_DO_IT.Vuelos AS vuelos 
			WHERE maestra.Pasaje_Codigo <> 0 
				AND maestra.Cli_Apellido = usuarios.apellido AND maestra.Cli_Nombre =  usuarios.nombre AND maestra.Cli_Dni = usuarios.dni
				AND maestra.FechaSalida = vuelos.fecha_salida AND maestra.Fecha_LLegada_Estimada = vuelos.fecha_llegada_estimada AND maestra.FechaLLegada = vuelos.fecha_llegada