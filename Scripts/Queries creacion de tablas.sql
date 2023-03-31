-- Script para la tabla CriptoBase
CREATE TABLE CriptoBase (
    Id INT PRIMARY KEY IDENTITY(1,1),
    comprar_USDT FLOAT NOT NULL,
    vender_USDT FLOAT NOT NULL,
    fecha DATETIME NOT NULL,
    exchange VARCHAR(50) NULL
);

-- Script para la tabla ExchangeRates
CREATE TABLE ExchangeRates (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Belo_Id INT NULL FOREIGN KEY REFERENCES CriptoBase(Id),
    Letsbit_Id INT NULL FOREIGN KEY REFERENCES CriptoBase(Id),
    Fiwind_Id INT NULL FOREIGN KEY REFERENCES CriptoBase(Id),
    Lemon_Id INT NULL FOREIGN KEY REFERENCES CriptoBase(Id),
    Buenbit_Id INT NULL FOREIGN KEY REFERENCES CriptoBase(Id)
);