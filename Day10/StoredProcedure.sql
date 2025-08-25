-- stored procedure without parameters
-- Procedure to get all students
CREATE PROCEDURE GetAllStudents
AS
BEGIN
    SELECT * FROM Students;
END;

-- Execute
EXEC GetAllStudents;


-- Stored procedure with parameters
-- Procedure to get student by ID
CREATE PROCEDURE GetStudentById
    @ID INT
AS
BEGIN
    SELECT * FROM Students WHERE StudentID = @ID;
END;

-- Execute
EXEC GetStudentById @ID = 2;