# FruitCSharp
Simple winforms CRUD demo with project-local database.
Main points demonstrated are 
- 1. Insert, Update, Delete with Entity Framework 6
- 2. How to use and bind a combobox column to a foreign key of entity
- 3. How to use and bind a checkbox column to boolean property of entity

The project-local database is (localdb) version 13 (SQL 2016)
If you do not have localdb or do not have version 2016  you will need to first install it before you can run this sample. **If your localdb instance is not named "MSSQLLocalDB", then you will need to update the connection string in app.config** to match your instance name. If you don't know the instance name you can use the command line utility to get information. On the command line, navigate to the location of sqllocaldb.exe (probably here: C:\Program Files\Microsoft SQL Server\130\Tools\Binn) and run "sqllocaldb i". This will list the instances you have installed. Run "sqllocaldb.exe" without any switches for a list of all options.

download sql local db here:
https://www.microsoft.com/en-us/download/details.aspx?id=52679

The code is commented and designed to be as minimal as possible. Here is an overview:

**FruitContext.cs**

This sets up the Entity Framework context in code-first style. The constructor takes the connection string name so it will locate the connection string within app.config and use our pre-existing database and not try to create one. The constructor also uses an initializer to seed a few rows of data in the database. Since the form is only going to edit the [Fruit] table, we must have some [GrowsOn] rows, otherwise we would not be able to create any for use in the grid's combo box column.

**Fruit.cs and GrowsOn.cs**

These are just Plain Old CLR Objects that mirror the database columns and table names.

**FruitEditForm.cs**
This is the actual UI. It has a grid with appropriate columns for editing the [Fruit] table. It demonstrates loading data and binding to the grid, and the combobox in the grid.It also demonstrates saving changes back to the database.
