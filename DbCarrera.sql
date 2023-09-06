Create database CarreraUniversitaria
use CarreraUniversitaria

create table Asignaturas(
id_asignatura int identity(1,1),
nombre_asignatura varchar(30)
Constraint pk_Asignatura primary key (id_asignatura))

create table Carreras(
id_Carrera int identity (1,1),
Titulo varchar (50)
Constraint pk_Carrera primary key (id_Carrera))

Create table Detalle_Carrera(
id_Carrera int,
id_DetCar int,
AnioCursado datetime,
Cuatrimestre int,
id_asignatura int
Constraint pk_DC1 primary key (id_Carrera,id_DetCar),
Constraint fk_DC_Asignatura foreign key (id_asignatura)
references Asignaturas (id_asignatura))

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
END;

create procedure sp_insertarCarrera
@titulo varchar(255),
@id_carrera int OUTPUT
as
begin
insert into Carreras (Titulo) values (@titulo);
set @id_carrera = SCOPE_IDENTITY();
end;

create procedure sp_insertarDetalle
@id_carrera int,
@detalle int,
@anioCursado datetime,
@Cuatrimestre int,
@id_asignatura int
as
begin
insert into Detalle_Carrera(id_Carrera,id_DetCar,AnioCursado,Cuatrimestre,id_asignatura) 
       values (@id_carrera,@detalle,@anioCursado,@Cuatrimestre,@id_asignatura)
end;

create procedure sp_consultar_carrera
@titulo varchar(255)
as
begin
select * from Carreras where Titulo is null or Titulo like '%' + @titulo + '%'
end;

INSERT INTO Asignaturas (nombre_asignatura) VALUES ('Matemáticas');
INSERT INTO Asignaturas (nombre_asignatura) VALUES ('Física');
INSERT INTO Asignaturas (nombre_asignatura) VALUES ('Programación');

INSERT INTO Carreras (Titulo) VALUES ('Ingeniería en Informática');

-- Primer detalle de carrera
INSERT INTO Detalle_Carrera (id_Carrera,id_DetCar,AnioCursado, Cuatrimestre, id_asignatura)
VALUES (1, 1,'2023-09-01', 1, 1);
-- Segundo detalle de carrera
INSERT INTO Detalle_Carrera (id_Carrera,id_DetCar,AnioCursado, Cuatrimestre, id_asignatura)
VALUES (1, 2,'2023-09-01', 2, 2); -- id_asignatura: Física



select * from Carreras
select * from Detalle_Carrera
select * from Asignaturas


