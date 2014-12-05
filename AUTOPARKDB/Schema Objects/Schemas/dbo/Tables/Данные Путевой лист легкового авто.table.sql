﻿CREATE TABLE [dbo].[Данные Путевой лист легкового авто]
(
	[id_Данных] [int]  IDENTITY(1,1) NOT NULL CONSTRAINT [PK_Путевой лист легкового авто] PRIMARY KEY CLUSTERED,
	[ID_Путевого листа] [int] NULL CONSTRAINT [FK_Данные Путевой лист легкового авто_Путевой лист легкового автомобиля] FOREIGN KEY([ID_Путевого листа]) REFERENCES [dbo].[Путевой лист легкового автомобиля] ([ID_Путевого листа]),
	[Число] date NOT NULL,
	[Время выезда] [time](7) NULL,
	[Время возвращения] [time](7) NULL,
	[Маршрут перевозки откуда] [nvarchar](50) NULL,
	[Маршрут перевозки куда] [nvarchar](50) NULL,
	[Время в наряде] [time](7) NULL,
	[Показания спидометра при выезде] int NULL,
	[Показания спидометра при возвращении] int NULL,
	[Пробег км] [nvarchar](50) NULL,
	[Остаток топлива при выезде] float NULL,
	[Остаток топлива при возвращении] float NULL,
	[Заправлено топлива л] float NULL,
	[Дата и № чека АЗС] [nvarchar](50) NULL,
	[Расход топлива по норме] float NULL,
	[Расход топлива фактически] float NULL,
	[Расход топлива экономия перерасход] float NULL,
	

)
