/*
Script de implementación para C:\USERS\MARIA\SOURCE\REPOS\MANGO\MANGODB.MDF

Una herramienta generó este código.
Los cambios realizados en este archivo podrían generar un comportamiento incorrecto y se perderán si
se vuelve a generar el código.
*/

GO
SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER ON;

SET NUMERIC_ROUNDABORT OFF;


GO
:setvar DatabaseName "C:\USERS\MARIA\SOURCE\REPOS\MANGO\MANGODB.MDF"
:setvar DefaultFilePrefix "C_\USERS\MARIA\SOURCE\REPOS\MANGO\MANGODB.MDF_"
:setvar DefaultDataPath "C:\Users\maria\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDB\"
:setvar DefaultLogPath "C:\Users\maria\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDB\"

GO
:on error exit
GO
/*
Detectar el modo SQLCMD y deshabilitar la ejecución del script si no se admite el modo SQLCMD.
Para volver a habilitar el script después de habilitar el modo SQLCMD, ejecute lo siguiente:
SET NOEXEC OFF; 
*/
:setvar __IsSqlCmdEnabled "True"
GO
IF N'$(__IsSqlCmdEnabled)' NOT LIKE N'True'
    BEGIN
        PRINT N'El modo SQLCMD debe estar habilitado para ejecutar correctamente este script.';
        SET NOEXEC ON;
    END


GO
USE [$(DatabaseName)];


GO

IF (SELECT OBJECT_ID('tempdb..#tmpErrors')) IS NOT NULL DROP TABLE #tmpErrors
GO
CREATE TABLE #tmpErrors (Error int)
GO
SET XACT_ABORT ON
GO
SET TRANSACTION ISOLATION LEVEL READ COMMITTED
GO
BEGIN TRANSACTION
GO
PRINT N'Modificando [dbo].[DeleteProductos]...';


GO

ALTER PROCEDURE DeleteProductos

@Id_referencia varchar

as

delete from Productos where Id_referencia=@Id_referencia
GO
IF @@ERROR <> 0
   AND @@TRANCOUNT > 0
    BEGIN
        ROLLBACK;
    END

IF @@TRANCOUNT = 0
    BEGIN
        INSERT  INTO #tmpErrors (Error)
        VALUES                 (1);
        BEGIN TRANSACTION;
    END


GO
PRINT N'Creando [dbo].[ActualizarProductos]...';


GO
CREATE PROCEDURE ActualizarProductos(
	@Id_referencia varchar (20),
	@familia varchar(10),
	@color varchar(10),
	@talla varchar(3),
	@imagen varchar(50),
	@precio float,
	@stock int)
AS
	
if not exists (SELECT Id_referencia FROM Productos where Id_referencia=@Id_referencia)
insert into Productos(Id_referencia,familia,color,talla,imagen,precio,stock) 
values (@Id_referencia,@familia,@color,@talla,@imagen,@precio,@stock)

else

update Productos set Id_referencia=@Id_referencia, familia=@familia, color=@color, talla=@talla, imagen=@imagen, precio=@precio, stock=@stock
GO
IF @@ERROR <> 0
   AND @@TRANCOUNT > 0
    BEGIN
        ROLLBACK;
    END

IF @@TRANCOUNT = 0
    BEGIN
        INSERT  INTO #tmpErrors (Error)
        VALUES                 (1);
        BEGIN TRANSACTION;
    END


GO

IF EXISTS (SELECT * FROM #tmpErrors) ROLLBACK TRANSACTION
GO
IF @@TRANCOUNT>0 BEGIN
PRINT N'La parte de transacción de la actualización de la base de datos se realizó correctamente.'
COMMIT TRANSACTION
END
ELSE PRINT N'Error de la parte de transacción de la actualización de la base de datos.'
GO
IF (SELECT OBJECT_ID('tempdb..#tmpErrors')) IS NOT NULL DROP TABLE #tmpErrors
GO
GO
PRINT N'Actualización completada.';


GO
