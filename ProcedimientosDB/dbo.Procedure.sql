CREATE PROCEDURE InsertarEmpleados
@IDNUMEMPLE varchar (10),
@NOMBRE varchar(20),
@APELLIDO varchar(20),
@PASSWORD varchar(10)
AS
BEGIN 
INSERT INTO Empleados(Id_numEmple, nombre, apellido, password)
VALUES (@IDNUMEMPLE, @NOMBRE, @APELLIDO, @PASSWORD)
END
