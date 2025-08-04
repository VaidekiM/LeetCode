/* 570. Managers with at least 5 direct reports */
SELECT e1.name from Employee e1
INNER JOIN Employee m
ON e1.id = m.managerId
GROUP BY m.managerId
HAVING COUNT(m.managerId) >= 5;