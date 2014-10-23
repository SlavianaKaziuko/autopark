﻿CREATE TABLE [dbo].[Путевой лист Грузового авто]
(
	[ID_Путевого листа] [int] IDENTITY(1,1) NOT NULL CONSTRAINT [Пут_груз_ID]  PRIMARY KEY ([ID_Путевого листа]),
	[Номер путевого листа] [int] NOT NULL,
	[Дата путевого листа] [date] NOT NULL,
	[ID_Водителя] [int] NOT NULL  CONSTRAINT [FK_Путевой лист Грузового авто_личный состав] FOREIGN KEY([ID_Водителя]) REFERENCES [dbo].[Личный состав] ([табельный  номер]),
	[ID_Автомобиля] [int] NOT NULL  CONSTRAINT [FK_Путевой лист Грузового авто_Подвижной состав] FOREIGN KEY([ID_Автомобиля]) REFERENCES [dbo].[Подвижной состав] ([ID]),
)
