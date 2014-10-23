CREATE TABLE [dbo].[Личный состав]
(
	[ФИО] [nvarchar](50) NOT NULL,
	[табельный  номер] [int] NOT NULL CONSTRAINT [PK_личный состав] PRIMARY KEY ([табельный  номер]),
	[серия водительского удостоверения] [nvarchar](50) NOT NULL,
	[номер водительского удостоверения] [int] NOT NULL,
	[классность] [int] NOT NULL,
	[срок действия мед. справки] [date] NOT NULL,
)