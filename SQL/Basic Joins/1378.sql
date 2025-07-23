/* 1378. Replace Employee ID With The Unique Identifier */
Select u.unique_id, e.name from Employees e
LEFT JOIN EmployeeUNI u on e.id = u.id;