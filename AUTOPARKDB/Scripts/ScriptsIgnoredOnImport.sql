
USE [master]
GO
/****** Object:  Database [Путевые листы]    Script Date: 11/02/2014 17:57:35 ******/
CREATE DATABASE [Путевые листы] ON  PRIMARY 
( NAME = N'Путевые листы', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\Путевые листы.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Путевые листы_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\Путевые листы_1.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Путевые листы] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Путевые листы].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Путевые листы] SET ANSI_NULL_DEFAULT ON
GO
ALTER DATABASE [Путевые листы] SET ANSI_NULLS ON
GO
ALTER DATABASE [Путевые листы] SET ANSI_PADDING ON
GO
ALTER DATABASE [Путевые листы] SET ANSI_WARNINGS ON
GO
ALTER DATABASE [Путевые листы] SET ARITHABORT ON
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
ALTER DATABASE [Путевые листы] SET CURSOR_DEFAULT  LOCAL
GO
ALTER DATABASE [Путевые листы] SET CONCAT_NULL_YIELDS_NULL ON
GO
ALTER DATABASE [Путевые листы] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [Путевые листы] SET QUOTED_IDENTIFIER ON
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
ALTER DATABASE [Путевые листы] SET PAGE_VERIFY NONE
GO
ALTER DATABASE [Путевые листы] SET DB_CHAINING OFF
GO
EXEC sys.sp_db_vardecimal_storage_format N'Путевые листы', N'ON'
GO
USE [Путевые листы]
GO
/****** Object:  Table [dbo].[Водители авто]    Script Date: 11/02/2014 17:57:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/****** Object:  Table [dbo].[Данные Путевой лист легкового авто]    Script Date: 11/02/2014 17:57:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/****** Object:  Table [dbo].[Движение ТСМ]    Script Date: 11/02/2014 17:57:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/****** Object:  Table [dbo].[Задание водителю]    Script Date: 11/02/2014 17:57:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/****** Object:  Table [dbo].[Заправка ТСМ]    Script Date: 11/02/2014 17:57:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/****** Object:  Table [dbo].[Личный состав]    Script Date: 11/02/2014 17:57:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/****** Object:  Table [dbo].[Нормы расхода ГСМ на авто,тракторы]    Script Date: 11/02/2014 17:57:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/****** Object:  Table [dbo].[Подвижной состав]    Script Date: 11/02/2014 17:57:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
SET ANSI_PADDING ON
GO
/****** Object:  Table [dbo].[Путевой лист Грузового авто]    Script Date: 11/02/2014 17:57:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/****** Object:  Table [dbo].[Путевой лист легкового автомобиля]    Script Date: 11/02/2014 17:57:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/****** Object:  Table [dbo].[Работа водителя и автомобиля]    Script Date: 11/02/2014 17:57:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/****** Object:  View [dbo].[View_Данные путевой лист легкового авто]    Script Date: 11/02/2014 17:57:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/****** Object:  View [dbo].[View_Движение  ТСМ]    Script Date: 11/02/2014 17:57:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/****** Object:  View [dbo].[View_Задание водителю]    Script Date: 11/02/2014 17:57:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/****** Object:  View [dbo].[View_Заправка ТСМ]    Script Date: 11/02/2014 17:57:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/****** Object:  View [dbo].[View_Личный состав]    Script Date: 11/02/2014 17:57:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/****** Object:  View [dbo].[View_Подвижной состав]    Script Date: 11/02/2014 17:57:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/****** Object:  View [dbo].[View_Работа водителя и авто]    Script Date: 11/02/2014 17:57:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/****** Object:  View [dbo].[View_Работа водителя и автомобиля]    Script Date: 11/02/2014 17:57:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
USE [master]
GO
ALTER DATABASE [Путевые листы] SET  READ_WRITE

GO
