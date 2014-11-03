CREATE TABLE [dbo].[Личный состав]
(
	[табельный  номер] [int] NOT NULL CONSTRAINT [PK_личный состав] PRIMARY KEY ([табельный  номер]),
	[ФИО] [nvarchar](50) NOT NULL,
	[номер водительского удостоверения] [nvarchar](50) NOT NULL,
	[классность] [int] NOT NULL,
	[срок действия мед. справки] [date] NOT NULL,
)