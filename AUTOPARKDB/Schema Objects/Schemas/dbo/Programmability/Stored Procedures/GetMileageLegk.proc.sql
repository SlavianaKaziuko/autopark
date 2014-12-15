CREATE PROCEDURE [dbo].[GetMileageLegk]
	@Auto int, 
	@DateAt datetime
AS
DECLARE @result int
SELECT TOP (1) @result = d.[Показания спидометра при возвращении] FROM [Данные Путевой лист легкового авто] AS d
JOIN [Путевой лист легкового автомобиля] AS p ON p.[ID_Путевого листа]=d.[ID_Путевого листа]
WHERE p.[ID_Автомобиль] = @Auto
	AND (d.[Число]< @DateAt
	OR (d.[Число]= @DateAt AND d.[Время возвращения] < CONVERT(time, @DateAt)))
ORDER BY d.[Число] DESC
SELECT ISNULL(@result,0) AS  N'Километраж'
RETURN 0