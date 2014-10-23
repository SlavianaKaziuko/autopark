CREATE TABLE [dbo].[Движение ТСМ]
(
	[ID_Движение ТМЦ] [int] NOT NULL,
	[ID_Путевого листа] [int] NOT NULL,
	[Остаток ТСМ при выезде] [nvarchar](50) NOT NULL,
	[Остаток ТСМ при возвращении] [nvarchar](50) NULL,
)
