/* Write your T-SQL query statement below */

IF (SELECT COUNT(DISTINCT E.SALARY)  FROM Employee E) < 2
BEGIN
    SELECT NULL as SecondHighestSalary 
END
ELSE
BEGIN
    SELECT TOP 1 E.SALARY as SecondHighestSalary
    FROM (
    SELECT DISTINCT TOP 2 E.SALARY
    FROM Employee as E
    ORDER BY E.SALARY DESC
    ) as E
    ORDER BY E.SALARY ASC 
END