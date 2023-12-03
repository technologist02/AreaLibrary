use Test1
GO

CREATE TABLE Products2 (
	Id INT PRIMARY KEY IDENTITY,
	Product NVARCHAR(20) NOT NULL,
	CategoryId INT
)

CREATE TABLE Categories2 (
	Id INT PRIMARY KEY IDENTITY,
	Category NVARCHAR(20) NOT NULL,
	--ProductId INT
)
GO

INSERT INTO Categories2 (Category)
VALUES ('Gadgets'),
('Drinks'),
('Medicines'),
('Food'),
('Smartphones')
GO

INSERT Into Products2 (Product, CategoryId)
VALUES ('Galaxy S21', 1),
('Coca Cola', 2),
('Nokia 3310', 1),
('Huawie FreeBuds 5i', 1),
('Парацетамол', 3),
('Milk 1L', 4),
('Galaxy S21', 5),
('XBox One X', NULL)