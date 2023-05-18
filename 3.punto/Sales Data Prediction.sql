select MAX(cust.companyname), MAX(ord.orderdate) ,
CAST((
    MAX(CAST(ord.orderdate AS FLOAT))
    + (
      MAX(CAST(ord.orderdate AS FLOAT))
      - MIN(CAST(ord.orderdate AS FLOAT))
    ) / (COUNT(*) - 0)
  ) AS DATETIME) LastOrderDate

from Sales.Customers as cust
left join (SELECT    max(custid)as custid,
	   max(orderdate) as orderdate
   
  FROM Sales.Orders  ord

group by ord.orderid ) ord on ord.custid = cust.custid 

group by cust.custid  HAVING
  COUNT(*) > 0 order by 1 asc