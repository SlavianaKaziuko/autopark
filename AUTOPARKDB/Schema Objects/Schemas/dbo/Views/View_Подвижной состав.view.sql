﻿CREATE VIEW [dbo].[View_Подвижной состав]
AS
SELECT     [Марка и модель] AS Марка_и_модель, [Гос.номер] AS Гос_номер, [Гаражный номер] AS Гаражный_номер
FROM         dbo.[Подвижной состав]

