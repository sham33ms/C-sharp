-- Create table
CREATE TABLE Students (
    StudentID INT PRIMARY KEY,
    Name VARCHAR(50),
    Age INT
);

-- Insert data
INSERT INTO Students (StudentID, Name, Age)
VALUES (1, 'Shameem', 20),
       (2, 'Rahul', 17),
       (3, 'Anitha', 23),
       (4, 'Kavya', 28);

INSERT INTO Students (StudentID, Name, Age)
VALUES (5, 'Leo', 20),
       (6, 'Vikram', 17),
       (7, 'Dilli', 23),
       (8, 'Deva', 28);

-- Check data
SELECT * FROM Students;



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


-- User defined fun 

-- Scalar function 
CREATE FUNCTION GetAgeCategory (@Age INT)
RETURNS VARCHAR(20)
AS
BEGIN
    DECLARE @Category VARCHAR(20);

    IF @Age < 18
        SET @Category = 'Minor';
    ELSE IF @Age BETWEEN 18 AND 25
        SET @Category = 'Young Adult';
    ELSE
        SET @Category = 'Adult';

    RETURN @Category;
END;


SELECT Name, Age, dbo.GetAgeCategory(Age) AS AgeGroup
FROM Students;


--
CREATE FUNCTION GetById(@Age INT)       
RETURNS VARCHAR(20)                    
AS
BEGIN
    DECLARE @category VARCHAR(20);     

    IF @Age < 18                       
        SET @category = 'Minor';
    ELSE
        SET @category = 'Major';

    RETURN @category;                  
END;


select name , dbo.Getbyid(Age) as Category
From students;


SELECT ASCII('hello') as asciii; 


--inline table valueed funtion 
CREATE FUNCTION GetStudentsAboveAge(@MinAge INT)
RETURNS TABLE
AS
RETURN (
    SELECT * FROM Students WHERE Age > @MinAge
);

SELECT * FROM dbo.GetStudentsAboveAge(20);


--Multi statement table valued function 
CREATE FUNCTION GetAdultStudents()
RETURNS @AdultStudents TABLE
(
    StudentID INT,
    Name VARCHAR(50),
    Age INT
)
AS
BEGIN
    INSERT INTO @AdultStudents
    SELECT StudentID, Name, Age
    FROM Students
    WHERE Age >= 18;

    -- You can add more logic or inserts here if needed

    RETURN;
END;

SELECT * FROM dbo.GetAdultStudents();

