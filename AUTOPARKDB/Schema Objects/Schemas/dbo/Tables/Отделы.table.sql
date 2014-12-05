CREATE TABLE [dbo].[Отделы]
(
	ID [int] IDENTITY(1,1) NOT NULL CONSTRAINT [PK_Отделы] PRIMARY KEY, 
	[Название отдела] nvarchar(100) NULL,
	[Аббревиатура] nvarchar(20) NULL
)
