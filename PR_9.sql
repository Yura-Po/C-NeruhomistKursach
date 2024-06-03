-- Переключаємося до потрібної бази даних
USE Real_estate;
GO

-- Створюємо логіни на рівні сервера
CREATE LOGIN [admin] WITH PASSWORD = 'admin';
CREATE LOGIN [agent] WITH PASSWORD = 'agent';
GO

-- Створюємо користувачів у базі даних і зв'язуємо їх з логінами
CREATE USER [admin] FOR LOGIN [admin];
CREATE USER [agent] FOR LOGIN [agent];
GO


-- Надаємо дозволи на таблицю Клієнти
GRANT SELECT, INSERT ON Client TO [agent];
GO

-- Надаємо дозволи на таблицю Власник
GRANT SELECT, INSERT ON OwnerObject TO [agent];
GO

-- Надаємо дозволи на таблицю Об'єкт нерухомості
GRANT SELECT, INSERT ON Real_object TO [agent];
GO

-- Надаємо дозволи на таблицю Тип об'єкта
GRANT SELECT ON TypeObject TO [agent];
GO

-- Надаємо дозволи на таблицю Документ(договір)
GRANT SELECT, INSERT ON Document TO [agent];
GO

-- Надаємо дозволи на таблицю Перехідна таблиця
GRANT SELECT, INSERT ON DocumentObject TO [agent];
GO

-- Видаляємо права INSERT для користувача [agent] на таблицю Document
REVOKE INSERT ON Document FROM [agent];
GO

-- Надаємо права SELECT для користувача [agent] на таблицю Document
GRANT SELECT ON Document TO [agent];
GO

--------------------------------------------------------------------
-- Надаємо дозволи на таблицю Клієнти
GRANT SELECT, INSERT, UPDATE, DELETE ON Client TO [admin];
GO

-- Надаємо дозволи на таблицю Власник
GRANT SELECT, INSERT, UPDATE, DELETE ON OwnerObject TO [admin];
GO

-- Надаємо дозволи на таблицю Об'єкт нерухомості
GRANT SELECT, INSERT, UPDATE, DELETE ON Real_object TO [admin];
GO

-- Надаємо дозволи на таблицю Тип об'єкта
GRANT SELECT, INSERT, UPDATE, DELETE ON TypeObject TO [admin];
GO

-- Надаємо дозволи на таблицю Документ(договір)
GRANT SELECT, INSERT, UPDATE, DELETE ON Document TO [admin];
GO

-- Надаємо дозволи на таблицю Перехідна таблиця
GRANT SELECT, INSERT, UPDATE, DELETE ON DocumentObject TO [admin];
GO

