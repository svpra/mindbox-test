# Второе проходное задание на стажировку в MindBox
### Задание:
```

```
### Решение:
Сначала создаём базу данных с продуктами:
``` SQL
CREATE TABLE Products (
	Id INT PRIMARY KEY,
	"Name" TEXT
);
```

Затем добавляем в неё продукты:
``` SQL
INSERT INTO Products
VALUES
	(1, 'Apple iPhone 12'),
	(2, 'Зорич В.А. "Математический Анализ"'),
  (3, 'Mitsubishi Outlander'),
	(4, '100 Rozes'),
	(5, 'Toyota Supra'),
	(6, 'Samsung Galaxy S20'),
	(7, 'Commodore64');
```

Далее создаём базу данных с категориями:
``` SQL
CREATE TABLE Categories (
	Id INT PRIMARY KEY,
	"Name" TEXT
);
```

Добавляем в неё категории:
``` SQL
INSERT INTO Categories
VALUES
	(1, 'Phone'),
	(2, 'Book'),
	(3, 'Car'),
	(4, 'Present'),
	(5, 'Car'),
	(6, 'Phone'),
	(7, 'Present');

```
Создаём базу данных, где категории и продукты будут объединены:
``` SQL
CREATE TABLE ProductCategories (
	ProductId INT FOREIGN KEY REFERENCES Products(Id),
	CategoryId INT FOREIGN KEY REFERENCES Categories(Id),
	PRIMARY KEY (ProductId, CategoryId)
);
```
Добавляем в неё продукты и соответствующие категории:

``` SQL
INSERT INTO ProductCategories
VALUES
	(1, 1),
	(1, 4),
	(2, 2),
  (2, 4),
  (3, 3),
  (4, 4),
  (5, 3),
  (6, 1),
  (6, 4),
  (7, 4);
```

И объединяем (само решение):
``` SQL
SELECT P."Name", C."Name"
FROM Products P
LEFT JOIN ProductCategories PC
	ON P.Id = PC.ProductId
LEFT JOIN Categories C
	ON PC.CategoryId = C.Id;
```
