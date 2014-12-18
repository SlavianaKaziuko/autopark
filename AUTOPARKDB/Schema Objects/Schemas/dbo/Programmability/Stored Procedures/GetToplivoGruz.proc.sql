CREATE PROCEDURE [dbo].[GetToplivoGruz]
	@Auto int, 
	@DateAt datetime
AS
SELECT TOP (1) ISNULL([Остаток_ТСМ1_возвр], 0)  AS  N'Остаток_ТСМ1_возвр',
 ISNULL([Остаток_ТСМ2_возвр], 0)  AS  N'Остаток_ТСМ2_возвр'
FROM [Путевой лист Грузового авто]
WHERE [ID_Автомобиля] = @Auto
	AND [Дата_Время_возвращения_граф] <= @DateAt
ORDER BY [Дата_Время_возвращения_граф] DESC
RETURN 0