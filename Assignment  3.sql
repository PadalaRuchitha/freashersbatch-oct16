Select * from [Order Table]
Select * from [OrderItem Table]  
Select * from [Customer Table]
Select * from [Product Table]


Create PROCEDURE  SPORDER
@Phone INT
AS
Begin

Select [Product Table].ID,[OrderItem Table].[orderitem Id],[Order Table].CustomerId,[Customer Table]. Phone,[Customer Table].FirstName From [Product Table]
Inner Join [OrderItem Table] On [OrderItem Table].[Product Id]=[Product Table].ID
Inner Join [Order Table] On [Order Table].OrderId=[OrderItem Table].OrderId
Inner Join [Customer Table] On [Customer Table].Id=[Order Table].CustomerId
Where [Customer Table].Phone=@Phone 

END
SPORDER 0300074321

Select * from [Product Table] where CategoryName = 'Sea food'

Select [Product Table].[Product Name],[OrderItem Table].OrderId,[Order Table].CustomerId,CONCAT( [Customer Table].FirstName,'',[Customer Table].Lastname) AS [Customer-Name] ,[Customer Table].Country From [Product Table]
Inner Join [OrderItem Table] ON [OrderItem Table].[Product Id]=[Product Table].ID
Inner Join [Order Table] ON [Order Table].OrderId=[OrderItem Table].OrderId
Inner Join [Customer Table] ON [Customer Table].Id=[Order Table].CustomerId
Where [Customer Table].City != 'London'
 
Select [Product Table].[Product Name],[OrderItem Table].OrderId,CONCAT( [Customer Table].FirstName,'',[Customer Table].Lastname) AS [Customer-Name] From [Product Table]
Inner Join [OrderItem Table] ON [OrderItem Table].[Product Id]=[Product Table].ID
Inner Join [Order Table] On [Order Table].OrderId=[OrderItem Table].OrderId
Inner Join [Customer Table] On [Customer Table].Id=[Order Table].CustomerId
Where [Product Table].[Product Name]='Chai'

Select EmpFirstName,EmpID,DepartmentName,Rating From [Employee Table] 