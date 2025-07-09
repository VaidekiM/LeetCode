/* 197 Rising Temperature */
SELECT ys.id FROM Weather ys 
CROSS JOIN Weather t 
ON DATEDIFF(ys.recordDate, t.recordDate) = 1
WHERE ys.temperature > t.temperature;