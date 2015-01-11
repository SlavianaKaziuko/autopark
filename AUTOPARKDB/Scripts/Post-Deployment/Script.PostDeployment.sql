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
PRINT @@LANGUAGE
SET DATEFORMAT mdy;

IF NOT EXISTS (SELECT ID FROM [Нормы расхода ГСМ на авто,тракторы])
BEGIN
SET IDENTITY_INSERT [dbo].[Нормы расхода ГСМ на авто,тракторы] on
INSERT INTO [dbo].[Нормы расхода ГСМ на авто,тракторы]
           ([ID] ,[Марка автомобиля],[Вид топлива],[Норма расхода на 100 км летняя 6%] ,
           [Марка двигателя],[Норма на машино час летняя] ,
           [Н-ма расх.масел на 100л р-да топлива моторное,л],[Н-ма расх.масел на 100л р-да трансмиссионное,л] ,[Н-ма расх.масел на 100л р-да топлива специальное,л],[Н-ма расх.масел на 100л р-да топлива пластичные смазки,л])
     VALUES
           (1,N'ГАЗ 3110',N'АИ-92',9.9,N'ЗМЗ 4062', NULL, 1.7,0.15,0.05,0.1),
           (2,N'УАЗ 3303',N'АИ-92',15.2,N'ЗМЗ 4218 4 WD', NULL,2.2,0.2,0.05,0.2),
           (3,N'ГАЗ 33021',N'АИ-92',14.5,N'ЗМЗ 4026,10',NULL ,1.7,0.15,0.05,0.2),
           (4,N'ГАЗ 33021',N'СУГ',19.0,N'ЗМЗ 4026,10',NULL,1.7,0.15,0.05,0.2),
           (5,N'ГАЗ 3302',N'бен',14.7 ,N'ЗМЗ 4063А',NULL ,1.7,0.15,0.05,0.2),
           (6,N'ГАЗ 3302',N'СУГ', 19.0,N'ЗМЗ 4063А',NULL ,1.7,0.15,0.05,0.2),
           (7,N'ГАЗ 3307',N'АИ-92',23.8,N'ЗМЗ 5130ОМ',NULL,2.1,0.3,0.1,0.25),
           (8,N'ЗИЛ ММЗ 4502',N'АИ-92',36.3,N'ЗИЛ 375',NULL ,2.0,0.3,0.1,0.2),
           (9,N'ЗИЛ 4331',N'АИ-92',33.3,N'ЗИЛ 375',NULL ,2.0,0.3,0.1,0.2),
           (10,N'ЗИЛ КС2571А-1(автокран)',N'АИ-92',38.0,N'ЗИЛ 130',6.1,2.2,0.3,0.1,0.2),
           (11,N'МАЗ 5340 А5-370',N'Д/Т',28.8,N'ЯМЗ 6582.10',NULL ,2.0,0.3,0.15,0.25),
           (12,N'ГАЗ 33104',N'Д/Т',14.7,N'Д 245-7Е2',NULL ,1.7,0.15,0.05,0.1),
           (13,N'ГАЗ 331041-317',N'Д/Т',15.7,N'Д 245-7Е3',NULL ,1.7,0.15,0.05,0.1),
           (14,N'Саманд LX',N'АИ-92',9.5,N'1.8 I',NULL,0.4,NULL , NULL,NULL),
           (15,N'Беларусь 82.1',N'Д/Т',NULL,N'Д 243',7.0,4.0,0.5,1.0,0.3),
           (16,N'МТЗ 80*',N'Д/Т',NULL,N'Д 243',6.5,5.0,0.5,1.0,0.3),
           (17,N'Шкода Октавия**',N'бен',9.5 ,N'1,8/118кВт TFSI-EU4',NULL ,0.4,NULL ,NULL ,NULL ),
           (18,N'Шкода Практик',N'Д/Т',5.6 ,N'1,4/59кВт TDIPD-EU4',NULL ,0.2,NULL , NULL,NULL ),
           (19,N'Фиат Добло',N'Д/Т',6.6 ,N'1,3Multijet DPF',NULL,0.1,0.01,NULL,0.1),
           (20,N'РАК 8А',N'Д/Т',NULL,N'S312C',1.8,5.0,0.5,1.0,0.3);
SET IDENTITY_INSERT [dbo].[Нормы расхода ГСМ на авто,тракторы] OFF
END
           
GO
PRINT(N'[Нормы расхода ГСМ на авто,тракторы]');

IF NOT EXISTS (SELECT * FROM [dbo].[Нормы расхода ГСМ на авто,тракторы])
BEGIN
SET IDENTITY_INSERT [dbo].[Нормы расхода ГСМ на авто,тракторы] on
INSERT INTO [dbo].[Нормы расхода ГСМ2 на авто,тракторы]
           (ID ,[Марка автомобиля],[Вид топлива],[Норма расхода на 100 км летняя 6%] ,[Марка двигателя],[Норма на машино час летняя] ,[Н-ма расх.масел на 100л р-да топлива моторное,л],[Н-ма расх.масел на 100л р-да трансмиссионное,л] ,[Н-ма расх.масел на 100л р-да топлива специальное,л],[Н-ма расх.масел на 100л р-да топлива пластичные смазки,л])
     VALUES
           (1,N'КаМАЗ 53212',N'Д/Т',26.8,N'КаМАЗ 740.10',NULL,2.8,0.4,0.15,0.35),
           (2,N'ЗИЛ 433100',N'Д/Т',23.2,N'ЗИЛ 645',NULL,2.8,0.4,0.15,0.35),
           (3,N'Д-606',N'Д/Т',NULL,N'А-41',7.6,5.0,0.5,1.0,0.3),
           (4,N'Нисан 18 NRW9',N'Д/Т',NULL,N'ISUZU C-240',1.8 ,2.0,0.3,0.6,0.2),
           (5,N'АМЖК-8(мини-трактор)',N'АИ-92',NULL,N'УД-2',0.5 ,0.5,0.1,0.2,0.1),
           (6,N'ГАЗ 330202',N'Д/Т',10.3,N'ISF2.8S3129T',NULL,1.0,0.15,0.05,0.1),
           (7,N'Джили SC7',N'АИ-92',N'8,2',NULL,NULL,NULL,NULL,NULL,NULL);
                      
  SET IDENTITY_INSERT [dbo].[Нормы расхода ГСМ на авто,тракторы] OFF
END         

GO

PRINT(N'[Подвижной состав]');

IF NOT EXISTS (SELECT * FROM [dbo].[Подвижной состав])
BEGIN
SET IDENTITY_INSERT [dbo].[Подвижной состав] on
	INSERT INTO [Подвижной состав] ([ID],[Марка и модель],[Гос.номер],[Гаражный номер],[Тип двигателя],[Год выпуска]
								,[Инвентарный номер],[Вид топлива],[Дополнительный вид топлива],[дата окончания страховки],[Тип назначения авто]) 
		VALUES 
		(1,N'Опель',N'2514АА-6',N'15',N'СУО',1996,N'125М',N'АИ-92',N'АИ-92',N'2015-12-20',N'Л'),
		(2,N'Нисан',N'5476АР-6',N'10',N'АВК',2005,N'1247',N'СУГ',N'АИ-92',N'2016-01-14',N'Л'),
		(3,N'МАЗ5551',N'2541ОР-6',N'9',N'РПЕН',2004,N'145',N'Д/Т',N'АИ-92',N'2014-01-02',N'Г'),
		(4,N'КаМаз 5435',N'1254АГ-7',N'21Н',N'КаМаз 740.10',2001,N'КА5678',N'АИ-92',N'Д/Т',N'2017-08-02',N'Г'),
		(5,N'Шкода 567',N'5467 РО-7',N'43',N'АИ-92',2009,N'лог8765',N'АИ-92',N'Д/Т',N'2014-07-05',N'Л')
  SET IDENTITY_INSERT [dbo].[Подвижной состав] OFF
END 
GO
PRINT(N'[Личный состав]');
           
IF NOT EXISTS (SELECT * FROM [dbo].[Личный состав])
BEGIN
INSERT INTO [Личный состав] 
	([табельный  номер],[Фамилия],[Имя],[Отчество],[номер водительского удостоверения],[классность],[срок действия мед. справки])
		VALUES 
(125,N'Петров',N'Иван', N'Михайлович',N'14587',5,N'2020-04-25'),
(4356,N'Иванов',N'Алексей',N'Игнатьевич',N'458712',2,N'2015-02-20'),
(5645,N'Пупкин',N'Василий',N'Петрович',N'КУ67854',1,N'2017-08-10'),
(6789,N'Васильев', N'Николай',N' Олегович',N'неп65789',5,N'2018-10-25'),
(41256,N'Жуковский',N'Антон',N'Генадьевич',N'765546',2,N'2016-02-10')
END
GO
PRINT(N'[Отделы]');

IF NOT EXISTS (SELECT * FROM [dbo].[Отделы])
BEGIN
INSERT INTO [Отделы] 
        ([Полное название],[Подразделение],[Код]) 
		VALUES 
		   (N'Администрация',N'Администрация',0),
           (N'',N'АХО',51),
           (N'База отдыха',N'База отдыха',86),
           (N'',N'БСР',36),
           (N'',N'Группа по КРР',41),
           (N'',N'Здравпункт',82),
           (N'',N'ИС',17),
           (N'',N'ИЦ',21),
           (N'Канцелярия',N'Канцелярия',52),
           (N'',N'МЗЦ',37),
           (N'Несписочный',N'Несписочный',97),
           (N'',N'ОАСУ',7),
           (N'',N'ОБУиО',4),
           (N'Общежитие №1',N'Общежитие №1',80),
           (N'Общежитие №2',N'Общежитие №2',81),
           (N'',N'ОВКиК',46),
           (N'',N'ОВСО',90),
           (N'',N'ОВЭСиМ',94),
           (N'',N'ОГиСО',20),
           (N'',N'ОГК',70),
           (N'',N'ОГМ',48),
           (N'',N'ОГМетролога',49),
           (N'',N'ОГТ',60),
           (N'',N'ОГЭ',47),
           (N'',N'ОК',6),
           (N'',N'ОМТС',45),
           (N'',N'ООСиПС',54),
           (N'',N'ООТ',53),
           (N'',N'ООТиЗ',3),
           (N'',N'ОТД',74),
           (N'',N'Отдел сбыта',95),
           (N'',N'ОТК',16),
           (N'',N'ОУКСиС',19),
           (N'',N'ОЧСиГО',66),
           (N'',N'ПДО',1),
           (N'',N'Первый отдел',40),
           (N'',N'Профком',12),
           (N'',N'ПЭО',2),
           (N'',N'РСУ',26),
           (N'',N'СМЦ',30),
           (N'',N'Столовая',85),
           (N'',N'ФО',5),
           (N'',N'ЦЗЛ',61),
           (N'',N'ЦТ',25),
           (N'',N'ЭМЦ',24),
           (N'',N'Юр.бюро',55)
END 
GO

PRINT(N'[Путевой лист легкового автомобиля]');
           
IF NOT EXISTS (SELECT * FROM [dbo].[Путевой лист легкового автомобиля])
BEGIN
SET IDENTITY_INSERT [dbo].[Путевой лист легкового автомобиля] on
	INSERT INTO [Путевой лист легкового автомобиля] ([ID_Путевого листа],[Номер путевого листа],[Пункт_отправления],[Пункт_назначения],[За период с],[За период по],[ID_Автомобиль],[ID_Водитель],[ID_Отдела]) 
		VALUES 
		(1,7,N'Могилев',N'по городу',N'2014-08-01',N'2014-08-31',1,125,1),
		(2,9,N'Могилев',N'по городу',N'2014-09-01',N'2014-09-30',1,4356,1),
		(3,10,N'Могилев',N'Минск',N'2014-10-01',N'2014-10-12',1,5645,2)
  SET IDENTITY_INSERT [dbo].[Путевой лист легкового автомобиля] OFF
END 
GO

PRINT(N'[Данные Путевой лист легкового авто]');

IF NOT EXISTS (SELECT * FROM [dbo].[Данные Путевой лист легкового авто])
BEGIN
SET IDENTITY_INSERT [dbo].[Данные Путевой лист легкового авто] on
	INSERT INTO [Данные Путевой лист легкового авто] ([id_Данных],[ID_Путевого листа],[Число],[Время выезда],[Время возвращения],[Время в наряде],[Маршрут перевозки откуда],[Маршрут перевозки куда],
	[Показания спидометра при выезде],[Показания спидометра при возвращении],[Пробег км],[Остаток топлива при выезде],
	[Остаток топлива при возвращении],[Заправлено топлива л],[Дата и № чека АЗС],[Расход топлива по норме],[Расход топлива фактически],[Расход топлива экономия перерасход]) 
		VALUES 
		(1,1,N'2014-08-01',N'08:15AM',N'5:00PM',N'08:45:00',N'Могилев',N'Кричев',125490,125500,10,15,20,100 ,N'20.05.2014',8,25,20),
		(2,1,N'2014-08-12',N'08:15AM',N'5:00PM',N'08:30:00',N'по Могилеву',N'по Могилеву',125500,126000,500,20,25,30, N'20.08.2014',9,24,21),
		(3,2,N'2014-09-01',N'09:15AM',N'5:00PM',N'06:00:00',N'Белыничи',N'Могилев',100300,100500,200,5,5,20, N'10.09.2014',8,8,8)
  SET IDENTITY_INSERT [dbo].[Данные Путевой лист легкового авто] OFF
END 
GO

PRINT(N'[Путевой лист Грузового авто]');

IF NOT EXISTS (SELECT * FROM [dbo].[Путевой лист Грузового авто])
BEGIN
SET IDENTITY_INSERT [dbo].[Путевой лист Грузового авто] on
	INSERT INTO [Путевой лист Грузового авто] 
	([ID_Путевого листа],[Номер путевого листа],[Пункт_отправления],[Пункт_назначения],[Дата путевого листа],[ID_Водителя],[ID_Автомобиля],[ID_Отдела],
	[Показания_спидометра_при_выезде],[Показания_спидометра_при_возвращении],[Дата_Время_выезда_граф],
	[Дата_Время_выезда_факт],[Дата_Время_возвращения_граф],[Дата_Время_возвращения_факт],
	[Нулевой_пробег_выезд],[Нулевой_пробег_возвр],[Время_работы_двигателя_выезд],
	[Время_работы_двигателя_возвр],[Время_работы_спецоборудования_выезд],[Время_работы_спецоборудования_возвр],
	[Остаток_ТСМ1_выезд],[Остаток_ТСМ1_возвр],[Остаток_ТСМ2_выезд],[Остаток_ТСМ2_возвр])
	VALUES 
		(1,1,N'Могилев',N'по городу',N'2014-10-11',125,3,1,281436,282500,N'2014-12-05 8:15AM',N'2014-10-05 10:15AM',N'2014-10-05 8:15AM',N'2014-12-05 11:15AM',123588,123588,0.4,0.5,6,5,100,20,80,80),
		(2,2,N'Могилев',N'Белыничи',N'2014-10-12',4356,4,2,260000,260100,N'2014-12-05 8:15AM',N'2014-10-05 10:15AM',N'2014-10-05 8:15AM',N'2014-12-05 11:15AM',123588,123588,0.4,0.5,6,5,80,10,100,20)
  SET IDENTITY_INSERT [dbo].[Путевой лист Грузового авто] OFF
END 
GO

PRINT(N'[Задание водителю]');

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
           
PRINT(N'[Водители авто]');
GO 

IF NOT EXISTS (SELECT * FROM [dbo].[Водители авто])
BEGIN
SET IDENTITY_INSERT [dbo].[Водители авто] on
	INSERT INTO [Водители авто] ([ID],[ID_Водитель],[ID_Авто],[Date]) 
		VALUES 
		(1,125,1,N'2014-10-12'),
		(2,4356,2,N'2014-10-12'),
		(3,5645,3,N'2014-10-12'),
		(4,6789,4,N'2014-10-12'),
		(5,41256,5,N'2014-10-12')
SET IDENTITY_INSERT [dbo].[Водители авто] OFF
END 

IF(@@LANGUAGE<>'us_english')
BEGIN
	SET DATEFORMAT dmy;
END