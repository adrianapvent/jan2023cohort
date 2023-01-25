-- https://www.w3schools.com/MySQL/mysql_sql.asp - all the commands
-- example database (non editable so select practice only) https://www.w3schools.com/MySQL/trymysql.asp?filename=trysql_select_all
-- same database but editable https://www.w3schools.com/sql/trysql.asp?filename=trysql_select_where

-- READ / GET / SELECT

SELECT * FROM Customers; 
-- Get all entries from the customers table
SELECT * FROM Customers WHERE City='London';
-- Get all entries from teh customers table that have London as their city
SELECT * FROM Customers WHERE City='London' AND PostalCode LIKE 'W%';
-- Get all entries from customers that have London as their city and a postal code starting with W
SELECT * FROM Customers WHERE CustomerID=4;
-- Select all from customers wehre the id is 4
SELECT * FROM app_user LEFT JOIN app_favorite ON app_user.id = app_favorite.user_id WHERE app_user.id = 1;
-- Creates a new temp tables where it pulls all the images from the favorite talbe that user 1 created
SELECT * FROM app_user JOIN app_favorite ON app_user.id = app_favorite.user_id;
-- Creates a new temp table where is just combines and matches info form both tables.

-- CREATE / INSERT

insert into Customers (CustomerName, ContactName, Address, City, PostalCode, Country) values ("Jane Doe", "Bob Ross", "123 Main St", "Nowhere", "12345", "USA");
-- add to the customers table the values in ()

insert into Customers (CustomerName, ContactName, Address, City, PostalCode, Country) values ("Harry Poter", "Hagrid", "123 Main St", "Nowhere", "12345", "USA"), ("Proffesor Snape", "Dumbledor", "123 Main St", "Nowhere", "12345", "USA");
-- Adding 2 entries at one time.  Just need to copy the last part with the values

insert into Customers (CustomerName, ContactName, Address, City, PostalCode, Country) values ("Harry Poter", "Hagrid", "123 Main St", "Nowhere", "12345", "USA"), ("Proffesor Snape", "Dumbledor", "123 Main St", "Nowhere","", "USA");
-- If you have all the columns listed but no information for 1 be sure to still include it on the values side

insert into Customers (CustomerName, ContactName, Address, City, Country) values ("Proffesor Snape", "Dumbledor", "123 Main St", "Nowhere","USA");
-- You can also just leave out that column name and not worry about the empty string (as long as it is not a required column)

-- DELETE

delete from Customers where CustomerID=8;
-- Remove from the customers table the object that has the id of 8

delete from Customers where Country = 'UK';
-- remove form customers tables the objects that have the country of UK


-- UPDATE / PUT / PATCH / EDIT
update Customers set CustomerName='No Soup' where CustomerID=15;
-- Updated the customers tables the column specified to the value listed for the object that has an id of 15

update Customers set Country='USA' where Country='Canada';
-- Update the customers table to set the country to usa where it was canada