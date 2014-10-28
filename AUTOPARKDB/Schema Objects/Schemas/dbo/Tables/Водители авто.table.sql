CREATE TABLE [dbo].[Водители авто]
(
	[ID] [int] IDENTITY(1,1) NOT NULL CONSTRAINT [PK_Водители авто] PRIMARY KEY,
	[ID_Водитель] [int] NOT NULL CONSTRAINT [FK_Водители авто_id_водитель] FOREIGN KEY ([ID_Водитель]) REFERENCES [Личный состав] ([табельный  номер]),
	[ID_Авто] [int] NOT NULL CONSTRAINT [FK_Водители авто_id_авто] FOREIGN KEY ([ID_Авто]) REFERENCES [Подвижной состав] ([ID])
 )
