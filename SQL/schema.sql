USE [GD2C2015]
GO

/****** Object:  Schema [JUST_DO_IT]    Script Date: 10/5/2015 3:43:38 PM ******/
CREATE SCHEMA [JUST_DO_IT]
GO

/****** DROP TABLES ******/

if EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'JUST_DO_IT.Paquete'))
	drop table JUST_DO_IT.Paquete

GO

if EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'JUST_DO_IT.Vuelos'))
	drop table JUST_DO_IT.Vuelos

GO

if EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'JUST_DO_IT.Rutas'))
	drop table JUST_DO_IT.Rutas

GO

if EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'JUST_DO_IT.Pasajes'))
	drop table JUST_DO_IT.Pasajes

GO

if EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'JUST_DO_IT.Ciudades'))
	drop table JUST_DO_IT.Ciudades

GO

if EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'JUST_DO_IT.Clientes'))
	drop table JUST_DO_IT.Clientes

GO

/***************************************************/

CREATE TABLE JUST_DO_IT.Ciudades(
	ciu_id int,
	ciu_nombre NVARCHAR(255),
	PRIMARY KEY (ciu_id)
)

GO

CREATE TABLE JUST_DO_IT.Rutas(
	ru_codigo NUMERIC(18,0),
	ru_precio_baseKG NUMERIC(18,2),
	ru_precio_basePasaje NUMERIC(18,2),
	ru_ciu_id_origen INT,
	ru_ciu_id_destino INT,
	ru_tipo_servicio NVARCHAR(255)
	PRIMARY KEY(ru_codigo),
	FOREIGN KEY (ru_ciu_id_origen) REFERENCES JUST_DO_IT.Ciudades,
	FOREIGN KEY (ru_ciu_id_destino) REFERENCES JUST_DO_IT.Ciudades
) 

GO

CREATE TABLE JUST_DO_IT.Clientes(
	cli_dni NUMERIC(18,0),
	cli_nombre NVARCHAR(255),
	cli_apellido NVARCHAR(255),
	cli_direccion NVARCHAR(255),
	cli_telefono NUMERIC(18,0),
	cli_mail NVARCHAR(255),
	cli_fecha_nacimiento DATETIME,
	PRIMARY KEY(cli_dni)
)

GO

CREATE TABLE JUST_DO_IT.Vuelos(
	vue_id NUMERIC(18,0),
	vue_fecha_salida DATETIME, 
	vue_fecha_llegada DATETIME,
	vue_fecha_llegada_estimada DATETIME,
	vue_ru_codigo NUMERIC(18,0),
	PRIMARY KEY (vue_id),
	FOREIGN KEY (vue_ru_codigo) references JUST_DO_IT.Rutas
)

GO

CREATE TABLE JUST_DO_IT.Pasajes(
	pa_codigo NUMERIC(18,0),
	pa_precio NUMERIC(18,0),
	pa_fecha_compra DATETIME,
	pa_cli_pasajero NUMERIC(18,0),
	pa_cli_comprador NUMERIC(18,0),
	PRIMARY KEY (pa_codigo),
	FOREIGN KEY (pa_cli_pasajero) REFERENCES JUST_DO_IT.Clientes,
	FOREIGN KEY (pa_cli_comprador) REFERENCES JUST_DO_IT.Clientes
)

GO

CREATE TABLE JUST_DO_IT.Paquete(
	paq_id NUMERIC(18,0) IDENTITY(1,1),
	paq_codigo NUMERIC(18,0),
	paq_precio NUMERIC(18,2),
	paq_kg NUMERIC(18,0),
	paq_vue_id NUMERIC(18,0),
	PRIMARY KEY(paq_id),
	FOREIGN KEY(paq_vue_id) REFERENCES JUST_DO_IT.Vuelos
)
