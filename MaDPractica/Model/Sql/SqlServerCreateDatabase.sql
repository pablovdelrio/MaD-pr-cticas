 DECLARE @Default_DB_Path as VARCHAR(64)  
 SET @Default_DB_Path = N'C:\SourceCode\DataBase\'

 USE [master]


/***** Drop database if already exists  ******/
IF  EXISTS (SELECT name FROM sys.databases WHERE name = 'miniportal')
DROP DATABASE [miniportal]


USE [master]


/* DataBase Creation */

	                              
DECLARE @sql nvarchar(500)

SET @sql = 
  N'CREATE DATABASE [practicaMaD] 
    ON PRIMARY ( NAME = practicaMaD, FILENAME = "' + @Default_DB_Path + N'practicaMaD.mdf")
    LOG ON ( NAME = practicaMaD_log, FILENAME = "' + @Default_DB_Path + N'practicaMaD_log.ldf")'

EXEC(@sql)
PRINT N'Database [practicaMaD] created.'
GO
