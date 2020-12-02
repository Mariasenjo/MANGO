CREATE PROCEDURE InsertarProductos
@REFERENCIA varchar (20),
@FAMILIA varchar(10),
@COLOR varchar(10),
@TALLA varchar(3),
@IMAGEN varchar(50),
@PRECIO varchar(10),
@STOCK varchar(10)
AS
BEGIN 
INSERT INTO Productos(Id_referencia, familia, color, talla, imagen, precio, stock)
VALUES (@REFERENCIA, @FAMILIA, @COLOR, @TALLA, @IMAGEN, @PRECIO, @STOCK)
END