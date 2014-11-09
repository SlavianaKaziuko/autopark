﻿CREATE VIEW [dbo].[View_Работа водителя и авто]
AS
SELECT     Операции, [Показания спидометра] AS Показания_спидометра, [Дата и время по графику] AS Дата_и_время_по_графику, 
                      [Дата и время фактически] AS Дата_и_время_фактически, [Нулевой пробег] AS Нулевой_пробег, 
                      [Время работы двигателя час] AS Время_работы_двигателя_час, [Время работы спецоборудования] AS Время_работы_спецоборудования
FROM         dbo.[Работа водителя и автомобиля]


GO