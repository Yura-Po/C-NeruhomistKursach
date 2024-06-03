-- Тригер для перевірки валідності email при вставці в таблицю Client
CREATE TRIGGER trgValidateEmailOnClientInsert
ON Client
FOR INSERT
AS
BEGIN
    DECLARE @Email VARCHAR(100);
    SELECT @Email = Email FROM inserted;

    IF NOT (@Email LIKE '%@%')
    BEGIN
        RAISERROR('Invalid email format.', 16, 1);
        ROLLBACK TRANSACTION;
    END
END;
GO

-- Тригер для перевірки коректності ціни при вставці нового документу
CREATE TRIGGER trgCheckPriceOnDocumentInsert
ON Document
FOR INSERT
AS
BEGIN
    DECLARE @Price DECIMAL(18, 2);
    SELECT @Price = Price FROM inserted;

    IF @Price <= 0
    BEGIN
        RAISERROR('Price must be greater than 0.', 16, 1);
        ROLLBACK TRANSACTION;
    END
END;
GO


-- Тригер для перевірки коректності площі при вставці нового об'єкту нерухомості
CREATE TRIGGER trgCheckAreaOnRealObjectInsert
ON Real_object
FOR INSERT
AS
BEGIN
    DECLARE @Area FLOAT;
    SELECT @Area = Area FROM inserted;

    IF @Area <= 0
    BEGIN
        RAISERROR('Area must be greater than 0.', 16, 1);
        ROLLBACK TRANSACTION;
    END
END;
GO
