CREATE TABLE [dbo].[Заправка ТСМ]
(
	[ID_Заправка ТСМ] [int] IDENTITY(1,1) NOT NULL CONSTRAINT [PK_Заправка ТСМ] PRIMARY KEY ([ID_Заправка ТСМ]),
	[Дата] [date] NULL,
	[Марка ТСМ] [nvarchar](50) NULL,
	[Количество] [float] NULL,
	[ID_Путевого листа] [int] NULL,
)
