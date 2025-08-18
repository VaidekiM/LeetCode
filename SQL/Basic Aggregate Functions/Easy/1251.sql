/* 1251. Average Selling Price */
SELECT p.product_id, IFNULL(ROUND((SUM(P.price * U.units)/SUM(U.units)), 2), 0) average_price
FROM Prices P
LEFT JOIN UnitsSold U
ON P.product_id = U.product_id AND purchase_date BETWEEN P.start_date AND P.end_date
GROUP BY P.product_id;