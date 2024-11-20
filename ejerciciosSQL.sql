-- ej1
SELECT CompanyName, ContactName, Country
FROM Customers
ORDER BY CompanyName ASC;

-- ej2
SELECT CompanyName, ContactName, Country
FROM Customers
WHERE CompanyName LIKE 'S%';

-- ej3
SELECT ProductName, UnitPrice
FROM Products
WHERE UnitPrice > 50;

-- ej4
SELECT COUNT(*) AS TotalDiscontinued
FROM Products
WHERE Discontinued = 1;

-- ej5
SELECT TOP 1 ProductName, UnitPrice
FROM Products
ORDER BY UnitPrice DESC;

-- ej6
SELECT ProductName, UnitPrice
FROM Products
WHERE UnitPrice = (SELECT MAX(UnitPrice) FROM Products);

-- ej7
SELECT P.ProductName, C.CategoryName
FROM Products P
INNER JOIN Categories C ON P.CategoryID = C.CategoryID; 

-- ej8
SELECT C.CustomerID, C.CompanyName, O.OrderID, O.OrderDate
FROM Customers C
LEFT JOIN Orders O ON C.CustomerID = O.CustomerID;

-- ej9
SELECT c.CustomerID, count(o.orderid) as cant_orders 
FROM Customers c 
LEFT JOIN Orders o on o.CustomerID = c.CustomerID
GROUP BY c.CustomerID

-- ej10
SELECT s.SupplierID, count(p.ProductID) as cant_prod_supp 
FROM Suppliers s
INNER JOIN Products p on p.SupplierID = s.SupplierID
GROUP BY s.SupplierID
HAVING count(p.ProductID) >3; 


CREATE PROCEDURE GetCustomersByCountry
    @Country NVARCHAR(50)
AS
BEGIN
    SELECT CustomerID, CompanyName, ContactName, Country
    FROM Customers
    WHERE Country = @Country;
END;

