CREATE PROCEDURE [dbo].[GetNewNumberGruz]
AS
SELECT        ISNULL(MAX([Номер путевого листа]), 0) + 1 AS newID
FROM            [Путевой лист Грузового авто]
WHERE        (YEAR([Дата путевого листа]) = YEAR(GETDATE()))
RETURN 0