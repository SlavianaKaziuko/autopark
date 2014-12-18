﻿CREATE PROCEDURE [dbo].[GetMileageGruz]
	@Auto int, 
	@DateAt datetime
AS
SELECT TOP (1) ISNULL([Показания_спидометра_при_возвращении],0) AS  N'Километраж' 
FROM [Путевой лист Грузового авто]
WHERE [ID_Автомобиля] = @Auto
	AND [Дата_Время_возвращения_граф] <= @DateAt
ORDER BY [Дата_Время_возвращения_граф] DESC
RETURN 0