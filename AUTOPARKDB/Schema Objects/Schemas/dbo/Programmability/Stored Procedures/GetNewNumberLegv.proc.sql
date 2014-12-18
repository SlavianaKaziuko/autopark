CREATE PROCEDURE [dbo].[GetNewNumberLegv]
AS
SELECT        ISNULL(MAX([Номер путевого листа]), 0) + 1 AS newID
FROM            [Путевой лист легкового автомобиля]
WHERE        (YEAR([За период с]) = YEAR(GETDATE()))
RETURN 0