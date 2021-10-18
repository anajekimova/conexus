Select DepartmentID, Name,
(Count(ID) / Sum(Salary))*10000 id_salary /*Ja ne pielikt 10000 tad viņš aprēķina skaitli ar daudziem nullēm . Piemēram 0.00034778.*/
From Employee
Group by DepartmentID, Name