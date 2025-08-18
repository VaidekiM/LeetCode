/*  1211. Queries quality and percentage */
SELECT query_name, ROUND(AVG(q.rating/q.position), 2) as quality, 
ROUND(SUM(q.rating < 3)/COUNT(q.rating)*100,2) as poor_query_percentage
FROM Queries q
GROUP BY query_name;
