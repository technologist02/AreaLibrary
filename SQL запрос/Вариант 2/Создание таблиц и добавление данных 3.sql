use Test1
GO

CREATE TABLE Products (
	Id INT PRIMARY KEY IDENTITY,
	Product NVARCHAR(20) NOT NULL,
)
GO

CREATE TABLE Categories (
	Id INT PRIMARY KEY IDENTITY,
	Category NVARCHAR(20) NOT NULL,
)
GO

CREATE TABLE ProductsAndCategories (
	Id INT PRIMARY KEY IDENTITY,
	ProductId INT NOT NULL,
	CategoryId INT NOT NULL,
	FOREIGN KEY (ProductId)  REFERENCES Products3 (Id),
	FOREIGN KEY (CategoryId) REFERENCES Categories3(Id)

)
GO

INSERT INTO Categories (Category)
VALUES ('Gadgets'),
('Drinks'),
('Medicines'),
('Food'),
('Smartphones')
GO

INSERT Into Products (Product)
VALUES ('Galaxy S21'),
('Coca Cola'),
('Nokia 3310'),
('Huawie FreeBuds 5i'),
('Парацетамол'),
('Milk 1L'),
('XBox One X')
GO

INSERT INTO ProductsAndCategories (ProductId, CategoryId)
VALUES (1,1),
(2,4),
(3,1),
(4,1),
(5,3),
(6,4),
(1,5)
GO
