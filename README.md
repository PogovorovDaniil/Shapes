# Вопрос 1
Напишите на C# библиотеку для поставки внешним клиентам, которая умеет вычислять площадь круга по радиусу и треугольника по трем сторонам. Дополнительно к работоспособности оценим:
- Юнит-тесты
- Легкость добавления других фигур
- Вычисление площади фигуры без знания типа фигуры в compile-time
- Проверку на то, является ли треугольник прямоугольным

*Решение задачи в коде*

# Вопрос 2
В базе данных MS SQL Server есть продукты и категории. Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов. Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории». Если у продукта нет категорий, то его имя все равно должно выводиться.
По возможности — положите ответ рядом с кодом из первого вопроса.

## Создание таблицы товаров:
```sql
CREATE TABLE "Products" (
	"Id"	INTEGER NOT NULL,
	"Name"	TEXT NOT NULL,
	PRIMARY KEY("Id" AUTOINCREMENT)
);
```

## Создание таблицы категорий:
```sql
CREATE TABLE "Categories" (
	"Id"	INTEGER NOT NULL,
	"Name"	TEXT NOT NULL,
	PRIMARY KEY("Id" AUTOINCREMENT)
);
```

## Создание развязочной таблицы:
```sql
CREATE TABLE "ProductToCategories" (
	"ProductId"	INTEGER NOT NULL,
	"CategoryId"	INTEGER NOT NULL,
	FOREIGN KEY("ProductId") REFERENCES "Products"("Id"),
	FOREIGN KEY("CategoryId") REFERENCES "Categories"("Id"),
	PRIMARY KEY("ProductId","CategoryId")
);
```

## Заполняем таблицы данными
```sql
INSERT INTO "main"."Products" ("Name") VALUES ('Чайник');
INSERT INTO "main"."Products" ("Name") VALUES ('Фен');
INSERT INTO "main"."Products" ("Name") VALUES ('Стиральная машина');
INSERT INTO "main"."Products" ("Name") VALUES ('Микроволновая печь');
INSERT INTO "main"."Products" ("Name") VALUES ('Зубная электрощетка');
INSERT INTO "main"."Products" ("Name") VALUES ('Швейная машина');

INSERT INTO "main"."Categories" ("Name") VALUES ('Ванные приборы');
INSERT INTO "main"."Categories" ("Name") VALUES ('Кухонная утварь');
INSERT INTO "main"."Categories" ("Name") VALUES ('Прибора для красоты и здоровья');

INSERT INTO "main"."ProductToCategories" ("ProductId", "CategoryId") VALUES ('1', '1');
INSERT INTO "main"."ProductToCategories" ("ProductId", "CategoryId") VALUES ('4', '1');
INSERT INTO "main"."ProductToCategories" ("ProductId", "CategoryId") VALUES ('3', '2');
INSERT INTO "main"."ProductToCategories" ("ProductId", "CategoryId") VALUES ('5', '2');
INSERT INTO "main"."ProductToCategories" ("ProductId", "CategoryId") VALUES ('2', '2');
INSERT INTO "main"."ProductToCategories" ("ProductId", "CategoryId") VALUES ('2', '3');
```

## Решение задачи:
```sql
SELECT Products.Name ProductName, Categories.Name CategoryName
FROM Products
LEFT JOIN ProductToCategories ON ProductId = Products.Id
LEFT JOIN Categories ON CategoryId = Categories.Id
```
