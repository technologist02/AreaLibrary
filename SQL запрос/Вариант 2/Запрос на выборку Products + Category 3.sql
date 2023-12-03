USE [Test1]

SELECT p.Product as product, c.Category as category
  FROM Products3 AS p
  LEFT JOIN ProdsAndCats3 AS pc ON pc.ProductId =p.Id
  LEFT JOIN Categories3 AS c ON c.Id = pc.CategoryId

GO


