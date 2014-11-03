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
           (1,'ГАЗ 3110','бен.',9.9,'ЗМЗ 4062', NULL, 1.7,0.15,0.05,0.1),
           (2,'УАЗ 3303','бен.',15.2,'ЗМЗ 4218 4 WD', NULL,2.2,0.2,0.05,0.2),
           (3,'ГАЗ 33021','бен.',14.5,'ЗМЗ 4026,10',NULL ,1.7,0.15,0.05,0.2),
           (4,'ГАЗ 33021','СУГ',19.0,'ЗМЗ 4026,10',NULL,1.7,0.15,0.05,0.2),
           (5,'ГАЗ 3302','бен',14.7 ,'ЗМЗ 4063А',NULL ,1.7,0.15,0.05,0.2),
           (6,'ГАЗ 3302','СУГ', 19.0,'ЗМЗ 4063А',NULL ,1.7,0.15,0.05,0.2),
           (7,'ГАЗ 3307','бен.',23.8,'ЗМЗ 5130ОМ',NULL,2.1,0.3,0.1,0.25),
           (8,'ЗИЛ ММЗ 4502','бен.',36.3,'ЗИЛ 375',NULL ,2.0,0.3,0.1,0.2),
           (9,'ЗИЛ 4331','бен.',33.3,'ЗИЛ 375',NULL ,2.0,0.3,0.1,0.2),
           (10,'ЗИЛ КС2571А-1(автокран)','бен.',38.0,'ЗИЛ 130',6.1,2.2,0.3,0.1,0.2),
           (11,'МАЗ 5340 А5-370','д/т',28.8,'ЯМЗ 6582.10',NULL ,2.0,0.3,0.15,0.25),
           (12,'ГАЗ 33104','д/т',14.7,'Д 245-7Е2',NULL ,1.7,0.15,0.05,0.1),
           (13,'ГАЗ 331041-317','д/т',15.7,'Д 245-7Е3',NULL ,1.7,0.15,0.05,0.1),
           (14,'Саманд LX','бен.',9.5,'1.8 I',NULL,0.4,NULL , NULL,NULL),
           (15,'Беларусь 82.1','д/т',NULL,'Д 243',7.0,4.0,0.5,1.0,0.3),
           (16,'МТЗ 80*','д/т',NULL,'Д 243',6.5,5.0,0.5,1.0,0.3),
           (17,'Шкода Октавия**','бен',9.5 ,'1,8/118кВт TFSI-EU4',NULL ,0.4,NULL ,NULL ,NULL ),
           (18,'Шкода Практик','д/т',5.6 ,'1,4/59кВт TDIPD-EU4',NULL ,0.2,NULL , NULL,NULL ),
           (19,'Фиат Добло','д/т',6.6 ,'1,3Multijet DPF',NULL,0.1,0.01,NULL,0.1),
           (20,'РАК 8А','д/т',NULL,'S312C',1.8,5.0,0.5,1.0,0.3);
SET IDENTITY_INSERT [dbo].[Нормы расхода ГСМ на авто,тракторы] OFF
END
           
 go
PRINT('[Нормы расхода ГСМ на авто,тракторы]');
go
IF NOT EXISTS (SELECT * FROM [dbo].[Нормы расхода ГСМ на авто,тракторы])
BEGIN
SET IDENTITY_INSERT [dbo].[Нормы расхода ГСМ на авто,тракторы] on
INSERT INTO [dbo].[Нормы расхода ГСМ2 на авто,тракторы]
           (ID ,[Марка автомобиля],[Вид топлива],[Норма расхода на 100 км летняя 6%] ,[Марка двигателя],[Норма на машино час летняя] ,[Н-ма расх.масел на 100л р-да топлива моторное,л],[Н-ма расх.масел на 100л р-да трансмиссионное,л] ,[Н-ма расх.масел на 100л р-да топлива специальное,л],[Н-ма расх.масел на 100л р-да топлива пластичные смазки,л])
     VALUES
           (1,'КаМАЗ 53212','д/т',26.8,'КаМАЗ 740.10',NULL,2.8,0.4,0.15,0.35),
           (2,'ЗИЛ 433100','д/т',23.2,'ЗИЛ 645',NULL,2.8,0.4,0.15,0.35),
           (3,'Д-606','д/т',NULL,'А-41',7.6,5.0,0.5,1.0,0.3),
           (4,'Нисан 18 NRW9','д/т',NULL,'ISUZU C-240',1.8 ,2.0,0.3,0.6,0.2),
           (5,'АМЖК-8(мини-трактор)','бен.',NULL,'УД-2',0.5 ,0.5,0.1,0.2,0.1),
           (6,'ГАЗ 330202','д/т',10.3,'ISF2.8S3129T',NULL,1.0,0.15,0.05,0.1),
           (7,'Джили SC7','бен.','8,2',NULL,NULL,NULL,NULL,NULL,NULL);
                      
  SET IDENTITY_INSERT [dbo].[Нормы расхода ГСМ на авто,тракторы] OFF
END         

GO

PRINT('[Подвижной состав]');
go          
IF NOT EXISTS (SELECT * FROM [dbo].[Подвижной состав])
BEGIN
SET IDENTITY_INSERT [dbo].[Подвижной состав] on
	INSERT INTO [Подвижной состав] ([ID],[Марка и модель],[Гос.номер],[Гаражный номер],[Тип двигателя],[Год выпуска]
								,[Инвентарный номер],[Вид топлива],[дата окончания страховки],[Тип назначения авто]) 
		VALUES 
		(1,'Опель','2514АА-6','15','СУО',1996,'125М','бен','2015-12-20','Л'),
		(2,'Нисан','5476АР-6','10','АВК',2005,'1247','СУГ','2016-01-14','Л'),
		(3,'МАЗ5551','2541ОР-6','9','РПЕН',2004,'145','диз','2014-01-02','Г'),
		(4,'КаМаз 5435','1254АГ-7','21Н','КаМаз 740.10',2001,'КА5678','д/т','2017-08-02','Г'),
		(5,'Шкода 567','5467 РО-7','43','бен',2009,'лог8765','бен','2014-07-05','Л')
  SET IDENTITY_INSERT [dbo].[Подвижной состав] OFF
END 
go
PRINT('[Личный состав]');
go
           
IF NOT EXISTS (SELECT * FROM [dbo].[Личный состав])
BEGIN
INSERT INTO [Личный состав] 
	([табельный  номер],[ФИО],[номер водительского удостоверения],[классность],[срок действия мед. справки])
		VALUES 
(125,'Петров Иван Михайлович','14587',5,'2020-04-25'),
(4356,'Иванов','458712',2,'2015-02-20'),
(5645,'Пупкин','КУ67854',1,'2017-08-10'),
(6789,'Васильев Николай Олегович','неп65789',5,'2018-10-25'),
(41256,'Жуковский','765546',2,'2016-02-10')
END 

go
PRINT('[Путевой лист легкового автомобиля]');
go
           
IF NOT EXISTS (SELECT * FROM [dbo].[Путевой лист легкового автомобиля])
BEGIN
SET IDENTITY_INSERT [dbo].[Путевой лист легкового автомобиля] on
	INSERT INTO [Путевой лист легкового автомобиля] ([ID_Путевого листа],[Номер путевого листа],[За период с],[За период по],[ID_Автомобиль],[ID_Водитель]) 
		VALUES 
		(1,7,'May 15 2010 12:00AM','May 15 2010 12:00AM',1,125),
		(2,9,'Aug 20 2014 12:00AM','Aug 21 2014 12:00AM',1,4356),
		(3,10,'Sep  1 2014 12:00AM','Sep  1 2014 12:00AM',1,5645)
  SET IDENTITY_INSERT [dbo].[Путевой лист легкового автомобиля] OFF
END 
go
PRINT('[Путевой лист Грузового авто]');
go
IF NOT EXISTS (SELECT * FROM [dbo].[Путевой лист Грузового авто])
BEGIN
SET IDENTITY_INSERT [dbo].[Путевой лист Грузового авто] on
	INSERT INTO [Путевой лист Грузового авто] ([ID_Путевого листа],[Номер путевого листа],[Дата путевого листа],[ID_Водителя],[ID_Автомобиля]) 
		VALUES 
		(1,1,'2014-10-25',125,1),
		(2,2,'2014-10-26',4356,2)
  SET IDENTITY_INSERT [dbo].[Путевой лист Грузового авто] OFF
END 
           
go
PRINT('[Данные Путевой лист легкового авто]');
go
IF NOT EXISTS (SELECT * FROM [dbo].[Данные Путевой лист легкового авто])
BEGIN
SET IDENTITY_INSERT [dbo].[Данные Путевой лист легкового авто] on
	INSERT INTO [Данные Путевой лист легкового авто] ([id_Данных],[ID_Путевого листа],[Число],[Время выезда],[Время возвращения],[Время в наряде],
	[Показания спидометра при выезде],[Показания спидометра при возвращении],[Пробег км],[Остаток топлива при выезде],
	[Остаток топлива при возвращении],[Заправлено топлива л],[Дата и № чека АЗС],[Расход топлива по норме],[Расход топлива фактически],[Расход топлива экономия перерасход]) 
		VALUES 
		(1,1,'2014-10-25','08:15AM','5:00PM','08:45:00',158746,158756,10,15,20,100 ,'20.05.2014',8,25,20),
		(2,1,'2014-10-26','08:15AM','5:00PM','08:30:00',125500,126000,500,20,25,30, '20.08.2014',9,24,21),
		(3,2,'2014-10-27','09:15AM','5:00PM','06:00:00',100300,100500,200,5,5,20, '10.09.2014',8,8,8)
  SET IDENTITY_INSERT [dbo].[Данные Путевой лист легкового авто] OFF
END 
           
go
PRINT('[Задание водителю]');
go           

IF NOT EXISTS (SELECT * FROM [dbo].[Задание водителю])
BEGIN
SET IDENTITY_INSERT [dbo].[Задание водителю] on
	INSERT INTO [Задание водителю] ([id],[ID_Путевого листа],[Заказчик],[Дата и время прибытия],[Дата и время убытия],
	[Пункт отправления],[Пункт назначения],[Расстояние км],[Наименование груза],[Вес груза т],[Количество поездок с грузом час]) 
		VALUES 
		(1,1,'ОМТС','May 15 2010 8:15AM','May 15 2010 11:00AM','Могилев','по городу',125,'стольной лом',14.0,2),
		(2,2,'Лифтмаш','May 15 2010 11:00AM','May 15 2010 10:00AM','Могилев','по городу',5,'лифты',20.5,3)
  SET IDENTITY_INSERT [dbo].[Задание водителю] OFF
END 
           
go
PRINT('[Работа водителя и автомобиля]');
go 

IF NOT EXISTS (SELECT * FROM [dbo].[Работа водителя и автомобиля])
BEGIN
SET IDENTITY_INSERT [dbo].[Работа водителя и автомобиля] on
	INSERT INTO [Работа водителя и автомобиля] ([ID_работа водителя и авто],[ID_Путевого листа],[Операции],[Показания спидометра],
	[Дата и время по графику],[Дата и время фактически],[Нулевой пробег],[Время работы двигателя час],[Время работы спецоборудования]) 
		VALUES 
		(2,1,'Возвращение с линии',282500,'May 15 2010 8:15AM','May 15 2010 10:15AM',123588,0.5,6),
		(1,2,'Выезд на линию',281436,'May 15 2010 8:15AM','May 15 2010 11:15AM',123588,0.4,5)
  SET IDENTITY_INSERT [dbo].[Работа водителя и автомобиля] OFF
END 
           
go
PRINT('[Движение ТСМ]');
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
PRINT('[Заправка ТСМ]');
go 

IF NOT EXISTS (SELECT * FROM [dbo].[Заправка ТСМ])
BEGIN
SET IDENTITY_INSERT [dbo].[Заправка ТСМ] on
	INSERT INTO [Заправка ТСМ] ([ID_Заправка ТСМ],[Дата],[Марка ТСМ],[Количество],[ID_Путевого листа]) 
		VALUES 
		('1','2014-10-20','ДТ',100,20),
		('2','2014-10-21','СУГ',50,21)
  SET IDENTITY_INSERT [dbo].[Заправка ТСМ] OFF
END 
  
