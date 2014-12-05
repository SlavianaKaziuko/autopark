﻿/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/


IF NOT EXISTS (SELECT ID FROM [Нормы расхода ГСМ на авто,тракторы])
BEGIN
SET IDENTITY_INSERT [dbo].[Нормы расхода ГСМ на авто,тракторы] on
INSERT INTO [dbo].[Нормы расхода ГСМ на авто,тракторы]
           ([ID] ,[Марка автомобиля],[Вид топлива],[Норма расхода на 100 км летняя 6%] ,
           [Марка двигателя],[Норма на машино час летняя] ,
           [Н-ма расх.масел на 100л р-да топлива моторное,л],[Н-ма расх.масел на 100л р-да трансмиссионное,л] ,[Н-ма расх.масел на 100л р-да топлива специальное,л],[Н-ма расх.масел на 100л р-да топлива пластичные смазки,л])
     VALUES
           (1,N'ГАЗ 3110',N'бен.',9.9,N'ЗМЗ 4062', NULL, 1.7,0.15,0.05,0.1),
           (2,N'УАЗ 3303',N'бен.',15.2,N'ЗМЗ 4218 4 WD', NULL,2.2,0.2,0.05,0.2),
           (3,N'ГАЗ 33021',N'бен.',14.5,N'ЗМЗ 4026,10',NULL ,1.7,0.15,0.05,0.2),
           (4,N'ГАЗ 33021',N'СУГ',19.0,N'ЗМЗ 4026,10',NULL,1.7,0.15,0.05,0.2),
           (5,N'ГАЗ 3302',N'бен',14.7 ,N'ЗМЗ 4063А',NULL ,1.7,0.15,0.05,0.2),
           (6,N'ГАЗ 3302',N'СУГ', 19.0,N'ЗМЗ 4063А',NULL ,1.7,0.15,0.05,0.2),
           (7,N'ГАЗ 3307',N'бен.',23.8,N'ЗМЗ 5130ОМ',NULL,2.1,0.3,0.1,0.25),
           (8,N'ЗИЛ ММЗ 4502',N'бен.',36.3,N'ЗИЛ 375',NULL ,2.0,0.3,0.1,0.2),
           (9,N'ЗИЛ 4331',N'бен.',33.3,N'ЗИЛ 375',NULL ,2.0,0.3,0.1,0.2),
           (10,N'ЗИЛ КС2571А-1(автокран)',N'бен.',38.0,N'ЗИЛ 130',6.1,2.2,0.3,0.1,0.2),
           (11,N'МАЗ 5340 А5-370',N'д/т',28.8,N'ЯМЗ 6582.10',NULL ,2.0,0.3,0.15,0.25),
           (12,N'ГАЗ 33104',N'д/т',14.7,N'Д 245-7Е2',NULL ,1.7,0.15,0.05,0.1),
           (13,N'ГАЗ 331041-317',N'д/т',15.7,N'Д 245-7Е3',NULL ,1.7,0.15,0.05,0.1),
           (14,N'Саманд LX',N'бен.',9.5,N'1.8 I',NULL,0.4,NULL , NULL,NULL),
           (15,N'Беларусь 82.1',N'д/т',NULL,N'Д 243',7.0,4.0,0.5,1.0,0.3),
           (16,N'МТЗ 80*',N'д/т',NULL,N'Д 243',6.5,5.0,0.5,1.0,0.3),
           (17,N'Шкода Октавия**',N'бен',9.5 ,N'1,8/118кВт TFSI-EU4',NULL ,0.4,NULL ,NULL ,NULL ),
           (18,N'Шкода Практик',N'д/т',5.6 ,N'1,4/59кВт TDIPD-EU4',NULL ,0.2,NULL , NULL,NULL ),
           (19,N'Фиат Добло',N'д/т',6.6 ,N'1,3Multijet DPF',NULL,0.1,0.01,NULL,0.1),
           (20,N'РАК 8А',N'д/т',NULL,N'S312C',1.8,5.0,0.5,1.0,0.3);
SET IDENTITY_INSERT [dbo].[Нормы расхода ГСМ на авто,тракторы] OFF
END
           
 go
PRINT(N'[Нормы расхода ГСМ на авто,тракторы]');
go
IF NOT EXISTS (SELECT * FROM [dbo].[Нормы расхода ГСМ на авто,тракторы])
BEGIN
SET IDENTITY_INSERT [dbo].[Нормы расхода ГСМ на авто,тракторы] on
INSERT INTO [dbo].[Нормы расхода ГСМ2 на авто,тракторы]
           (ID ,[Марка автомобиля],[Вид топлива],[Норма расхода на 100 км летняя 6%] ,[Марка двигателя],[Норма на машино час летняя] ,[Н-ма расх.масел на 100л р-да топлива моторное,л],[Н-ма расх.масел на 100л р-да трансмиссионное,л] ,[Н-ма расх.масел на 100л р-да топлива специальное,л],[Н-ма расх.масел на 100л р-да топлива пластичные смазки,л])
     VALUES
           (1,N'КаМАЗ 53212',N'д/т',26.8,N'КаМАЗ 740.10',NULL,2.8,0.4,0.15,0.35),
           (2,N'ЗИЛ 433100',N'д/т',23.2,N'ЗИЛ 645',NULL,2.8,0.4,0.15,0.35),
           (3,N'Д-606',N'д/т',NULL,N'А-41',7.6,5.0,0.5,1.0,0.3),
           (4,N'Нисан 18 NRW9',N'д/т',NULL,N'ISUZU C-240',1.8 ,2.0,0.3,0.6,0.2),
           (5,N'АМЖК-8(мини-трактор)',N'бен.',NULL,N'УД-2',0.5 ,0.5,0.1,0.2,0.1),
           (6,N'ГАЗ 330202',N'д/т',10.3,N'ISF2.8S3129T',NULL,1.0,0.15,0.05,0.1),
           (7,N'Джили SC7',N'бен.',N'8,2',NULL,NULL,NULL,NULL,NULL,NULL);
                      
  SET IDENTITY_INSERT [dbo].[Нормы расхода ГСМ на авто,тракторы] OFF
END         

GO

PRINT(N'[Подвижной состав]');
go          
IF NOT EXISTS (SELECT * FROM [dbo].[Подвижной состав])
BEGIN
SET IDENTITY_INSERT [dbo].[Подвижной состав] on
	INSERT INTO [Подвижной состав] ([ID],[Марка и модель],[Гос.номер],[Гаражный номер],[Тип двигателя],[Год выпуска]
								,[Инвентарный номер],[Вид топлива],[дата окончания страховки],[Тип назначения авто]) 
		VALUES 
		(1,N'Опель',N'2514АА-6',N'15',N'СУО',1996,N'125М',N'бен',N'2015-12-20',N'Л'),
		(2,N'Нисан',N'5476АР-6',N'10',N'АВК',2005,N'1247',N'СУГ',N'2016-01-14',N'Л'),
		(3,N'МАЗ5551',N'2541ОР-6',N'9',N'РПЕН',2004,N'145',N'диз',N'2014-01-02',N'Г'),
		(4,N'КаМаз 5435',N'1254АГ-7',N'21Н',N'КаМаз 740.10',2001,N'КА5678',N'д/т',N'2017-08-02',N'Г'),
		(5,N'Шкода 567',N'5467 РО-7',N'43',N'бен',2009,N'лог8765',N'бен',N'2014-07-05',N'Л')
  SET IDENTITY_INSERT [dbo].[Подвижной состав] OFF
END 
go
PRINT(N'[Личный состав]');
go
           
IF NOT EXISTS (SELECT * FROM [dbo].[Личный состав])
BEGIN
INSERT INTO [Личный состав] 
	([табельный  номер],[Фамилия],[Имя],[Отчество],[номер водительского удостоверения],[классность],[срок действия мед. справки])
		VALUES 
(125,N'Петров',N'Иван', N'Михайлович',N'14587',5,N'2020-04-25'),
(4356,N'Иванов',N'',N'',N'458712',2,N'2015-02-20'),
(5645,N'Пупкин',N'',N'',N'КУ67854',1,N'2017-08-10'),
(6789,N'Васильев', N'Николай',N' Олегович',N'неп65789',5,N'2018-10-25'),
(41256,N'Жуковский',N'',N'',N'765546',2,N'2016-02-10')
END 

go
PRINT(N'[Путевой лист легкового автомобиля]');
go
           
IF NOT EXISTS (SELECT * FROM [dbo].[Путевой лист легкового автомобиля])
BEGIN
SET IDENTITY_INSERT [dbo].[Путевой лист легкового автомобиля] on
	INSERT INTO [Путевой лист легкового автомобиля] ([ID_Путевого листа],[Номер путевого листа],[За период с],[За период по],[ID_Автомобиль],[ID_Водитель]) 
		VALUES 
		(1,7,N'2014-08-01',N'2014-08-12',1,125),
		(2,9,N'2014-09-01',N'2014-09-12',1,4356),
		(3,10,N'2014-10-01',N'2014-10-12',1,5645)
  SET IDENTITY_INSERT [dbo].[Путевой лист легкового автомобиля] OFF
END 
go
PRINT(N'[Путевой лист Грузового авто]');
go
IF NOT EXISTS (SELECT * FROM [dbo].[Путевой лист Грузового авто])
BEGIN
SET IDENTITY_INSERT [dbo].[Путевой лист Грузового авто] on
	INSERT INTO [Путевой лист Грузового авто] ([ID_Путевого листа],[Номер путевого листа],[Дата путевого листа],[ID_Водителя],[ID_Автомобиля]) 
		VALUES 
		(1,1,N'2014-10-11',125,1),
		(2,2,N'2014-10-12',4356,2)
  SET IDENTITY_INSERT [dbo].[Путевой лист Грузового авто] OFF
END 
           
go
PRINT(N'[Данные Путевой лист легкового авто]');
go
IF NOT EXISTS (SELECT * FROM [dbo].[Данные Путевой лист легкового авто])
BEGIN
SET IDENTITY_INSERT [dbo].[Данные Путевой лист легкового авто] on
	INSERT INTO [Данные Путевой лист легкового авто] ([id_Данных],[ID_Путевого листа],[Число],[Время выезда],[Время возвращения],[Время в наряде],[Маршрут перевозки откуда],[Маршрут перевозки куда],
	[Показания спидометра при выезде],[Показания спидометра при возвращении],[Пробег км],[Остаток топлива при выезде],
	[Остаток топлива при возвращении],[Заправлено топлива л],[Дата и № чека АЗС],[Расход топлива по норме],[Расход топлива фактически],[Расход топлива экономия перерасход]) 
		VALUES 
		(1,1,N'2014-10-25',N'08:15AM',N'5:00PM',N'08:45:00',N'Могилев',N'Кричев',158746,158756,10,15,20,100 ,N'20.05.2014',8,25,20),
		(2,1,N'2014-10-26',N'08:15AM',N'5:00PM',N'08:30:00',N'по Могилеву',N'по Могилеву',125500,126000,500,20,25,30, N'20.08.2014',9,24,21),
		(3,2,N'2014-10-27',N'09:15AM',N'5:00PM',N'06:00:00',N'Белыничи',N'Могилев',100300,100500,200,5,5,20, N'10.09.2014',8,8,8)
  SET IDENTITY_INSERT [dbo].[Данные Путевой лист легкового авто] OFF
END 
           
go
PRINT(N'[Задание водителю]');
go           

IF NOT EXISTS (SELECT * FROM [dbo].[Задание водителю])
BEGIN
SET IDENTITY_INSERT [dbo].[Задание водителю] on
	INSERT INTO [Задание водителю] ([id],[ID_Путевого листа],[Заказчик],[Дата и время прибытия],[Дата и время убытия],
	[Пункт отправления],[Пункт назначения],[Расстояние км],[Наименование груза],[Вес груза т],[Количество поездок с грузом час]) 
		VALUES 
		(1,1,N'ОМТС',N'2014-10-05 8:15AM',N'2014-10-05 11:00AM',N'Могилев',N'по городу',125,N'стольной лом',14.0,2),
		(2,2,N'Лифтмаш',N'2014-10-12 11:00AM',N'2014-10-12 10:00AM',N'Могилев',N'по городу',5,N'лифты',20.5,3)
  SET IDENTITY_INSERT [dbo].[Задание водителю] OFF
END 
           
go
PRINT(N'[Работа водителя и автомобиля]');
go 

IF NOT EXISTS (SELECT * FROM [dbo].[Работа водителя и автомобиля])
BEGIN
SET IDENTITY_INSERT [dbo].[Работа водителя и автомобиля] on
	INSERT INTO [Работа водителя и автомобиля] ([ID_работа водителя и авто],[ID_Путевого листа],[Операции],[Показания спидометра],
	[Дата и время по графику],[Дата и время фактически],[Нулевой пробег],[Время работы двигателя час],[Время работы спецоборудования]) 
		VALUES 
		(2,1,N'Возвращение с линии',282500,N'2014-10-05 8:15AM',N'2014-10-05 10:15AM',123588,0.5,6),
		(1,2,N'Выезд на линию',281436,N'2014-12-05 8:15AM',N'2014-12-05 11:15AM',123588,0.4,5)
  SET IDENTITY_INSERT [dbo].[Работа водителя и автомобиля] OFF
END 
           
go
PRINT(N'[Движение ТСМ]');
go 

IF NOT EXISTS (SELECT * FROM [dbo].[Движение ТСМ])
BEGIN
SET IDENTITY_INSERT [dbo].[Движение ТСМ] on
	INSERT INTO [Движение ТСМ] ([Остаток ТСМ при выезде],[Остаток ТСМ при возвращении],[ID_Движение ТМЦ],[ID_Путевого листа]) 
		VALUES 
		(25.4,26.2,1,1),
		(36.0,21.8,2,2)
  SET IDENTITY_INSERT [dbo].[Движение ТСМ] OFF
END 
            
go
PRINT(N'[Заправка ТСМ]');
go 

IF NOT EXISTS (SELECT * FROM [dbo].[Заправка ТСМ])
BEGIN
SET IDENTITY_INSERT [dbo].[Заправка ТСМ] on
	INSERT INTO [Заправка ТСМ] ([ID_Заправка ТСМ],[Дата],[Марка ТСМ],[Количество],[ID_Путевого листа]) 
		VALUES 
		(1,N'2014-10-20',N'ДТ',100,20),
		(2,N'2014-10-21',N'СУГ',50,21)
  SET IDENTITY_INSERT [dbo].[Заправка ТСМ] OFF
END 
  

  go
PRINT(N'[Отделы]');
go 

IF NOT EXISTS (SELECT * FROM [dbo].[Отделы])
BEGIN
SET IDENTITY_INSERT [dbo].[Отделы] on
	INSERT INTO [Отделы] ([ID],[Название отдела],[Аббревиатура]) 
		VALUES 
		(1,N'Погрузки',N'Погр'),
		(2,N'Маркетинга',N'Марк')
  SET IDENTITY_INSERT [dbo].[Отделы] OFF
END 

PRINT(N'[Водители авто]');
go 

IF NOT EXISTS (SELECT * FROM [dbo].[Водители авто])
BEGIN
SET IDENTITY_INSERT [dbo].[Водители авто] on
	INSERT INTO [Водители авто] ([ID],[ID_Водитель],[ID_Авто],[ID_Отдела],[Date]) 
		VALUES 
		(1,125,1,1,N'2014-10-12'),
		(2,4356,2,2,N'2014-10-12')
  SET IDENTITY_INSERT [dbo].[Водители авто] OFF
END 
  