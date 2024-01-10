--CREATE DATABASE GasolineExpenditure;
DROP TABLE IF EXISTS Gasoline_2023;

CREATE TABLE Gasoline_2023
(
    InvoiceNumber INT PRIMARY KEY,
    DateofPurchase DATE,
    FullName VARCHAR(255),
    Company VARCHAR(255),
    Station VARCHAR(255),
    PumpNumber INT,
    Octane VARCHAR(255),
    Litres DECIMAL(10,4),
    LitresPerDollar DECIMAL(10,4),
    TotalPoints INT,
    PointsGained INT,
    Taxes DECIMAL(10,4),
    Cost AS CAST(Litres * LitresPerDollar AS DECIMAL(10,2))
)

    SELECT
    InvoiceNumber AS 'INVOICE',
    DateofPurchase AS 'DATE',
    FullName AS 'NAME',
    Company AS 'COMPANY',
    Station AS 'ADDRESS',
    PumpNumber AS 'PUMP',
    Octane AS 'OCTANE',
    Litres AS 'LITRES',
    LitresPerDollar AS 'L/$CAD', 
    Taxes AS 'TAXES',
    Cost AS 'COST',
    TotalPoints AS 'TOTAL PTS',
    PointsGained AS 'PTS GAIN' 
    FROM Gasoline_2023 ORDER BY DateofPurchase DESC;