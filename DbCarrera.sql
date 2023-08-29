Create database Carrera
use Carrera

create table Asignaturas(
id_asignatura int identity(1,1),
nombre_asignatura varchar(30)
Constraint pk_Asignatura primary key (id_asignatura))

Create table Detalle_Carrera(
id_Carrera int,
id_DetCar int identity (1,1),
AnioCursado datetime,
Cuatrimestre int,
id_asignatura int
Constraint pk_DC1 primary key (id_Carrera,id_DetCar),
Constraint fk_DC_Asignatura foreign key (id_asignatura)
references Asignaturas (id_asignatura))

create table Carreras(
id_Carrera int identity (1,1),
Titulo varchar (50)
Constraint pk_Carrera primary key (id_Carrera))

create Procedure sp_ConsultarAsignaturas
AS
BEGIN
    SELECT id_asignatura, nombre_asignatura
    FROM Asignaturas;
END;

create Procedure Sp_ProximaCarrera
@next int OUTPUT
AS
BEGIN
	SET @next = (SELECT MAX(id_carrera)+1  FROM Carreras);
END

INSERT INTO Asignaturas (nombre_asignatura) VALUES ('Matemáticas');
INSERT INTO Asignaturas (nombre_asignatura) VALUES ('Física');
INSERT INTO Asignaturas (nombre_asignatura) VALUES ('Programación');

INSERT INTO Carreras (Titulo) VALUES ('Ingeniería en Informática');

-- Insertar en la tabla Detalle_Carrera
DECLARE @id_carrera INT;
EXEC Sp_ProximaCarrera @next = @id_carrera OUTPUT;
-- Primer detalle de carrera
INSERT INTO Detalle_Carrera (id_Carrera, AnioCursado, Cuatrimestre, id_asignatura)
VALUES (@id_carrera, '2023-09-01', 1, 1);
-- Segundo detalle de carrera
INSERT INTO Detalle_Carrera (id_Carrera, AnioCursado, Cuatrimestre, id_asignatura)
VALUES (@id_carrera, '2023-09-01', 2, 2); -- id_asignatura: Física

