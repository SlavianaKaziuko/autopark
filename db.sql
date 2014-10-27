USE [master]
GO
/****** Object:  Database [Путевые листы]    Script Date: 10/27/2014 12:49:25 PM ******/
CREATE DATABASE [Путевые листы]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Путевые листы', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\Путевые листы.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Путевые листы_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\Путевые листы_log.ldf' , SIZE = 4672KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Путевые листы] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Путевые листы].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Путевые листы] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Путевые листы] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Путевые листы] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Путевые листы] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Путевые листы] SET ARITHABORT OFF 
GO
ALTER DATABASE [Путевые листы] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Путевые листы] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [Путевые листы] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Путевые листы] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Путевые листы] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Путевые листы] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Путевые листы] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Путевые листы] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Путевые листы] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Путевые листы] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Путевые листы] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Путевые листы] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Путевые листы] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Путевые листы] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Путевые листы] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Путевые листы] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Путевые листы] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Путевые листы] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Путевые листы] SET RECOVERY FULL 
GO
ALTER DATABASE [Путевые листы] SET  MULTI_USER 
GO
ALTER DATABASE [Путевые листы] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Путевые листы] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Путевые листы] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Путевые листы] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Путевые листы', N'ON'
GO
USE [Путевые листы]
GO
/****** Object:  Table [dbo].[Водители авто]    Script Date: 10/27/2014 12:49:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Водители авто](
	[ID_Водитель] [int] NOT NULL,
	[ID_Авто] [int] NOT NULL,
	[ID] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_Водители авто] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Данные Путевой лист легкового авто]    Script Date: 10/27/2014 12:49:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Данные Путевой лист легкового авто](
	[Число] [nvarchar](50) NOT NULL,
	[Время выезда] [time](7) NOT NULL,
	[Время возвращения] [time](7) NOT NULL,
	[Время в наряде] [time](7) NOT NULL,
	[Показания спидометра при выезде] [nvarchar](50) NOT NULL,
	[Показания спидометра при возвращении] [nvarchar](50) NOT NULL,
	[Пробег км] [nvarchar](50) NOT NULL,
	[Остаток топлива при выезде] [nvarchar](50) NOT NULL,
	[Остаток топлива при возвращении] [nvarchar](50) NOT NULL,
	[Заправлено топлива л] [nvarchar](50) NOT NULL,
	[Дата и № чека АЗС] [nvarchar](50) NULL,
	[Расход топлива по норме] [nvarchar](50) NULL,
	[Расход топлива фактически] [nvarchar](50) NULL,
	[Расход топлива экономия перерасход] [nvarchar](50) NULL,
	[Автомобиль технически исправлен выезд разрешен (подрись штамп уполномоченного лица)] [nvarchar](50) NULL,
	[Автомобиль технически исправлен принял(подпись водителя)] [nvarchar](50) NULL,
	[При возвращении автомобиль сдал(подпись водителя)] [nvarchar](50) NULL,
	[При возвращении автомобиль принял(подпись штамп уполномоченного лица)] [nvarchar](50) NULL,
	[Водитель по состоянию здоровья к управлению допущен (подпись штам уполномоченного лица)] [nvarchar](50) NULL,
	[Подпись(штамп) лица,ответственного за оформление путевого листа] [nvarchar](50) NULL,
	[id_Данных] [int] NOT NULL,
	[ID_Путевого листа] [int] NULL,
 CONSTRAINT [PK_Путевой лист легкового авто] PRIMARY KEY CLUSTERED 
(
	[id_Данных] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Движение ТСМ]    Script Date: 10/27/2014 12:49:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Движение ТСМ](
	[Остаток ТСМ при выезде] [nvarchar](50) NOT NULL,
	[Остаток ТСМ при возвращении] [nvarchar](50) NULL,
	[ID_Движение ТМЦ] [int] NOT NULL,
	[ID_Путевого листа] [int] NOT NULL,
 CONSTRAINT [PK_Движение ТСМ] PRIMARY KEY CLUSTERED 
(
	[ID_Движение ТМЦ] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Задание водителю]    Script Date: 10/27/2014 12:49:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Задание водителю](
	[Заказчик] [nvarchar](50) NOT NULL,
	[Дата и время прибытия] [datetime] NOT NULL,
	[Дата и время убытия] [datetime] NOT NULL,
	[Пункт отправления] [nvarchar](100) NOT NULL,
	[Пункт назначения] [nvarchar](100) NOT NULL,
	[Расстояние км] [float] NOT NULL,
	[Наименование груза] [nvarchar](100) NOT NULL,
	[Вес груза т] [float] NOT NULL,
	[Количество поездок с грузом час] [int] NOT NULL,
	[id] [int] NOT NULL,
	[ID_Путевого листа] [int] NOT NULL,
 CONSTRAINT [PK_Задание водителю] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Заправка ТСМ]    Script Date: 10/27/2014 12:49:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Заправка ТСМ](
	[ID_Заправка ТСМ] [int] IDENTITY(1,1) NOT NULL,
	[Дата] [date] NULL,
	[Марка ТСМ] [nvarchar](50) NULL,
	[Количество] [float] NULL,
	[ID_Путевого листа] [int] NULL,
 CONSTRAINT [PK_Заправка ТСМ] PRIMARY KEY CLUSTERED 
(
	[ID_Заправка ТСМ] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Личный состав]    Script Date: 10/27/2014 12:49:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Личный состав](
	[ФИО] [nvarchar](50) NOT NULL,
	[табельный  номер] [int] NOT NULL,
	[номер водительского удостоверения] [nvarchar](50) NOT NULL,
	[классность] [int] NOT NULL,
	[срок действия мед. справки] [date] NOT NULL,
 CONSTRAINT [PK_личный состав] PRIMARY KEY CLUSTERED 
(
	[табельный  номер] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Нормы расхода ГСМ на авто,тракторы]    Script Date: 10/27/2014 12:49:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Нормы расхода ГСМ на авто,тракторы](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Марка автомобиля] [nvarchar](30) NOT NULL,
	[Вид топлива] [nvarchar](10) NULL,
	[Норма расхода на 100 км летняя 6%] [float] NULL,
	[Марка двигателя] [nvarchar](30) NULL,
	[Норма на машино час летняя] [float] NULL,
	[Н-ма расх.масел на 100л р-да топлива моторное,л] [float] NULL,
	[Н-ма расх.масел на 100л р-да трансмиссионное,л] [float] NULL,
	[Н-ма расх.масел на 100л р-да топлива специальное,л] [float] NULL,
	[Н-ма расх.масел на 100л р-да топлива пластичные смазки,л] [float] NULL,
 CONSTRAINT [PK_Нормы расхода] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Подвижной состав]    Script Date: 10/27/2014 12:49:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Подвижной состав](
	[Марка и модель] [nvarchar](50) NOT NULL,
	[Гос.номер] [nvarchar](50) NOT NULL,
	[Гаражный номер] [nvarchar](50) NULL,
	[Тип двигателя] [nvarchar](50) NULL,
	[Год выпуска] [int] NULL,
	[Инвентарный номер] [nvarchar](50) NULL,
	[Вид топлива] [nvarchar](50) NULL,
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[дата окончания страховки] [date] NULL,
	[Тип назначения авто] [char](1) NULL,
 CONSTRAINT [PK_Подвижной состав] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Путевой лист Грузового авто]    Script Date: 10/27/2014 12:49:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Путевой лист Грузового авто](
	[ID_Путевого листа] [int] IDENTITY(1,1) NOT NULL,
	[Номер путевого листа] [int] NOT NULL,
	[Дата путевого листа] [date] NOT NULL,
	[ID_Водителя] [int] NOT NULL,
	[ID_Автомобиля] [int] NOT NULL,
	[ID_Работа водителя и авто выезд] [int] NULL,
	[ID_Работа водителя и авто возвращение] [int] NULL,
 CONSTRAINT [PK_Путевой лист Грузового авто] PRIMARY KEY CLUSTERED 
(
	[ID_Путевого листа] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Путевой лист легкового автомобиля]    Script Date: 10/27/2014 12:49:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Путевой лист легкового автомобиля](
	[ID_Путевого листа] [int] IDENTITY(1,1) NOT NULL,
	[Номер путевого листа] [nvarchar](10) NULL,
	[За период с] [datetime] NULL,
	[За период по] [datetime] NULL,
	[ID_Автомобиль] [int] NULL,
	[ID_Водитель] [int] NULL,
 CONSTRAINT [PK_Путевой лист легкового автомобиля_ID_Путевого листа] PRIMARY KEY CLUSTERED 
(
	[ID_Путевого листа] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Работа водителя и автомобиля]    Script Date: 10/27/2014 12:49:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Работа водителя и автомобиля](
	[Операции] [nvarchar](50) NOT NULL,
	[Показания спидометра] [int] NULL,
	[Дата и время по графику] [datetime] NULL,
	[Дата и время фактически] [datetime] NULL,
	[Нулевой пробег] [int] NULL,
	[Время работы двигателя час] [int] NULL,
	[Время работы спецоборудования] [int] NULL,
	[ID_работа водителя и авто] [int] NOT NULL,
	[ID_Путевого листа] [int] NULL,
 CONSTRAINT [PK_Работа водителя и автомобиля] PRIMARY KEY CLUSTERED 
(
	[Операции] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  View [dbo].[View_Данные путевой лист легкового авто]    Script Date: 10/27/2014 12:49:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
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
/****** Object:  View [dbo].[View_Движение  ТСМ]    Script Date: 10/27/2014 12:49:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[View_Движение  ТСМ]
AS
SELECT     [Остаток ТСМ при выезде] AS Остаток_ТСМ_при_выезде, [Остаток ТСМ при возвращении] AS Остаток_ТСМ_при_возвращении
FROM         dbo.[Движение ТСМ]

GO
/****** Object:  View [dbo].[View_Задание водителю]    Script Date: 10/27/2014 12:49:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[View_Задание водителю]
AS
SELECT     Заказчик, [Дата и время прибытия] AS Дата_и_время_прибытия, [Дата и время убытия] AS Дата_и_время_убытия, [Пункт отправления] AS Пункт_отправления, 
                      [Пункт назначения] AS Пункт_назначения, [Расстояние км] AS Расстояние_км, [Наименование груза] AS Наименование_груза, [Вес груза т] AS Вес_груза_т, 
                      [Количество поездок с грузом час] AS Количество_поездок_с_грузом_час
FROM         dbo.[Задание водителю]

GO
/****** Object:  View [dbo].[View_Заправка ТСМ]    Script Date: 10/27/2014 12:49:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[View_Заправка ТСМ]
AS
SELECT     Дата, [Марка ТСМ] AS Марка_ТСМ, Количество
FROM         dbo.[Заправка ТСМ]

GO
/****** Object:  View [dbo].[View_Личный состав]    Script Date: 10/27/2014 12:49:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[View_Личный состав]
AS
SELECT     ФИО, [табельный  номер] AS Табельный_номер, классность AS Классность
FROM         dbo.[Личный состав]

GO
/****** Object:  View [dbo].[View_Подвижной состав]    Script Date: 10/27/2014 12:49:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[View_Подвижной состав]
AS
SELECT     [Марка и модель] AS Марка_и_модель, [Гос.номер] AS Гос_номер, [Гаражный номер] AS Гаражный_номер
FROM         dbo.[Подвижной состав]

GO
/****** Object:  View [dbo].[View_Работа водителя и авто]    Script Date: 10/27/2014 12:49:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[View_Работа водителя и авто]
AS
SELECT     Операции, [Показания спидометра] AS Показания_спидометра, [Дата и время по графику] AS Дата_и_время_по_графику, 
                      [Дата и время фактически] AS Дата_и_время_фактически, [Нулевой пробег] AS Нулевой_пробег, 
                      [Время работы двигателя час] AS Время_работы_двигателя_час, [Время работы спецоборудования] AS Время_работы_спецоборудования
FROM         dbo.[Работа водителя и автомобиля]

GO
/****** Object:  View [dbo].[View_Работа водителя и автомобиля]    Script Date: 10/27/2014 12:49:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[View_Работа водителя и автомобиля]
AS
SELECT     Операции, [Показания спидометра] AS Показания_спидометра, [Дата и время по графику] AS Дата_и_время_по_графику, 
                      [Дата и время фактически] AS Дата_и_время_фактически, [Нулевой пробег] AS Нулевой_пробег, 
                      [Время работы двигателя час] AS Время_работы_двигателя_час, [Время работы спецоборудования] AS Время_работы_спецоборудования
FROM         dbo.[Работа водителя и автомобиля]

GO
ALTER TABLE [dbo].[Водители авто]  WITH CHECK ADD  CONSTRAINT [FK_Водители авто_личный состав] FOREIGN KEY([ID_Водитель])
REFERENCES [dbo].[Личный состав] ([табельный  номер])
GO
ALTER TABLE [dbo].[Водители авто] CHECK CONSTRAINT [FK_Водители авто_личный состав]
GO
ALTER TABLE [dbo].[Водители авто]  WITH CHECK ADD  CONSTRAINT [FK_Водители авто_Подвижной состав] FOREIGN KEY([ID_Авто])
REFERENCES [dbo].[Подвижной состав] ([ID])
GO
ALTER TABLE [dbo].[Водители авто] CHECK CONSTRAINT [FK_Водители авто_Подвижной состав]
GO
ALTER TABLE [dbo].[Данные Путевой лист легкового авто]  WITH CHECK ADD  CONSTRAINT [FK_Данные Путевой лист легкового авто_Путевой лист легкового автомобиля] FOREIGN KEY([ID_Путевого листа])
REFERENCES [dbo].[Путевой лист легкового автомобиля] ([ID_Путевого листа])
GO
ALTER TABLE [dbo].[Данные Путевой лист легкового авто] CHECK CONSTRAINT [FK_Данные Путевой лист легкового авто_Путевой лист легкового автомобиля]
GO
ALTER TABLE [dbo].[Движение ТСМ]  WITH CHECK ADD  CONSTRAINT [FK_Движение ТСМ_Путевой лист Грузового авто] FOREIGN KEY([ID_Путевого листа])
REFERENCES [dbo].[Путевой лист Грузового авто] ([ID_Путевого листа])
GO
ALTER TABLE [dbo].[Движение ТСМ] CHECK CONSTRAINT [FK_Движение ТСМ_Путевой лист Грузового авто]
GO
ALTER TABLE [dbo].[Задание водителю]  WITH CHECK ADD  CONSTRAINT [FK_Задание водителю ID_Путевого листа] FOREIGN KEY([ID_Путевого листа])
REFERENCES [dbo].[Путевой лист Грузового авто] ([ID_Путевого листа])
GO
ALTER TABLE [dbo].[Задание водителю] CHECK CONSTRAINT [FK_Задание водителю ID_Путевого листа]
GO
ALTER TABLE [dbo].[Заправка ТСМ]  WITH CHECK ADD  CONSTRAINT [FK_ID_Заправка ТСМ Путевого листа] FOREIGN KEY([ID_Путевого листа])
REFERENCES [dbo].[Путевой лист Грузового авто] ([ID_Путевого листа])
GO
ALTER TABLE [dbo].[Заправка ТСМ] CHECK CONSTRAINT [FK_ID_Заправка ТСМ Путевого листа]
GO
ALTER TABLE [dbo].[Путевой лист Грузового авто]  WITH CHECK ADD  CONSTRAINT [FK_Путевой лист Грузового авто_личный состав] FOREIGN KEY([ID_Водителя])
REFERENCES [dbo].[Личный состав] ([табельный  номер])
GO
ALTER TABLE [dbo].[Путевой лист Грузового авто] CHECK CONSTRAINT [FK_Путевой лист Грузового авто_личный состав]
GO
ALTER TABLE [dbo].[Путевой лист Грузового авто]  WITH CHECK ADD  CONSTRAINT [FK_Путевой лист Грузового авто_Подвижной состав] FOREIGN KEY([ID_Автомобиля])
REFERENCES [dbo].[Подвижной состав] ([ID])
GO
ALTER TABLE [dbo].[Путевой лист Грузового авто] CHECK CONSTRAINT [FK_Путевой лист Грузового авто_Подвижной состав]
GO
ALTER TABLE [dbo].[Путевой лист легкового автомобиля]  WITH CHECK ADD  CONSTRAINT [FK_Путевой лист легкового автомобиля_личный состав] FOREIGN KEY([ID_Водитель])
REFERENCES [dbo].[Личный состав] ([табельный  номер])
GO
ALTER TABLE [dbo].[Путевой лист легкового автомобиля] CHECK CONSTRAINT [FK_Путевой лист легкового автомобиля_личный состав]
GO
ALTER TABLE [dbo].[Путевой лист легкового автомобиля]  WITH CHECK ADD  CONSTRAINT [FK_Путевой лист легкового автомобиля_Подвижной состав] FOREIGN KEY([ID_Автомобиль])
REFERENCES [dbo].[Подвижной состав] ([ID])
GO
ALTER TABLE [dbo].[Путевой лист легкового автомобиля] CHECK CONSTRAINT [FK_Путевой лист легкового автомобиля_Подвижной состав]
GO
ALTER TABLE [dbo].[Работа водителя и автомобиля]  WITH CHECK ADD  CONSTRAINT [FK_Работа водителя и автомобиля_Путевой лист Грузового авто] FOREIGN KEY([ID_Путевого листа])
REFERENCES [dbo].[Путевой лист Грузового авто] ([ID_Путевого листа])
GO
ALTER TABLE [dbo].[Работа водителя и автомобиля] CHECK CONSTRAINT [FK_Работа водителя и автомобиля_Путевой лист Грузового авто]
GO
