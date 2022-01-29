CREATE TABLE [dbo].[CarProp]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [CarId] VARCHAR(50) NULL, 
    [BrandId] NVARCHAR(50) NULL, 
    [ColorId] NVARCHAR(50) NULL, 
    [ModelYear] INT NULL, 
    [DailyPrice] DECIMAL NULL, 
    [Description] NVARCHAR(50) NULL,

)
