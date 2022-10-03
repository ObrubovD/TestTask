# TestTask

В базе данных MS SQL Server есть продукты и категории. Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов. Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории». Если у продукта нет категорий, то его имя все равно должно выводиться.

CREATE TABLE Products(id INT PRIMARY KEY, name VARCHAR(255) NOT NULL);
CREATE TABLE Category(id INT PRIMARY KEY, name VARCHAR(255) NOT NULL);
CREATE TABLE ProdCat(products_id INT NOT NULL, category_id INT NOT NULL);

INSERT INTO Products VALUES(1, 'kia'), (2, 'ВАЗ'), (3, 'Книга Ремарк три товарища');
INSERT INTO Category VALUES(1, 'Автомобиль'), (2, 'Книги');
INSERT INTO ProdCat VALUES(1, 1), (2, 1), (3, 2);

SELECT prod.name [продукт], cat.name [категория] FROM Products prod
    LEFT FOIN ProdCat prodcat ON prod.id = prodcat.products_id
    INNER JOIN Category cat ON cat.id = prodcat.category_id
ORDER BY prod.name;
