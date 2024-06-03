-- ������������� �� ������� ���� �����
USE Real_estate;
GO

-- ��������� ����� �� ��� �������
CREATE LOGIN [admin] WITH PASSWORD = 'admin';
CREATE LOGIN [agent] WITH PASSWORD = 'agent';
GO

-- ��������� ������������ � ��� ����� � ��'����� �� � �������
CREATE USER [admin] FOR LOGIN [admin];
CREATE USER [agent] FOR LOGIN [agent];
GO


-- ������ ������� �� ������� �볺���
GRANT SELECT, INSERT ON Client TO [agent];
GO

-- ������ ������� �� ������� �������
GRANT SELECT, INSERT ON OwnerObject TO [agent];
GO

-- ������ ������� �� ������� ��'��� ����������
GRANT SELECT, INSERT ON Real_object TO [agent];
GO

-- ������ ������� �� ������� ��� ��'����
GRANT SELECT ON TypeObject TO [agent];
GO

-- ������ ������� �� ������� ��������(������)
GRANT SELECT, INSERT ON Document TO [agent];
GO

-- ������ ������� �� ������� ��������� �������
GRANT SELECT, INSERT ON DocumentObject TO [agent];
GO

-- ��������� ����� INSERT ��� ����������� [agent] �� ������� Document
REVOKE INSERT ON Document FROM [agent];
GO

-- ������ ����� SELECT ��� ����������� [agent] �� ������� Document
GRANT SELECT ON Document TO [agent];
GO

--------------------------------------------------------------------
-- ������ ������� �� ������� �볺���
GRANT SELECT, INSERT, UPDATE, DELETE ON Client TO [admin];
GO

-- ������ ������� �� ������� �������
GRANT SELECT, INSERT, UPDATE, DELETE ON OwnerObject TO [admin];
GO

-- ������ ������� �� ������� ��'��� ����������
GRANT SELECT, INSERT, UPDATE, DELETE ON Real_object TO [admin];
GO

-- ������ ������� �� ������� ��� ��'����
GRANT SELECT, INSERT, UPDATE, DELETE ON TypeObject TO [admin];
GO

-- ������ ������� �� ������� ��������(������)
GRANT SELECT, INSERT, UPDATE, DELETE ON Document TO [admin];
GO

-- ������ ������� �� ������� ��������� �������
GRANT SELECT, INSERT, UPDATE, DELETE ON DocumentObject TO [admin];
GO

