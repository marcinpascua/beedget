--ROLES
INSERT INTO Roles(RoleName)
VALUES
('User'),
('Admin');

--BUDGET TYPE
INSERT INTO BudgetType(Name)
VALUES
('Savings'),
('Expense');

--LOG IN
SELECT * FROM Users
WHERE Username = 'marcinpascua'

--DELETE USERS
DELETE FROM Users
WHERE UserID = 0

--REGISTER
INSERT INTO Users(Username, Password, Email, RoleID)
VALUES
('Marcinpascua', 'marcin1101', 'marcinpascua@gmail.com', 2),
('BenedictAvenido', 'benedict0426', 'benedictavenido@gmail.com', 1);

SELECT * FROM Users
INNER JOIN Roles ON Users.RoleID = Roles.RoleID

--ADD BUDGET(SAVINGS)
INSERT INTO Budget(Title, TargetAmount, CurrentAmount, DateAdded, TargetDate,
isAchieved, UserID, BudgetTypeID)
VALUES
('Nike Shoes', 7000, 3000, GETDATE(), '2026-01-30', 0, 2, 1)

--ADD BUDGET(EXPENSE)
INSERT INTO Budget(Title, TargetAmount, CurrentAmount, DateAdded, TargetDate,
isAchieved, UserID, BudgetTypeID)
VALUES
('Grocery', NULL, 1000, GETDATE(), NULL, 0, 2, 2)

--DELETE BUDGET
DELETE FROM Budget
WHERE BudgetID = 0


SELECT * FROM Budget
INNER JOIN Users ON Budget.UserID = Users.UserID


