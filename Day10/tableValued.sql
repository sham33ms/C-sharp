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
RETURNS @AdultStudents1 TABLE
(
    ID INT,
    Name1 VARCHAR(50),
    Age1 INT
)
AS
BEGIN
    INSERT INTO @AdultStudents1
    SELECT StudentID, Name, Age
    FROM Students
    WHERE Age >= 18;

    -- You can add more logic or inserts here if needed

    RETURN;
END;

SELECT * FROM dbo.GetAdultStudents();
