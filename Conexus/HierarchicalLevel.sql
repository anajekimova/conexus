Select ID, DepartmentID, Name, ChiefId, 1 As Level
    From Employee 
	Where ChiefId IS NULL
	