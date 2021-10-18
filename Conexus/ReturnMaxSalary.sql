SELECT Name, 
MAX(SALARY) max_salary 
FROM Employee 
GROUP BY Name;

