
Select [Product Table].Suppliers,[Product Table].UnitPrice AS TotalPrice , [Ship-Table].ShipCompany From [Product Table]
Inner Join [Ship-Table] ON [Ship-Table].ShipName=[Product Table].Suppliers
Where [Product Table].Suppliers='Exoitic Liquids' AND [Product Table].UnitPrice>50

select * from [Employee Table]  Order by Joiningdate ASC

select * from [Employee Table]  Order by Joiningdate DESC

Select * From [Product Table] 
 Select * From [OrderItem Table]
order by UnitPrice DESC

Select TOP (1)  UnitPrice 
from [Product Table] as Expensive
order by UnitPrice  DESC  ASC

Select TOP (1) UnitPrice
from [Product Table] as LeastExpensive
order by UnitPrice ASC

SELECT [Product Name],UnitPrice
FROM [Product Table]
WHERE UnitPrice = (SELECT MAX(UnitPrice) FROM  [Product Table] ) Or
UnitPrice = (SELECT MIN(UnitPrice) FROM [Product Table])
Select * from [Stock-Table] where Status= 'Outofstock'
Select * from [Employee Table]
Select * from [Stock-Table]

Select * from [Stock-Table] where Unitinstock<Unitinorder

select CONCAT([Customer Table].FirstName,'',[Customer Table].Lastname) AS CustomerName ,[Order Table].OrderDate,[OrderItem Table].OrderId,[Product Table].[Product Name] From [Product Table]
Inner Join [OrderItem Table] ON [OrderItem Table].[Product Id]=[Product Table].ID
Inner Join [Order Table] ON [Order Table].OrderId=[OrderItem Table].OrderId
Inner Join [Customer Table] ON [Customer Table].Id=[Order Table].CustomerId

select CONCAT([Customer Table].FirstName,'',[Customer Table].Lastname) AS CustomerName, [OrderItem Table].Quantity AS [NO.of Orders] From [OrderItem Table]
Inner Join [Order Table]ON [Order Table].OrderId=[OrderItem Table].OrderId
Inner Join [Customer Table] ON [Customer Table].Id=[Order Table].CustomerId
Where [OrderItem Table].Quantity=(SELECT MAX(Quantity) From [OrderItem Table])
Select * from [Ship-Table]

SELECT * FROM [Customer Table] WHERE SUBSTRING([FirstName],1,2)='RA'
 
SELECT SUBSTRING(ShipCompany,1,1) AS [FIRST-LETTER-OF-COMPANY],ShipCompany FROM [Ship-Table]

Select CategoryName,Suppliers From [Product Table]