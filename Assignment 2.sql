SELECT [Order Table].OrderId,[Product Table].[Product Name],[Product Table].CategoryName,[Order Table].DiscountPrice FROM [OrderItem Table]
INNER JOIN [Order Table] ON [Order Table].OrderId=[OrderItem Table].[OrderId]
INNER JOIN [Product Table] ON [Product Table].ID =[OrderItem Table].[Product Id] 
WHERE [OrderItem Table].[OrderId]= 401

select * from [Order Table]