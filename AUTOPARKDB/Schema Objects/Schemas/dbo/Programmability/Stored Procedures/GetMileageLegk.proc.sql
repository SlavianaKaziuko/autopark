﻿CREATE PROCEDURE [dbo].[GetMileageLegk]
	@Auto int, 
	@DateAt datetime
AS
SELECT TOP (1) ISNULL(d.[Показания спидометра при возвращении],0) AS  N'Километраж' FROM [Данные Путевой лист легкового авто] AS d
JOIN [Путевой лист легкового автомобиля] AS p ON p.[ID_Путевого листа]=d.[ID_Путевого листа]
WHERE p.[ID_Автомобиль] = @Auto
	AND (d.[Число]< @DateAt
	OR (d.[Число]= @DateAt AND d.[Время возвращения] < CONVERT(time, @DateAt)))
ORDER BY d.[Число] DESC
RETURN 0