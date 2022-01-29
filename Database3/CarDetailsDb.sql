CREATE TABLE [dbo].[CarDetailsDb]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [BrandName] NVARCHAR(50) NULL, 
    [ColorName] NVARCHAR(50) NULL, 
    [ModelYear] INT NULL, 
    [CarId] NVARCHAR(50) NULL, 
    [BrandId] NVARCHAR(50) NULL, 
    [Description] NVARCHAR(50) NULL
)
