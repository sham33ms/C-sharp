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