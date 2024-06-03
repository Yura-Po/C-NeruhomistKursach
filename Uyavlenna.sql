SELECT ro.idType, typeobj.TypeName, ownerobj.Surname AS OwnerSurname, ownerobj.NameOwner AS OwnerName, ro.Area, ro.PriceMeter, ro.DescriptionObject, ro.Adres, ro.Foto
FROM Real_object ro
JOIN TypeObject typeobj ON ro.idType = typeobj.idType
JOIN OwnerObject ownerobj ON ro.idOwner = ownerobj.idOwner;

GO

SELECT c.Surname AS ClientSurname, c.NameClient AS ClientName, c.Father AS ClientFather, c.Fhone AS ClientPhone, c.Email AS ClientEmail, d.Price, d.DateDocument
FROM Document d
JOIN Client c ON d.idClient = c.idClient;

GO

SELECT TypeObject.TypeName, AVG(Real_object.PriceMeter) AS AvgPriceMeter, COUNT(*) AS ObjectCount
FROM Real_object
JOIN TypeObject ON Real_object.idType = TypeObject.idType
GROUP BY TypeObject.TypeName;
