Select ID,  ChiefId, Level
From Employee
CONNECT BY PRIOR ID = ChiefId;






/*SELECT employee_id, last_name, manager_id, LEVEL
   FROM employees
   CONNECT BY PRIOR employee_id = manager_id;*/