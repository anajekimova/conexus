Select ChiefId,
count(*) count_employee
From Employee
Where ChiefId = ID
Group by ChiefId

