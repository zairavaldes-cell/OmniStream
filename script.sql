CREATE TABLE Usuarios (
    Id INT PRIMARY KEY,
    Nombre VARCHAR(100),
    Saldo DECIMAL(10,2),
    TieneDeudas BIT,
    EsPremium BIT
);

INSERT INTO Usuarios VALUES (1, 'Juan', 100, 0, 0);
INSERT INTO Usuarios VALUES (2, 'Maria', 20, 1, 0);