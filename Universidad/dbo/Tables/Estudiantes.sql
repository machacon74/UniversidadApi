CREATE TABLE [dbo].[Estudiantes] (
    [Id]             INT           IDENTITY (1, 1) NOT NULL,
    [Identificacion] VARCHAR (20)  DEFAULT ('') NOT NULL,
    [Nombres]        VARCHAR (100) DEFAULT ('') NOT NULL,
    [Apellidos]      VARCHAR (100) DEFAULT ('') NOT NULL,
    [Edad]           INT           DEFAULT ((0)) NOT NULL,
    [IdGenero]       SMALLINT      NOT NULL,
    [Curso]          INT           DEFAULT ((0)) NOT NULL,
    [Activo]         BIT           DEFAULT ((0)) NOT NULL,
    CONSTRAINT [PK_ESTUDIANTES] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_ESTUDIANTES_GENEROS] FOREIGN KEY ([IdGenero]) REFERENCES [dbo].[Generos] ([Id])
);



