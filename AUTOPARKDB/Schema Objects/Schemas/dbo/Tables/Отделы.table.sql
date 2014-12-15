 CREATE TABLE [dbo].[Отделы]
(
 [Код] [int] NOT NULL CONSTRAINT [PK_Отделы] PRIMARY KEY, 
 [Подразделение] nvarchar(20) NULL,
 [Полное название] nvarchar(20) NULL
)
