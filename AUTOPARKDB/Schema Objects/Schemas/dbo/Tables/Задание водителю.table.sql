CREATE TABLE [dbo].[Задание водителю]
(
	[id] [int] IDENTITY(1,1) NOT NULL CONSTRAINT [PK_Задание водителю] PRIMARY KEY,
	[ID_Путевого листа] [int] NOT NULL CONSTRAINT [FK_Задание водителю_Путевой лист Грузового авто] FOREIGN KEY([ID_Путевого листа]) REFERENCES [dbo].[Путевой лист Грузового авто] ([ID_Путевого листа]),
	[Заказчик] [nvarchar](50)  NULL,
	[Дата и время прибытия] [datetime] NULL,
	[Дата и время убытия] [datetime] NULL,
	[Пункт отправления] [nvarchar](100)  NULL,
	[Пункт назначения] [nvarchar](100)  NULL,
	[Расстояние км] [float]  NULL,
	[Наименование груза] [nvarchar](100)  NULL,
	[Вес груза т] [float]  NULL,
	[Количество поездок с грузом час] [int]  NULL

 
)
