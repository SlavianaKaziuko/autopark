CREATE TABLE [dbo].[Движение ТСМ]
(
	[ID_Движение ТМЦ] [int]  IDENTITY(1,1) NOT NULL CONSTRAINT [PK_Движение ТСМ_Путевой лист Грузового авто] PRIMARY KEY([ID_Движение ТМЦ]),
	[ID_Путевого листа] [int] NOT NULL  CONSTRAINT [FK_Движение ТСМ_Путевой лист Грузового авто] FOREIGN KEY([ID_Путевого листа]) REFERENCES [dbo].[Путевой лист Грузового авто] ([ID_Путевого листа]),
	[Остаток ТСМ при выезде] [nvarchar](50) NOT NULL,
	[Остаток ТСМ при возвращении] [nvarchar](50) NULL,
)
