CREATE PROCEDURE [dbo].[GetMileageGruz]
	@Auto int, 
	@DateAt datetime
AS
DECLARE @result int
SELECT TOP (1) @result = d.[Показания спидометра] FROM [Работа водителя и автомобиля] AS d
JOIN [Путевой лист Грузового авто] AS p ON p.[ID_Путевого листа]=d.[ID_Путевого листа]
WHERE p.[ID_Автомобиля] = @Auto
	AND d.[Дата и время по графику] <= @DateAt
ORDER BY d.[Дата и время по графику] DESC
SELECT ISNULL(@result,0) AS  N'Километраж'
RETURN 0