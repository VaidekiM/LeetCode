/* Employee Bonus */
SELECT emp.name, b.bonus 
FROM EMPLOYEE emp
LEFT JOIN Bonus b 
ON emp.empID = b.empID
WHERE b.bonus < 1000 OR b.bonus IS NULL;