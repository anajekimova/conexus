Select DepartmentID, Name,
(Count(ID) / Sum(Salary))*10000 id_salary
From Employee
Group by DepartmentID, Name