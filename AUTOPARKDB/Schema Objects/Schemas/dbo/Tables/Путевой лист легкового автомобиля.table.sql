CREATE TABLE [dbo].[Путевой лист легкового автомобиля]
(
	[ID_Путевого листа] [int] IDENTITY(1,1) NOT NULL CONSTRAINT [Пут_легк_ID]  PRIMARY KEY ([ID_Путевого листа]),
	[Номер путевого листа] [nvarchar](10) NULL ,
	[За период с] [datetime] NULL,
	[За период по] [datetime] NULL,
	[ID_Автомобиль] [int] NULL  CONSTRAINT [FK_Путевой лист легкового автомобиля_Подвижной состав] FOREIGN KEY([ID_Автомобиль]) REFERENCES [dbo].[Подвижной состав] ([ID]),
	[ID_Водитель] [int] NULL CONSTRAINT [FK_Путевой лист легкового автомобиля_личный состав] FOREIGN KEY([ID_Водитель]) REFERENCES [dbo].[Личный состав] ([табельный  номер]),
	[ID_Отдела] [int] NULL CONSTRAINT [FK_Путевой лист легкового_id_отдела] FOREIGN KEY ([ID_Отдела]) REFERENCES [Отделы] ([ID])
)
