﻿CREATE VIEW [dbo].[View_Движение  ТСМ]
AS
SELECT     [Остаток ТСМ при выезде] AS Остаток_ТСМ_при_выезде, [Остаток ТСМ при возвращении] AS Остаток_ТСМ_при_возвращении
FROM         dbo.[Движение ТСМ]

