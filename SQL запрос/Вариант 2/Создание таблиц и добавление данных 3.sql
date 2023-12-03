use Test1
GO

CREATE TABLE Products3 (
	Id INT PRIMARY KEY IDENTITY,
	Product NVARCHAR(20) NOT NULL,
)
GO

CREATE TABLE Categories3 (
	Id INT PRIMARY KEY IDENTITY,
	Category NVARCHAR(20) NOT NULL,
)
GO

CREATE TABLE ProdsAndCats3 (
	Id INT PRIMARY KEY IDENTITY,
	ProductId INT NOT NULL,
	CategoryId INT NOT NULL,
	FOREIGN KEY (ProductId)  REFERENCES Products3 (Id),
	FOREIGN KEY (CategoryId) REFERENCES Categories3(Id)

)
GO

INSERT INTO Categories3 (Category)
VALUES ('Gadgets'),
('Drinks'),
('Medicines'),
('Food'),
('Smartphones')
GO

INSERT Into Products3 (Product)
VALUES ('Galaxy S21'),
('Coca Cola'),
('Nokia 3310'),
('Huawie FreeBuds 5i'),
('Парацетамол'),
('Milk 1L'),
('Galaxy S21'),
('XBox One X')
GO
