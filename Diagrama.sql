-- Спочатку створюємо таблиці
CREATE TABLE Client (
    idClient CHAR(36) NOT NULL CONSTRAINT PKidClient PRIMARY KEY,
    Surname VARCHAR(100) NOT NULL,
    NameClient VARCHAR(100) NOT NULL,
    Father VARCHAR(100) NOT NULL,
    Fhone VARCHAR(100) NOT NULL,
    Email VARCHAR(100) NOT NULL
);

CREATE TABLE OwnerObject (
    idOwner CHAR(36) NOT NULL CONSTRAINT PKidOwner PRIMARY KEY,
    Surname VARCHAR(100) NOT NULL,
    NameOwner VARCHAR(100) NOT NULL,
    Father VARCHAR(100) NOT NULL,
    Fhone VARCHAR(100) NOT NULL,
    Email VARCHAR(100) NOT NULL
);

CREATE TABLE TypeObject (
    idType CHAR(36) NOT NULL CONSTRAINT PKidType PRIMARY KEY,
    TypeName VARCHAR(100) NOT NULL,
    Coefficient FLOAT NOT NULL DEFAULT (1)
);

CREATE TABLE Real_object (
    idObject CHAR(36) NOT NULL CONSTRAINT PKidObject PRIMARY KEY,
    idType CHAR(36) NOT NULL DEFAULT '1',
    idOwner CHAR(36) NOT NULL DEFAULT '1',
    Area FLOAT NOT NULL DEFAULT (1),
    PriceMeter INT NOT NULL DEFAULT (1),
    DescriptionObject TEXT, 
    Adres VARCHAR(100) NOT NULL,
    Foto VARCHAR(255)
);

CREATE TABLE Document (
    idDocument CHAR(36) NOT NULL CONSTRAINT PKidDocument PRIMARY KEY,
    idClient CHAR(36) NOT NULL DEFAULT '1',
    Price MONEY NOT NULL,
    DateDocument DATE NOT NULL,
    idOwner CHAR(36) NOT NULL DEFAULT '1', -- нове поле
    desObject TEXT -- нове поле
);

-- Спочатку створюємо таблицю DocumentObject
CREATE TABLE DocumentObject (
    idDoc CHAR(36) NOT NULL CONSTRAINT DF_idDoc DEFAULT '1',
    idObj CHAR(36) NOT NULL CONSTRAINT DF_idObj DEFAULT '1',
    FOREIGN KEY (idDoc) REFERENCES Document(idDocument) ON DELETE NO ACTION ON UPDATE NO ACTION, -- Виправлено помилку
    FOREIGN KEY (idObj) REFERENCES Real_object(idObject) ON DELETE NO ACTION ON UPDATE NO ACTION -- Виправлено помилку
);

-- Потім створюємо зовнішні ключі
ALTER TABLE Document ADD CONSTRAINT FK_Client
FOREIGN KEY (idClient) REFERENCES Client(idClient) ON DELETE SET DEFAULT ON UPDATE NO ACTION;

ALTER TABLE Real_object ADD CONSTRAINT FK_TypeObject
FOREIGN KEY (idType) REFERENCES TypeObject(idType) ON DELETE SET DEFAULT ON UPDATE NO ACTION;

ALTER TABLE Real_object ADD CONSTRAINT FK_OwnerObject
FOREIGN KEY (idOwner) REFERENCES OwnerObject(idOwner) ON DELETE SET DEFAULT ON UPDATE NO ACTION;

ALTER TABLE DocumentObject ADD CONSTRAINT FK_DocumentObject_Document
FOREIGN KEY (idDoc) REFERENCES Document(idDocument) ON DELETE NO ACTION ON UPDATE NO ACTION;

ALTER TABLE DocumentObject ADD CONSTRAINT FK_DocumentObject_Real_object
FOREIGN KEY (idObj) REFERENCES Real_object(idObject) ON DELETE NO ACTION ON UPDATE NO ACTION;
