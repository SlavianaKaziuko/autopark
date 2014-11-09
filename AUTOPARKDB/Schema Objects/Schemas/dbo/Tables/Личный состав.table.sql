CREATE TABLE [dbo].[Личный состав]
(
	[табельный  номер] [int] NOT NULL CONSTRAINT [PK_личный состав] PRIMARY KEY ([табельный  номер]),
	[Фамилия] [nvarchar](50) NULL,
	[Имя] [nvarchar](50) NULL,
	[Отчество] [nvarchar](50) NULL,
	[номер водительского удостоверения] [nvarchar](50) NULL,
	[классность] [int]  NULL,
	[срок действия мед. справки] [date] NULL,
)