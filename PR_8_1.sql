-- Збережена процедура для додавання нового клієнта
CREATE PROCEDURE AddClient (
    @idClient CHAR(36),
    @Surname VARCHAR(100),
    @NameClient VARCHAR(100),
    @Father VARCHAR(100),
    @Fhone VARCHAR(100),
    @Email VARCHAR(100)
)
AS
BEGIN
    INSERT INTO Client (idClient, Surname, NameClient, Father, Fhone, Email)
    VALUES (@idClient, @Surname, @NameClient, @Father, @Fhone, @Email);
END;
GO

-- Збережена процедура для додавання нового об'єкту нерухомості
CREATE PROCEDURE AddRealObject (
    @idObject CHAR(36),
    @idType CHAR(36),
    @idOwner CHAR(36),
    @Area FLOAT,
    @PriceMeter INT,
    @DescriptionObject TEXT,
    @Adres VARCHAR(100),
    @Foto VARCHAR(255)
)
AS
BEGIN
    INSERT INTO Real_object (idObject, idType, idOwner, Area, PriceMeter, DescriptionObject, Adres, Foto)
    VALUES (@idObject, @idType, @idOwner, @Area, @PriceMeter, @DescriptionObject, @Adres, @Foto);
END;
GO

-- Збережена процедура для створення нового документу з новими полями idOwner та desObject
CREATE PROCEDURE AddDocument (
    @idDocument CHAR(36),
    @idClient CHAR(36),
    @Price MONEY,
    @DateDocument DATE,
    @idOwner CHAR(36),
    @desObject TEXT
)
AS
BEGIN
    INSERT INTO Document (idDocument, idClient, Price, DateDocument, idOwner, desObject)
    VALUES (@idDocument, @idClient, @Price, @DateDocument, @idOwner, @desObject);
END;
GO
