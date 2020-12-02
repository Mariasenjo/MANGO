CREATE TABLE [dbo].[Productos] (
    [Id_referencia] NCHAR (20)    NOT NULL,
    [familia]       NCHAR (10)    NULL,
    [color]         NCHAR (10)    NULL,
    [talla]         NCHAR (3)     NULL,
    [imagen]        NVARCHAR (50) NULL,
    [precio]        NCHAR(10)    NULL,
    [stock]         NCHAR(10)           NULL,
    [cantidad]      NCHAR(10)           NULL,
    PRIMARY KEY CLUSTERED ([Id_referencia] ASC)
);

