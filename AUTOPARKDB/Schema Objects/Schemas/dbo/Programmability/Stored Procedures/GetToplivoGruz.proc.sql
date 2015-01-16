CREATE PROCEDURE [dbo].[GetToplivoGruz]
	@Auto int, 
	@ToplivoID int,
	@DateAt datetime
AS
DECLARE @result1 int
DECLARE @result2 int

BEGIN
SELECT TOP (1) @result1 = ISNULL([Остаток_ТСМ1_возвр], 0), @result2 = ISNULL([Остаток_ТСМ2_возвр], 0) 
FROM [Путевой лист Грузового авто]
WHERE [ID_Автомобиля] = @Auto
	AND [Дата_Время_возвращения_факт] <= @DateAt
ORDER BY [Дата_Время_возвращения_факт] DESC

IF (@ToplivoID = 1)
	SELECT ISNULL(@result1, 0) AS  N'Остаток_ТСМ_возвр'
END	
IF (@ToplivoID = 2)
BEGIN
	SELECT ISNULL(@result2, 0)  AS  N'Остаток_ТСМ_возвр'
END
RETURN 0