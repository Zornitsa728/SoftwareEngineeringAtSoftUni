SELECT * FROM Departments

SELECT Name FROM Departments

SELECT FirstName, LastName, Salary FROM Employees

SELECT FirstName, MiddleName, LastName FROM Employees

SELECT FirstName + '.' + LastName + '@softuni.bg'
    AS [Full Email Address]
FROM Employees

SELECT 
DISTINCT Salary 
    FROM Employees

SELECT * 
  FROM Employees 
 WHERE JobTitle = 'Sales Representative'

 SELECT  FirstName, LastName, JobTitle
  FROM Employees 
 WHERE Salary BETWEEN 20000 AND 30000

 SELECT FirstName + ' ' + MiddleName + ' ' + LastName
     AS 'Full Name'
   FROM Employees
  WHERE Salary = 25000 OR Salary = 14000 OR Salary = 12500 OR Salary = 23600
   
SELECT * FROM Departments

SELECT FirstName, LastName 
  FROM Employees
  WHERE ManagerID IS NULL

  SELECT FirstName, LastName, Salary 
  FROM Employees
  WHERE Salary > 50000 
  ORDER BY Salary DESC

  SELECT TOP 5 FirstName, LastName
  FROM Employees
  ORDER BY Salary DESC

  SELECT FirstName, LastName
    FROM Employees
   WHERE DepartmentID NOT IN (4)

   SELECT *
     FROM Employees
 ORDER BY Salary DESC,
 FirstName ASC,
 LastName DESC,
 MiddleName ASC
 
 CREATE VIEW V_EmployeesSalaries AS
 SELECT FirstName, LastName, Salary
   FROM Employees

   SELECT * FROM V_EmployeesSalaries

--17.   
   CREATE VIEW V_EmployeeNameJobTitle AS
        SELECT FirstName + ' ' + COALESCE(MiddleName, '') + ' ' + LastName AS [Full Name],
               JobTitle
          FROM Employees

   SELECT * FROM V_EmployeeNameJobTitle

   --CREATE VIEW V_EmployeeNameJobTitle AS
   --     SELECT 
   -- CONCAT(FirstName, ' ', COALESCE(MiddleName, ''), ' ', LastName) AS [Full Name],
   --            JobTitle
   --       FROM Employees

   SELECT DISTINCT JobTitle
   FROM Employees

   SELECT TOP(10) *
         FROM Projects
     ORDER BY StartDate,
              [Name]
--20.
SELECT TOP(7) FirstName, LastName, HireDate
         FROM Employees
     ORDER BY HireDate DESC
--21.
	 UPDATE Employees
	 SET Salary += Salary * 0.12
	 WHERE DepartmentID IN (1, 2, 4, 11)

    SELECT Salary
	  FROM Employees

	   UPDATE Employees
	 SET Salary -= Salary * 0.12
	 WHERE DepartmentID = 1 OR
	       DepartmentID = 2 OR
		   DepartmentID = 4 OR
		   DepartmentID = 11

