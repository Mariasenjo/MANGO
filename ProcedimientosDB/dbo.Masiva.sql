CREATE PROCEDURE Masiva
	@REFERENCIA varchar (20),
	@FAMILIA varchar(10),
	@COLOR varchar(10),
	@TALLA varchar(3),
	@IMAGEN varchar(50),
	@PRECIO varchar(10),
	@STOCK varchar(10)
AS
BEGIN 
		BULK Insert Productos
		FROM 'C:\Users\maria\source\repos\MANGO\NuevosDatos.csv'
		WITH
(
	FIELDTERMINATOR =';',
	ROWTERMINATOR = '\n'
)
END