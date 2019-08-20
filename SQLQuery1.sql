-- =============================================                                 
-- source : https://code.msdn.microsoft.com/ASPNET-MVC-5-Security-And-44cbdb97 
-- Author      : Debbie                                  
-- Create date : 2019-08-15                                
-- Description : To Create Database                           
--   
--   
-- =============================================   
-- CREATES SAMPLE DATABASE THAT HOUSES BOTH USER AND DATA VALUES

--Script to create DB,Table and sample Insert data   
USE MASTER;   
-- 1) Check for the Database Exists .If the database is exist then drop and create new DB   
IF EXISTS (SELECT [name] FROM sys.databases WHERE [name] = 'AttendanceDB' )   
BEGIN   
ALTER DATABASE AttendanceDB SET SINGLE_USER WITH ROLLBACK IMMEDIATE   
DROP DATABASE AttendanceDB ;   
END     
   
CREATE DATABASE AttendanceDB   
GO   
   
USE AttendanceDB 