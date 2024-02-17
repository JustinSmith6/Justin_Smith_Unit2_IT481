USE [master]
GO
CREATE LOGIN [User_CEO] WITH PASSWORD=N'ceo123' MUST_CHANGE, DEFAULT_DATABASE=[Northwind], CHECK_EXPIRATION=ON, CHECK_POLICY=ON
GO
USE [Northwind]
GO
CREATE USER [User_CEO] FOR LOGIN [User_CEO]
GO
USE [Northwind]
GO
ALTER ROLE [CEORole] ADD MEMBER [User_CEO]
GO
