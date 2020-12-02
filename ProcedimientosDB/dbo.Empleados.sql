CREATE TABLE [dbo].[Empleados] (
    [Id_numEmple] NCHAR(10)        NOT NULL,
    [nombre]      NCHAR (20) NULL,
    [apellido]    NCHAR (20) NULL,
    [password]    NCHAR (10) NULL,
    PRIMARY KEY CLUSTERED ([Id_numEmple] ASC)
);

