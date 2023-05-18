SELECT    
	   max(orderdate) as orderdate,
   CAST((
    MAX(CAST(orderdate AS FLOAT))
    + (
      MAX(CAST(orderdate AS FLOAT))
      - MIN(CAST(orderdate AS FLOAT))
    ) / (COUNT(*) - 1)
  ) AS DATETIME) LastOrderDate
  FROM Sales.Orders  ord

group by ord.orderid
HAVING
  COUNT(*) > 1