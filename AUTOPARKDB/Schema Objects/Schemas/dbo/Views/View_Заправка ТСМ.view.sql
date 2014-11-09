CREATE VIEW [dbo].[View_Заправка ТСМ]
AS
SELECT     Дата, [Марка ТСМ] AS Марка_ТСМ, Количество
FROM         dbo.[Заправка ТСМ]

