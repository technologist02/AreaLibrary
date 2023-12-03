USE [Test1]

SELECT p.Product as product, c.Category as category
  FROM Products AS p
  LEFT JOIN ProductsAndCategories AS pc ON pc.ProductId =p.Id
  LEFT JOIN Categories AS c ON c.Id = pc.CategoryId

GO