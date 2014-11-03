CREATE TABLE [dbo].[Подвижной состав]
(
	[ID] [int] IDENTITY(1,1) NOT NULL CONSTRAINT [PK_Подвижной состав] PRIMARY KEY ([ID]),
	[Марка и модель] [nvarchar](50) NOT NULL,
	[Гос.номер] [nvarchar](50) NOT NULL,
	[Гаражный номер] [nvarchar](50) NULL,
	[Тип двигателя] [nvarchar](50) NULL,
	[Год выпуска] [int] NULL,
	[Инвентарный номер] [nvarchar](50) NULL,
	[Вид топлива] [nvarchar](50) NULL,
	[дата окончания страховки] [date] NULL,
)
