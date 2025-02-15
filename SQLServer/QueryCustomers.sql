/****** Script para el comando SelectTopNRows de SSMS  ******/
SELECT TOP 1000 [CustomerID] AS IDCliente
      ,[CompanyName] AS Empresa
      ,[ContactName] AS Contacto
      ,[ContactTitle] AS ContactoTipo
      ,[Address] AS Direccion
      ,[City] AS Ciudad
      ,[Region] AS Region
      ,[PostalCode] AS CP
      ,[Country] AS Pais
      ,[Phone] AS Telefono
      ,[Fax] AS TelefonoFAX
  FROM [Northwind].[dbo].[Customers]
  WHERE [Country] = 'Argentina' OR	[Country] = 'Brasil' 
  ORDER BY [Country]