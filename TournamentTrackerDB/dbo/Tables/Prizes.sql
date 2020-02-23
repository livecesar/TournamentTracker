CREATE TABLE [dbo].[Prizes]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [PlaceNumber] NVARCHAR(50) NULL, 
    [PlaceName] NVARCHAR(50) NULL, 
    [PrizeAmount] MONEY NULL, 
    [PrizePercentage] FLOAT NULL
)
