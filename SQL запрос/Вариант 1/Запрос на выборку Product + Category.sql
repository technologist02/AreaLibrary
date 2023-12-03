use Test1
GO


SELECT p.Product as product, c.Category as category
  FROM Products2 AS p
  LEFT JOIN Categories2 AS c ON c.Id = p.CategoryId

GO