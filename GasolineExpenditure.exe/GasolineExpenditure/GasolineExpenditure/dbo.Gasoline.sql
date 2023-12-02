CREATE DATABASE GasolineExpenditure;
DROP TABLE IF EXISTS Gasoline;

CREATE TABLE [dbo].[Gasoline]
(
	[TransactionID] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Date] DATE NOT NULL, 
    [StationLocation] VARCHAR(255) NOT NULL, 
    [VehicleYear] INT NOT NULL, 
    [VehicleMake] VARCHAR(100) NOT NULL, 
    [VehicleModel] VARCHAR(100) NOT NULL, 
    [LitresFilled] DECIMAL(10, 2) NOT NULL, 
    [CostPerLitre] DECIMAL(10, 2) NOT NULL, 
    [TotalCost] AS (LitresFilled * CostPerLitre),
    [PointsEarned] INT
)

--SELECT * FROM Gasoline;