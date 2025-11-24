CREATE DATABASE COPPEL
USE COPPEL

CREATE TABLE Puesto(
NoPuesto INT PRIMARY KEY NOT NULL,
nom_puesto NVARChar(50) NULL,
desc_puesto NVARCHAR(MAX) NULL,
);

CREATE TABLE centrotrabajo(
centrotrabajo NVARCHAR(6) PRIMARY KEY NOT NULL,
nomcentro NVARCHAR(50) NULL,
ciudad NVARCHAR(50) NULL,
);

CREATE TABLE Empleado(
No_Empleado INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
nombre NVARCHAR (20) NULL,
apellidoP NVARCHAR (20) NULL,
apellidoM NVARCHAR (20) NULL,
fecnac DATE NULL,
RFC NVARCHAR (10) NULL,
centrotrabajo NVARCHAR (6) NULL,
puesto INT NULL,
desc_puesto NVARCHAR(MAX) NULL,
directivo INT NULL,
CONSTRAINT FK_Empleado_Puesto FOREIGN KEY (puesto) REFERENCES Puesto(NoPuesto),
CONSTRAINT FK_Empleado_CentroTrabajo FOREIGN KEY (centrotrabajo) REFERENCES centrotrabajo(centrotrabajo)
);

CREATE TABLE Directivos(
No_Empleado INT PRIMARY KEY NOT NULL,
centrosupervisa NVARCHAR(6) NULL,
prestaciones INT NULL,
CONSTRAINT FK_Directivo_Empleado FOREIGN KEY (No_Empleado) REFERENCES Empleado(No_Empleado),
CONSTRAINT FK_Directivo_Centro FOREIGN KEY (centrosupervisa) REFERENCES centrotrabajo(centrotrabajo)
);

INSERT INTO dbo.centrotrabajo
VALUES
('000201', 'Tiendas Ángel Flores Ropa', 'Culiacán'),
('000202', 'Tiendas Ángel Flores Muebles', 'Culiacán'),
('000203', 'Tiendas Ángel Flores Cajas', 'Culiacán'),
('049001', 'La Primavera Ropa', 'Culiacán'),
('049002', 'La Primavera Muebles', 'Culiacán'),
('049003', 'La Primavera Cajas', 'Culiacán')

SELECT * FROM centrotrabajo

INSERT INTO dbo.Puesto
VALUES
(1, 'Director', 'Encargado de la operación a nivel nacional'),
(2, 'Gerente de Zona', 'A cargo de tiendas en una región'),
(3, 'Gerente de Area', 'Encargado de uno de los tres departamentos generales de la tienda'),
(4, 'Vendedor', 'Empleado del piso de ventas')

SELECT * FROM Puesto

INSERT INTO dbo.Empleado (nombre, apellidoP, apellidoM, fecnac, RFC, centrotrabajo, puesto, desc_puesto, directivo)
VALUES
('Juan', 'Perez', 'Lopez', '1984-07-20', 'PELJ840720', '000201', 1, 'Director', 1),
('Maria', 'Hernandez', 'Ramirez', '1990-04-17', 'HERM900417', '000202', 2, 'Gerente de Zona', 1),
('Jaime', 'Rodriguez', 'Ruiz', '1998-02-16', 'RORJ980216', '000203', 4, 'Vendedor', 0),
('Laura', 'Solis', 'Rios', '1999-03-13', 'SORL990313', '049001', 4, 'Vendedor', 0),
('Manuel', 'Gutierrez', 'Castro', '1988-11-26', 'GUCM881126', '049002', 3, 'Gerente de Area', 1),
('Lucia', 'Ramirez', 'Garcia', '2003-09-29', 'RAGL030929', '049003', 4, 'Vendedor', 0)

SELECT * FROM Empleado

INSERT INTO dbo.Directivos
VALUES
('1', '000201', '1'),
('2', '000202', '1'),
('5', '049002', '1')

SELECT * FROM Directivos
