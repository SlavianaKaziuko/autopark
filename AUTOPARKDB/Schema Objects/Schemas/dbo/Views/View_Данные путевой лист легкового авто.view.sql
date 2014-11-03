CREATE VIEW [dbo].[View_Данные путевой лист легкового авто]
AS
SELECT     Число, [Время выезда] AS Время_выезда, [Время возвращения] AS Время_возвращения, [Время в наряде] AS Время_в_наряде, 
                      [Показания спидометра при выезде] AS Показания_спидометра_при_выезде, 
                      [Показания спидометра при возвращении] AS Показания_спидометра_при_возращении, [Пробег км] AS Пробег_км, 
                      [Остаток топлива при выезде] AS Остаток_топлива_при_выезде, [Остаток топлива при возвращении] AS Остаток_топлива_при_возвращении, 
                      [Заправлено топлива л] AS Заправлено_топливо_л, [Дата и № чека АЗС] AS Дата_и_номер_чека_АЗС, 
                      [Расход топлива по норме] AS Расход_топлива_по_норме, [Расход топлива фактически] AS Расход_топлива_фактически, 
                      [Автомобиль технически исправлен выезд разрешен (подрись штамп уполномоченного лица)] AS Автомобиль_технически_исправлен_выезд_разрешен_подпись_штамп_уполномоченного_лица,
                       [Расход топлива экономия перерасход] AS Расход_топлива_экономия_перерасход, 
                      [Автомобиль технически исправлен принял(подпись водителя)] AS Автомобиль_технически_исправлен_прнял_подпись_водителя, 
                      [При возвращении автомобиль сдал(подпись водителя)] AS При_возвращении_автомобиль_сдал_подпись_водителя, 
                      [При возвращении автомобиль принял(подпись штамп уполномоченного лица)] AS При_возвращении_автомобиль_принял_подпись_штамп_уполномоченного_лица,
                       [Водитель по состоянию здоровья к управлению допущен (подпись штам уполномоченного лица)] AS Водитель_по_состоянию_здоровья_к_управлению_допущен_подпись_штамп_уполномоченного_лица,
                       [Подпись(штамп) лица,ответственного за оформление путевого листа] AS Подпись_штамп_лица_ответственного_за_оформление_путевого_листа
FROM         dbo.[Данные Путевой лист легкового авто]


GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Данные Путевой лист легкового авто"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 125
               Right = 625
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 7530
         Alias = 7545
         Table = 3255
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_Данные путевой лист легкового авто'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_Данные путевой лист легкового авто'

