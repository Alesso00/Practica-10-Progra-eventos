CREATE DATABASE AlumnosPractica#10POE
GO

USE AlumnosPractica#10POE
GO

CREATE TABLE alumno(
	id_alumno INT PRIMARY KEY IDENTITY(1, 1),
	nombre_alumno VARCHAR(20),
	codigo_alumno VARCHAR(20),
	telefono_Alumno VARCHAR(20),
	ciudad_alumno VARCHAR(50)
)
GO

INSERT INTO alumno VALUES ('Williams', 'u20210147', '4578-5487', 'San Miguel')
INSERT INTO alumno VALUES ('Alessandro', 'u20200658', '7777-7777', 'San Miguel')
GO