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