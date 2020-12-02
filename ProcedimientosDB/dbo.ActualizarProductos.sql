CREATE PROCEDURE ActualizarProductos
@REFERENCIA varchar (20),
@FAMILIA varchar(10),
@COLOR varchar(10),
@TALLA varchar(3),
@IMAGEN varchar(50),
@PRECIO varchar(10),
@STOCK varchar(10)
AS
BEGIN
UPDATE Productos SET Id_referencia=@REFERENCIA, familia=@FAMILIA, color=@COLOR, talla=@TALLA, imagen=@IMAGEN, precio=@PRECIO, stock=@STOCK
WHERE Id_referencia = @REFERENCIA
END