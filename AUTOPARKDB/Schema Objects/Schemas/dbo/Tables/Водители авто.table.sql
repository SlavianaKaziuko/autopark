CREATE TABLE [dbo].[Водители авто]
(
	[ID] [int] IDENTITY(1,1) NOT NULL CONSTRAINT [PK_Водители авто] PRIMARY KEY,
	[ID_Водитель] [int] NULL CONSTRAINT [FK_Водители авто_id_водитель] FOREIGN KEY ([ID_Водитель]) REFERENCES [Личный состав] ([табельный  номер]),
	[ID_Авто] [int] NULL CONSTRAINT [FK_Водители авто_id_авто] FOREIGN KEY ([ID_Авто]) REFERENCES [Подвижной состав] ([ID]),
	[ID_Отдела] [int] NULL CONSTRAINT [FK_Водители авто_id_отдела] FOREIGN KEY ([ID_Отдела]) REFERENCES [Отделы] ([ID]),
	[Date] datetime NULL
 )
