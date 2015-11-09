USE [GD2C2015]
GO

/****** Object:  Schema [JUST_DO_IT]    Script Date: 10/5/2015 3:43:38 PM ******/
/*CREATE SCHEMA [JUST_DO_IT]
GO*/

/******DROP TABLES******/

if EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'JUST_DO_IT.Compras'))
	drop table JUST_DO_IT.Compras

GO

if EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'JUST_DO_IT.Rol_Funcionalidad'))
	drop table JUST_DO_IT.Rol_Funcionalidad

GO

if EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'JUST_DO_IT.Funcionalidades'))
	drop table JUST_DO_IT.Funcionalidades

GO

if EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'JUST_DO_IT.Puntos'))
	drop table JUST_DO_IT.Puntos

GO

if EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'JUST_DO_IT.Paquete'))
	drop table JUST_DO_IT.Paquete

GO

if EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'JUST_DO_IT.Pasajes'))
	drop table JUST_DO_IT.Pasajes

GO

if EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'JUST_DO_IT.Butacas'))
	drop table JUST_DO_IT.Butacas

GO

if EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'JUST_DO_IT.Vuelos'))
	drop table JUST_DO_IT.Vuelos

GO

if EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'JUST_DO_IT.Usuarios'))
	drop table JUST_DO_IT.Usuarios

GO

if EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'JUST_DO_IT.Roles'))
	drop table JUST_DO_IT.Roles

GO

if EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'JUST_DO_IT.Aeronaves'))
	drop table JUST_DO_IT.Aeronaves

GO

if EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'JUST_DO_IT.Rutas'))
	drop table JUST_DO_IT.Rutas

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

IF OBJECT_ID('tempdb..#temporalParaPasaje') IS NOT NULL
	drop table #temporalParaPasaje
GO

IF OBJECT_ID('tempdb..#temporalUsuarios') IS NOT NULL
	drop table #temporalUsuarios
GO

IF OBJECT_ID('tempdb..#temporalPasajes') IS NOT NULL
	drop table #temporalPasajes
GO

IF OBJECT_ID('tempdb..#cantidadDeButacas') IS NOT NULL
	drop table #cantidadDeButacas
GO

IF OBJECT_ID (N'JUST_DO_IT.almacenarRuta') IS NOT NULL
    drop procedure JUST_DO_IT.almacenarRuta;
GO

IF OBJECT_ID (N'JUST_DO_IT.IDCiudad') IS NOT NULL
    drop function JUST_DO_IT.IDCiudad;
GO

IF OBJECT_ID (N'JUST_DO_IT.IDTipoDeServicio') IS NOT NULL
    drop function JUST_DO_IT.IDTipoDeServicio;
GO

IF OBJECT_ID (N'JUST_DO_IT.modificarAeronave') IS NOT NULL
    drop procedure JUST_DO_IT.modificarAeronave;
GO

IF OBJECT_ID (N'JUST_DO_IT.almacenarAeronave') IS NOT NULL
    drop procedure JUST_DO_IT.almacenarAeronave;
GO

IF OBJECT_ID (N'JUST_DO_IT.almacenarFuncionalidad') IS NOT NULL
    drop procedure JUST_DO_IT.almacenarFuncionalidad;
GO

IF OBJECT_ID (N'JUST_DO_IT.cantidadButacas') IS NOT NULL
    drop function JUST_DO_IT.cantidadButacas;
GO

IF OBJECT_ID (N'JUST_DO_IT.vuelosDisponibles') IS NOT NULL
    drop function JUST_DO_IT.vuelosDisponibles;
GO

IF OBJECT_ID (N'JUST_DO_IT.aeronavesDisponibles') IS NOT NULL
	drop function JUST_DO_IT.aeronavesDisponibles;
GO

/******CREACION DE TABLAS******/

CREATE TABLE JUST_DO_IT.Ciudades(
	id NUMERIC(18,0) IDENTITY(1,1),
	nombre NVARCHAR(255) NOT NULL,
	PRIMARY KEY (id)
)

GO

CREATE TABLE JUST_DO_IT.TiposServicios(
	id NUMERIC(18,0) IDENTITY(1,1),
	nombre VARCHAR(255),
	PRIMARY KEY (id)
)

GO

CREATE TABLE JUST_DO_IT.Aeronaves(
	id NUMERIC(18,0) IDENTITY(1,1),
	matricula NVARCHAR(255) UNIQUE NOT NULL,
	modelo NVARCHAR(255) NOT NULL,
	kgs_disponibles NUMERIC(18,0) NOT NULL,
	butacas_totales NUMERIC(18,0) NOT NULL,
	fabricante NVARCHAR(255) NOT NULL,
	tipo_servicio NUMERIC(18,0) NOT NULL,
	fecha_alta DATETIME,
	baja_fuera_servicio BINARY,
	baja_vida_util BINARY,
	fecha_fuera_servicio DATETIME,
	fecha_reinicio_servicio DATETIME,
	fecha_baja_definitiva DATETIME,
	PRIMARY KEY(id),
	FOREIGN KEY (tipo_servicio) REFERENCES JUST_DO_IT.TiposServicios
)

GO

CREATE TABLE JUST_DO_IT.Rutas(
	id NUMERIC(18,0) IDENTITY(1,1),
	codigo NUMERIC(18,0) NOT NULL,
	precio_baseKG NUMERIC(18,2) NOT NULL,
	precio_basePasaje NUMERIC(18,2) NOT NULL,
	ciu_id_origen NUMERIC(18,0) NOT NULL,
	ciu_id_destino NUMERIC(18,0) NOT NULL,
	tipo_servicio NUMERIC(18,0) NOT NULL,
	PRIMARY KEY(id),
	FOREIGN KEY (ciu_id_origen) REFERENCES JUST_DO_IT.Ciudades,
	FOREIGN KEY (ciu_id_destino) REFERENCES JUST_DO_IT.Ciudades,
	FOREIGN KEY (tipo_servicio) REFERENCES JUST_DO_IT.TiposServicios
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
	aeronave_id NUMERIC(18,0) NOT NULL,
	cantidadDisponible NUMERIC(18,0) NOT NULL,
	PRIMARY KEY (id),
	FOREIGN KEY (ruta_id) REFERENCES JUST_DO_IT.Rutas,
	FOREIGN KEY (aeronave_id) REFERENCES JUST_DO_IT.Aeronaves
)

GO

CREATE TABLE JUST_DO_IT.Butacas(
	id NUMERIC(18,0) IDENTITY(1,1),
	numero INT,
	piso NUMERIC(18,0),
	tipo NVARCHAR(10) CHECK (tipo in ('Pasillo', 'Ventanilla')),
	aeronave_id NUMERIC(18,0) NOT NULL,
	PRIMARY KEY (id),
	FOREIGN KEY (aeronave_id) REFERENCES JUST_DO_IT.Aeronaves
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

CREATE TABLE JUST_DO_IT.Funcionalidades(
	id NUMERIC(18,0) IDENTITY(1,1),
	descripcion NVARCHAR(255) NOT NULL UNIQUE,
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

/******TABLA AUXILIAR******/
CREATE TABLE #cantidadDeButacas(
	matricula VARCHAR(255),
	cantidadTotal NUMERIC(18,0)
)

INSERT INTO #cantidadDeButacas(matricula, cantidadTotal)
	SELECT Aeronave_Matricula, COUNT (DISTINCT Butaca_Nro)
		FROM  gd_esquema.Maestra
			WHERE Pasaje_Codigo <> 0
				GROUP BY Aeronave_Matricula

/*************************/



/******NORMALIZACION******/

INSERT INTO JUST_DO_IT.Roles(nombre) VALUES ('Administrativo')

INSERT INTO JUST_DO_IT.Roles(nombre) VALUES ('Cliente')

INSERT INTO JUST_DO_IT.TiposServicios(nombre)
	SELECT DISTINCT Tipo_Servicio
		FROM gd_esquema.Maestra

INSERT INTO JUST_DO_IT.Usuarios(nombre, apellido, dni, direccion, telefono, mail, fecha_nacimiento) 
	SELECT  DISTINCT Cli_Nombre, Cli_Apellido, Cli_Dni, Cli_Dir, Cli_Telefono, Cli_Mail, Cli_Fecha_Nac
		FROM gd_esquema.Maestra

INSERT INTO JUST_DO_IT.Ciudades(nombre)
	SELECT DISTINCT Ruta_Ciudad_Origen AS Ciudad FROM gd_esquema.Maestra
	UNION
	SELECT DISTINCT Ruta_Ciudad_Destino As Ciudad FROM gd_esquema.Maestra

INSERT INTO JUST_DO_IT.Aeronaves(matricula, modelo, kgs_disponibles, butacas_totales, fabricante, tipo_servicio)
	SELECT DISTINCT Aeronave_Matricula, Aeronave_Modelo, Aeronave_KG_Disponibles, cantidadTotal, Aeronave_Fabricante, servicios.id
		FROM gd_esquema.Maestra AS maestra
		INNER JOIN JUST_DO_IT.TiposServicios AS servicios
		ON maestra.Tipo_Servicio = servicios.nombre 
		INNER JOIN #cantidadDeButacas AS cantidad
		ON cantidad.matricula = Aeronave_Matricula

INSERT INTO JUST_DO_IT.Rutas(codigo, precio_baseKG, precio_basePasaje, ciu_id_origen, ciu_id_destino, tipo_servicio)
	SELECT Ruta_Codigo, MAX(Ruta_Precio_BaseKG), MAX(Ruta_Precio_BasePasaje), ciudades1.id, ciudades2.id, servicios.id
		FROM JUST_DO_IT.Ciudades AS ciudades1, JUST_DO_IT.Ciudades AS ciudades2, gd_esquema.Maestra AS maestra, JUST_DO_IT.TiposServicios AS servicios
			WHERE ciudades1.nombre = maestra.Ruta_Ciudad_Origen AND ciudades2.nombre = maestra.Ruta_Ciudad_Destino AND maestra.Tipo_Servicio = servicios.nombre
				 GROUP BY Ruta_Codigo, ciudades1.id, ciudades2.id, servicios.id

/******TABLA AUXILIAR******/
CREATE TABLE #rutasDeLaMaestra(
	id NUMERIC(18,0),
	codigo NUMERIC(18,0),
	origen VARCHAR(255),
	destino VARCHAR(255),
	tipo_servicio VARCHAR(255)
)

INSERT INTO #rutasDeLaMaestra(id, codigo, origen, destino, tipo_servicio)
	SELECT rutas.id AS id, rutas.codigo AS codigo, ciudades1.nombre AS origen, ciudades2.nombre AS destino, servicios.nombre as tipo_servicio
		FROM JUST_DO_IT.Rutas AS rutas, JUST_DO_IT.Ciudades AS ciudades1, JUST_DO_IT.Ciudades AS ciudades2, JUST_DO_IT.TiposServicios AS servicios
			WHERE rutas.ciu_id_origen = ciudades1.id AND rutas.ciu_id_destino = ciudades2.id AND rutas.tipo_servicio = servicios.id
/*************************/

INSERT INTO JUST_DO_IT.Butacas(numero, piso, tipo, aeronave_id)
	SELECT DISTINCT Butaca_Nro, Butaca_Piso, Butaca_Tipo, aeronaves.id
		FROM gd_esquema.Maestra AS maestra, JUST_DO_IT.Aeronaves AS aeronaves
			WHERE maestra.Butaca_Piso <> 0 AND maestra.Aeronave_Matricula = aeronaves.matricula 

INSERT INTO JUST_DO_IT.Vuelos(fecha_salida, fecha_llegada, fecha_llegada_estimada, ruta_id, aeronave_id, cantidadDisponible)
	SELECT DISTINCT maestra.FechaSalida, maestra.FechaLLegada, maestra.Fecha_LLegada_Estimada, rutas.id, aeronaves.id, 0
		FROM gd_esquema.Maestra AS maestra, #rutasDeLaMaestra AS rutas, JUST_DO_IT.Aeronaves AS aeronaves
			WHERE maestra.Ruta_Codigo = rutas.codigo AND maestra.Ruta_Ciudad_Origen = rutas.origen 
				AND maestra.Ruta_Ciudad_Destino = rutas.destino AND maestra.Tipo_Servicio = rutas.tipo_servicio
				AND maestra.Aeronave_Matricula = aeronaves.matricula AND maestra.Aeronave_Fabricante = aeronaves.fabricante

/******TABLAS AUXILIARES PARA EL PASAJE******/
CREATE TABLE #temporalPasajes(
	id NUMERIC(18,0) IDENTITY(1,1),
	codigo NUMERIC (18,0),
	fecha_compra DATETIME,
	precio NUMERIC(18,2), 
	cli_dni NUMERIC(18,0),
	cli_nombre NVARCHAR(255),
	cli_apellido NVARCHAR(255),
	fechaSalida DATETIME,
	fechaLlegadaEstimada DATETIME,
	fechaLlegada DATETIME,
	ciudadOrigen NVARCHAR(255),
	ciudadDestino NVARCHAR(255),
	tipo_servicio NVARCHAR(255),
	aeronave_matricula NVARCHAR(255),
	aeronave_fabricante NVARCHAR(255),
	butaca_nro NUMERIC(18,0),
	butaca_tipo NVARCHAR(255)
)

INSERT INTO #temporalPasajes(codigo, fecha_compra, precio, cli_dni, cli_nombre, cli_apellido,
							fechaSalida, fechaLlegada, fechaLlegadaEstimada, ciudadOrigen, ciudadDestino, tipo_servicio,
							aeronave_matricula, aeronave_fabricante, butaca_nro, butaca_tipo)
	SELECT Pasaje_Codigo, Pasaje_FechaCompra, Pasaje_Precio, Cli_Dni, Cli_Nombre, Cli_Apellido, 
			FechaSalida, FechaLLegada, Fecha_LLegada_Estimada, Ruta_Ciudad_Origen, Ruta_Ciudad_Destino, Tipo_Servicio,
			Aeronave_Matricula, Aeronave_Fabricante,Butaca_Nro, Butaca_Tipo
		FROM gd_esquema.Maestra
		WHERE Pasaje_Codigo <> 0

CREATE TABLE #temporalUsuarios(
	temporalPasaje_id NUMERIC(18,0),
	usuario_id NUMERIC(18,0)
)

INSERT INTO #temporalUsuarios(temporalPasaje_id, usuario_id)
	SELECT temporal.id, usuarios.id
		FROM #temporalPasajes AS temporal, JUST_DO_IT.Usuarios AS usuarios
		WHERE temporal.Cli_Dni = usuarios.dni AND temporal.Cli_Apellido = usuarios.apellido 
		AND temporal.Cli_Nombre =  usuarios.nombre

CREATE TABLE #temporalParaPasaje(
	temporalPasaje_id NUMERIC(18,0),
	codigo NUMERIC(18,0),
	fecha_compra DATETIME,
	precio NUMERIC(18,2),
	vuelo_id NUMERIC(18,0),
	butaca_id NUMERIC(18,0)
)

INSERT INTO #temporalParaPasaje(temporalPasaje_id, codigo, fecha_compra, precio, vuelo_id, butaca_id)
	SELECT temporal.id, temporal.codigo, temporal.fecha_compra, temporal.precio, vuelos.id, butacas.id
		FROM #temporalPasajes AS temporal
		JOIN #rutasDeLaMaestra AS rutas
		ON rutas.origen = temporal.ciudadOrigen AND rutas.destino = temporal.ciudadDestino 
		AND temporal.tipo_servicio = rutas.tipo_servicio 
		JOIN JUST_DO_IT.Aeronaves AS aeronaves
		ON temporal.aeronave_matricula = aeronaves.matricula AND temporal.aeronave_fabricante = aeronaves.fabricante
		JOIN JUST_DO_IT.Vuelos AS vuelos
		ON temporal.fechaLlegada = vuelos.fecha_llegada AND temporal.fechaSalida = vuelos.fecha_salida AND vuelos.aeronave_id = aeronaves.id AND rutas.id = vuelos.ruta_id 
		JOIN JUST_DO_IT.Butacas AS butacas
		ON aeronaves.id = butacas.aeronave_id AND temporal.butaca_tipo = butacas.tipo AND temporal.butaca_nro = butacas.numero
/*************************/

INSERT INTO JUST_DO_IT.Pasajes(codigo, fecha_compra, precio, vuelo_id, pasajero, comprador, butaca) 
	SELECT t1.codigo, t1.fecha_compra, t1.precio, t1.vuelo_id, t2.usuario_id, t2.usuario_id, t1.butaca_id
		FROM #temporalParaPasaje t1
		JOIN #temporalUsuarios t2
		ON t1.temporalPasaje_id = t2.temporalPasaje_id

INSERT INTO JUST_DO_IT.Usuarios(username, pass, nombre, apellido, dni, direccion, telefono, mail, fecha_nacimiento, rol)
	VALUES('admin', 'w23e', 'Administrador', 'General', 123456789, 'Sheraton', 44444444, 'admin@admin.com', 1/1/1900, 1)

INSERT INTO JUST_DO_IT.Funcionalidades(descripcion) VALUES ('Puede loguearse')

INSERT INTO JUST_DO_IT.Rol_Funcionalidad(id_funcionalidad, id_rol) VALUES (1, 1)
	
INSERT INTO JUST_DO_IT.Paquete(codigo, fecha_compra, kg, precio, vuelo_id)
	SELECT DISTINCT maestra.Paquete_Codigo, maestra.Paquete_FechaCompra, maestra.Paquete_KG, maestra.Paquete_Precio, vuelos.id
		FROM gd_esquema.Maestra AS maestra, JUST_DO_IT.Vuelos AS vuelos, #rutasDeLaMaestra AS rutas, JUST_DO_IT.Aeronaves
			WHERE maestra.Paquete_Codigo <> 0 AND maestra.Aeronave_Matricula = aeronaves.matricula
				AND maestra.Ruta_Codigo = rutas.codigo AND maestra.Ruta_Ciudad_Origen = rutas.origen AND maestra.Ruta_Ciudad_Destino = rutas.destino
				AND maestra.FechaSalida = vuelos.fecha_salida AND maestra.Fecha_LLegada_Estimada = vuelos.fecha_llegada_estimada AND maestra.FechaLLegada = vuelos.fecha_llegada
				AND rutas.id = vuelos.ruta_id AND aeronaves.id = vuelos.aeronave_id

INSERT INTO JUST_DO_IT.Puntos(millas, vencimiento, usuario_id)
	SELECT (pasajes.precio * 0.1), DATEADD(year, 1, pasajes.fecha_compra), pasajes.comprador
		FROM JUST_DO_IT.Pasajes AS pasajes

GO

CREATE FUNCTION JUST_DO_IT.IDCiudad(@Ciudad varchar(255))
RETURNS int 
AS
BEGIN
    DECLARE @id int;
    SELECT @id = id
	FROM JUST_DO_IT.Ciudades 
    WHERE nombre LIKE @Ciudad
    RETURN @id;
END

GO

CREATE FUNCTION JUST_DO_IT.IDTipoDeServicio(@Nombre varchar(255))
RETURNS int 
AS
BEGIN
    DECLARE @id int;
    SELECT @id = id
	FROM JUST_DO_IT.TiposServicios 
    WHERE nombre LIKE @Nombre
    RETURN @id;
END

GO

CREATE FUNCTION JUST_DO_IT.vuelosDisponibles(@Origen NUMERIC(18,0), @Destino NUMERIC(18,0), @Salida DATETIME, @Llegada DATETIME)
RETURNS TABLE
AS RETURN
	SELECT vuelos.id AS vuelo, vuelos.cantidadDisponible AS cantidad, aeronaves.kgs_disponibles AS kgsDisponibles, tipos.nombre AS tipoServicio
	FROM JUST_DO_IT.Vuelos vuelos
	JOIN JUST_DO_IT.Rutas rutas
	ON rutas.id = vuelos.ruta_id AND rutas.ciu_id_origen = @Origen AND rutas.ciu_id_destino = @Destino
	JOIN JUST_DO_IT.Aeronaves aeronaves
	ON aeronaves.id = vuelos.aeronave_id
	JOIN JUST_DO_IT.TiposServicios tipos
	ON tipos.id = aeronaves.tipo_servicio 

GO

CREATE PROCEDURE JUST_DO_IT.almacenarRuta(@Codigo NUMERIC(18,0), @PrecioKgs NUMERIC(18,2), @PrecioPasaje NUMERIC(18,2),
	@Origen NUMERIC(18,0), @Destino NUMERIC(18,0), @TipoServicio NUMERIC(18,0))
AS BEGIN
	IF (@PrecioKgs >= 0 AND  @PrecioPasaje >= 0 AND @Origen <> @Destino)
		IF (NOT EXISTS (SELECT * FROM JUST_DO_IT.Rutas 
			WHERE codigo = @Codigo AND precio_baseKG = @PrecioKgs AND precio_basePasaje = @PrecioPasaje 
				AND ciu_id_origen = @Origen AND ciu_id_destino = @Destino AND tipo_servicio = @TipoServicio))
		BEGIN
			INSERT INTO JUST_DO_IT.Rutas(codigo, precio_baseKG, precio_basePasaje, ciu_id_origen, ciu_id_destino, tipo_servicio) 
				VALUES(@Codigo, @PrecioKgs, @PrecioPasaje, @Origen, @Destino, @TipoServicio)
		END ELSE
			RAISERROR('La ruta ingresada ya existe',16,217) WITH SETERROR
	ELSE 
		RAISERROR('No se pudo agregar la ruta',16,217) WITH SETERROR

END

GO

CREATE PROCEDURE JUST_DO_IT.almacenarAeronave(@matricula NVARCHAR(255), @modelo NVARCHAR(255), @fabricante NVARCHAR(255),
	@tipo_servicio NUMERIC(18,0), @kgs_disponibles NUMERIC(18,0))
AS BEGIN
	IF (@kgs_disponibles >= 0)
		IF (NOT EXISTS (SELECT * FROM JUST_DO_IT.Aeronaves
			WHERE matricula = matricula AND modelo = @modelo AND fabricante = @fabricante AND tipo_servicio = @tipo_servicio
				AND kgs_disponibles = @kgs_disponibles))
		BEGIN
			INSERT INTO JUST_DO_IT.Aeronaves(matricula, modelo, fabricante, tipo_servicio, kgs_disponibles)
				VALUES(@matricula, @modelo, @fabricante, @tipo_servicio, @kgs_disponibles)
		END ELSE
			RAISERROR('La aeronave ingresada ya existe',16,217) WITH SETERROR
	ELSE 
		RAISERROR('No se pudo agregar la aeronave',16,217) WITH SETERROR

END 

GO
    

CREATE PROCEDURE JUST_DO_IT.modificarAeronave(@matricula NVARCHAR(255), @modelo NVARCHAR(255), @fabricante NVARCHAR(255),
	@tipo_servicio NUMERIC(18,0), @kgs_disponibles NUMERIC(18,0), @fecha_reinicio_servicio DATETIME)
AS BEGIN
	IF (@kgs_disponibles >= 0)
		BEGIN TRY
			UPDATE JUST_DO_IT.Aeronaves
				SET matricula = @matricula, modelo = @modelo, fabricante = @fabricante, tipo_servicio = @tipo_servicio, 
				kgs_disponibles = @kgs_disponibles,  fecha_reinicio_servicio = @fecha_reinicio_servicio
				
		END TRY
		BEGIN CATCH
			RAISERROR('Ya existe una aeronave con la matricula ingresada',16,217) WITH SETERROR
		END CATCH
	ELSE 
		RAISERROR('La cantidad de kilogramos disponibles no puede ser menor a cero, no se actualizo la aeronave',16,217) WITH SETERROR

END 

GO

CREATE PROCEDURE JUST_DO_IT.almacenarFuncionalidad(@Descripcion VARCHAR(255))
AS BEGIN
		BEGIN TRY
			INSERT INTO JUST_DO_IT.Funcionalidades(descripcion) 
				VALUES(@Descripcion)
		END TRY
		BEGIN CATCH
			RAISERROR('La funcionalidad ingresada ya existe',16,217) WITH SETERROR
		END CATCH
END

GO

CREATE FUNCTION JUST_DO_IT.aeronavesDisponibles(@Salida DATETIME, @LlegadaEstimada DATETIME)
RETURNS TABLE
AS RETURN
	SELECT aeronaves.* 
		FROM JUST_DO_IT.Aeronaves AS aeronaves, (SELECT * FROM JUST_DO_IT.Vuelos WHERE (fecha_salida > @Salida AND fecha_salida < @LlegadaEstimada) OR (fecha_salida < @Salida AND fecha_llegada_estimada > @LlegadaEstimada)) AS aeronaves_no_disponibles
		WHERE aeronaves.id <> aeronaves_no_disponibles.aeronave_id

GO
