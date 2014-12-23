CREATE PROCEDURE [dbo].[GetMileageGruz]
	@Auto int, 
	@DateAt datetime
AS
DECLARE @result int
SELECT TOP (1) @result = [Показания_спидометра_при_возвращении]
FROM [Путевой лист Грузового авто]
WHERE [ID_Автомобиля] = @Auto
	AND [Дата_Время_возвращения_граф] <= @DateAt
ORDER BY [Дата_Время_возвращения_граф] DESC
SELECT ISNULL(@result, 0) AS N'Километраж'
RETURN 0