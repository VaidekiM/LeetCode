/* 1068 Product Sales Analysis I*/
Select p.product_name, s.year, s.price from Sales s
LEFT JOIN Product p on p.product_id = s.product_id;