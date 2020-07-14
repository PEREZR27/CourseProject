use Northwind

-- 1. What are the Regions?
select * 
  from Region;
  --2. what are the cities?
  select*
    from Territories;
 select T.TerritoryDescription as Cities
   from Territories as T;
 select distinct T.TerritoryDescription as Cities
   from Territories as T
   order by Cities desc;
   --3. what are the cities in the southern region?
   select RegionID
     from Region
	 where RegionDescription like 'South%';
   select distinct T.TerritoryDescription as Cities, T.RegionID
     from Territories as T
	 where T.RegionID = 4
     order by Cities desc;
	 --4. number 3 with fully qualified column names
	 select distinct Territories.TerritoryDescription as Cities, Territories.RegionID
     from Territories
	 where Territories.RegionID = 4
     order by Cities desc;
	 --5. number 3 with an alias
	 select distinct T.TerritoryDescription as Cities, T.RegionID
     from Territories as T
	 where T.RegionID = 4
     order by Cities desc;
--6. What is the contact name telephone number and city for each customer.
select C.ContactName, C.CompanyName, C.Phone, C.City
  from Customers as C;
  --7. What are the products currently out of stock?
  select *
     from Products
	 where Discontinued = 0
	 and UnitsInStock = 0;
     -- 8. What are the 10 products in stock with the least amount on hand?
	 select top(10) *
     from Products
	 where Discontinued > 0
	 order by UnitsInStock asc;
	 --9. What are the most expensive products?
	 select top(5)*
     from Products
	 where Discontinued = 0 or UnitsInStock > 0
	 order by UnitPrice desc;
	 --10.How many products does Northwind have? How many customers? How many suppliers?
	 select count(*)
	  from Products as ProductCount;
	 select count(*)
	  from Customers as CustomerCount;
	 select count(*)
	  from Suppliers as SuppliersCount;

