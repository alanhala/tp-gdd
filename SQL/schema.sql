USE [GD2C2015]
GO

/****** Object:  Schema [JUST_DO_IT]    Script Date: 10/5/2015 3:43:38 PM ******/
CREATE SCHEMA [JUST_DO_IT]
GO

/******DROP TABLES******/

if EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'JUST_DO_IT.Rol_Funcionalidad'))
	drop table JUST_DO_IT.Rol_Funcionalidad

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

if EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'JUST_DO_IT.Usuarios'))
	drop table JUST_DO_IT.Usuarios

GO

if EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'JUST_DO_IT.Roles'))
	drop table JUST_DO_IT.Roles

GO

if EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'JUST_DO_IT.Vuelos'))
	drop table JUST_DO_IT.Vuelos

GO

if EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'JUST_DO_IT.Rutas'))
	drop table JUST_DO_IT.Rutas

GO

if EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'JUST_DO_IT.Aeronaves'))
	drop table JUST_DO_IT.Aeronaves

GO

if EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'JUST_DO_IT.Ciudades'))
	drop table JUST_DO_IT.Ciudades

GO

if EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'JUST_DO_IT.TiposServicios'))
	drop table JUST_DO_IT.TiposServicios

GO

IF OBJECT_ID('tempdb..#rutasDeLaMaestra') IS NOT NULL
	drop table #rutasDeLaMaestra

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
	PRIMARY KEY(id),
	FOREIGN KEY (ciu_id_origen) REFERENCES JUST_DO_IT.Ciudades,
	FOREIGN KEY (ciu_id_destino) REFERENCES JUST_DO_IT.Ciudades
) 

GO

CREATE TABLE JUST_DO_IT.Roles(
	id NUMERIC(18,0) IDENTITY(1,1),
	nombre varchar(50) NOT NULL,
	PRIMARY KEY (id)
)

GO

CREATE TABLE JUST_DO_IT.Usuarios(
	id NUMERIC(18,0) IDENTITY(1,1),
	username NVARCHAR(255),
	pass NVARCHAR(255), /* Falta encriptar por SHA256 */
	dni NUMERIC(18,0) NOT NULL,
	nombre NVARCHAR(255) NOT NULL,
	apellido NVARCHAR(255) NOT NULL,
	direccion NVARCHAR(255) NOT NULL,
	telefono NUMERIC(18,0) NOT NULL,
	mail NVARCHAR(255) NOT NULL,
	fecha_nacimiento DATETIME NOT NULL,
	rol NUMERIC(18,0) NOT NULL DEFAULT 2,
	PRIMARY KEY(id),
	FOREIGN KEY(rol) REFERENCES JUST_DO_IT.Roles
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

CREATE TABLE JUST_DO_IT.TiposServicios(
	id NUMERIC(18,0) IDENTITY(1,1),
	nombre VARCHAR(255)
)

GO

CREATE TABLE JUST_DO_IT.Butacas(
	id NUMERIC(18,0) IDENTITY(1,1),
	numero INT,
	piso NUMERIC(18,0),
	tipo nvarchar(10) CHECK (tipo in ('Pasillo', 'Ventanilla')),
	PRIMARY KEY (id),
)

GO

CREATE TABLE JUST_DO_IT.Pasajes(
	codigo NUMERIC(18,0),
	precio NUMERIC(18,0) NOT NULL,
	fecha_compra DATETIME NOT NULL,
	vuelo_id NUMERIC(18,0) NOT NULL,
	pasajero NUMERIC(18,0) NOT NULL,
	comprador NUMERIC(18,0) NOT NULL,
	butaca NUMERIC(18,0) NOT NULL
	PRIMARY KEY (codigo)
	FOREIGN KEY (butaca) REFERENCEs JUST_DO_IT.Butacas,
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
	usuario_id NUMERIC(18,0) NOT NULL,
	PRIMARY KEY(id),
	FOREIGN KEY(usuario_id) REFERENCES JUST_DO_IT.Usuarios
)

GO

CREATE TABLE JUST_DO_IT.Aeronaves(
	matricula NVARCHAR(255) UNIQUE NOT NULL,
	modelo NVARCHAR(255) NOT NULL,
	kgs_disponibles NUMERIC(18,0) NOT NULL,
	fabricante NVARCHAR(255) NOT NULL,
	tipo_servicio NVARCHAR(255) CHECK (tipo_servicio in ('Semi-Cama', 'Cama', 'Premium', 'Ejecutivo', 'Común', 'Primera Clase', 'Turista')),
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

CREATE TABLE JUST_DO_IT.Funcionalidades(
	id NUMERIC(18,0) IDENTITY(1,1),
	descripcion NVARCHAR(255),
	PRIMARY KEY (id)
)
GO

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

/******NORMALIZACION******/

INSERT INTO JUST_DO_IT.TiposServicios(nombre) VALUES('Ejecutivo')
INSERT INTO JUST_DO_IT.TiposServicios(nombre) VALUES('Primera Clase') 
INSERT INTO JUST_DO_IT.TiposServicios(nombre) VALUES('Turista')

INSERT INTO JUST_DO_IT.Roles(nombre) VALUES ('Administrativo')

INSERT INTO JUST_DO_IT.Roles(nombre) VALUES ('Cliente')

INSERT INTO JUST_DO_IT.Usuarios(nombre, apellido, dni, direccion, telefono, mail, fecha_nacimiento) 
	SELECT  DISTINCT Cli_Nombre, Cli_Apellido, Cli_Dni, Cli_Dir, Cli_Telefono, Cli_Mail, Cli_Fecha_Nac
		FROM gd_esquema.Maestra

INSERT INTO JUST_DO_IT.Ciudades(nombre)
	SELECT DISTINCT Ruta_Ciudad_Origen AS Ciudad FROM gd_esquema.Maestra
	UNION
	SELECT DISTINCT Ruta_Ciudad_Destino As Ciudad FROM gd_esquema.Maestra

INSERT INTO JUST_DO_IT.Aeronaves(matricula, modelo, kgs_disponibles, fabricante, tipo_servicio)
	SELECT DISTINCT Aeronave_Matricula, Aeronave_Modelo, Aeronave_KG_Disponibles, Aeronave_Fabricante, Tipo_Servicio
		FROM gd_esquema.Maestra

INSERT INTO JUST_DO_IT.Rutas(codigo, precio_baseKG, precio_basePasaje, ciu_id_origen, ciu_id_destino)
	SELECT Ruta_Codigo, MAX(Ruta_Precio_BaseKG), MAX(Ruta_Precio_BasePasaje), ciudades1.id, ciudades2.id
		FROM JUST_DO_IT.Ciudades AS ciudades1, JUST_DO_IT.Ciudades AS ciudades2, gd_esquema.Maestra AS maestra
			WHERE ciudades1.nombre = maestra.Ruta_Ciudad_Origen AND ciudades2.nombre = maestra.Ruta_Ciudad_Destino 
				 GROUP BY Ruta_Codigo, ciudades1.id, ciudades2.id

/******TABLA AUXILIAR******/
CREATE TABLE #rutasDeLaMaestra(
	id NUMERIC(18,0),
	codigo NUMERIC(18,0),
	origen VARCHAR(255),
	destino VARCHAR(255)
)

INSERT INTO #rutasDeLaMaestra(id, codigo, origen, destino)
	SELECT rutas.id AS id, rutas.codigo AS codigo, ciudades1.nombre AS origen, ciudades2.nombre AS destino
		FROM JUST_DO_IT.Rutas AS rutas, JUST_DO_IT.Ciudades AS ciudades1, JUST_DO_IT.Ciudades AS ciudades2
			WHERE rutas.ciu_id_origen = ciudades1.id AND rutas.ciu_id_destino = ciudades2.id
/*************************/

INSERT INTO JUST_DO_IT.Butacas(numero, piso, tipo)
	SELECT DISTINCT Butaca_Nro, Butaca_Piso, Butaca_Tipo 
		FROM gd_esquema.Maestra
			WHERE Butaca_Tipo <> '0'

INSERT INTO JUST_DO_IT.Vuelos(fecha_salida, fecha_llegada, fecha_llegada_estimada, ruta_id)
	SELECT DISTINCT maestra.FechaSalida, maestra.FechaLLegada, maestra.Fecha_LLegada_Estimada, rutas.id
		FROM gd_esquema.Maestra AS maestra, #rutasDeLaMaestra AS rutas
			WHERE maestra.Ruta_Codigo = rutas.codigo AND maestra.Ruta_Ciudad_Origen = rutas.origen AND maestra.Ruta_Ciudad_Destino = rutas.destino

INSERT INTO JUST_DO_IT.Pasajes(codigo, fecha_compra, precio, vuelo_id, pasajero, comprador) 
	SELECT DISTINCT maestra.Pasaje_Codigo, maestra.Pasaje_FechaCompra, maestra.Pasaje_Precio, vuelos.id, usuarios.id, usuarios.id
		FROM gd_esquema.Maestra AS maestra, JUST_DO_IT.Usuarios AS usuarios, JUST_DO_IT.Vuelos AS vuelos, #rutasDeLaMaestra AS rutas
			WHERE maestra.Pasaje_Codigo <> 0 
				AND maestra.Cli_Dni = usuarios.dni AND maestra.Cli_Apellido = usuarios.apellido AND maestra.Cli_Nombre =  usuarios.nombre
				AND maestra.FechaSalida = vuelos.fecha_salida AND maestra.Fecha_LLegada_Estimada = vuelos.fecha_llegada_estimada AND maestra.FechaLLegada = vuelos.fecha_llegada
				AND maestra.Ruta_Codigo = rutas.codigo AND maestra.Ruta_Ciudad_Origen = rutas.origen AND maestra.Ruta_Ciudad_Destino = rutas.destino
				AND vuelos.ruta_id = rutas.id
		
INSERT INTO JUST_DO_IT.Usuarios(username, pass, nombre, apellido, dni, direccion, telefono, mail, fecha_nacimiento, rol)
	VALUES('admin', 'w23e', 'Administrador', 'General', 123456789, 'Sheraton', 44444444, 'admin@admin.com', 1/1/1900, 1)

INSERT INTO JUST_DO_IT.Funcionalidades(descripcion) VALUES ('Puede loguearse')

INSERT INTO JUST_DO_IT.Rol_Funcionalidad(id_funcionalidad, id_rol) VALUES (1, 1)
	
INSERT INTO JUST_DO_IT.Paquete(codigo, fecha_compra, kg, precio, vuelo_id)
	SELECT DISTINCT maestra.Paquete_Codigo, maestra.Paquete_FechaCompra, maestra.Paquete_KG, maestra.Paquete_Precio, vuelos.id
		FROM gd_esquema.Maestra AS maestra, JUST_DO_IT.Vuelos AS vuelos, #rutasDeLaMaestra AS rutas
			WHERE maestra.Paquete_Codigo <> 0 
				AND maestra.FechaSalida = vuelos.fecha_salida AND maestra.Fecha_LLegada_Estimada = vuelos.fecha_llegada_estimada AND maestra.FechaLLegada = vuelos.fecha_llegada
				AND maestra.Ruta_Codigo = rutas.codigo AND maestra.Ruta_Ciudad_Origen = rutas.origen AND maestra.Ruta_Ciudad_Destino = rutas.destino
				AND vuelos.ruta_id = rutas.id

INSERT INTO JUST_DO_IT.Puntos(millas, vencimiento, usuario_id)
	SELECT (pasajes.precio * 0.1), DATEADD(year, 1, vuelos.fecha_salida), pasajes.comprador
		FROM JUST_DO_IT.Pasajes AS pasajes, JUST_DO_IT.Vuelos AS vuelos
			WHERE pasajes.vuelo_id = vuelos.id 


