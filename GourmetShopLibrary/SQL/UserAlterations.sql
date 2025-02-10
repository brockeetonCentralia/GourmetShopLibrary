USE GourmetShop;

ALTER TABLE [Order]
DROP CONSTRAINT FK_ORDER_REFERENCE_CUSTOMER

EXEC sp_rename 'Customer.Id' , 'UserId' -- Changing Primary Key to new name
EXEC sp_rename 'Customer', 'Users' -- Changing Table name from customer to user
EXEC sp_rename 'Order.CustomerId', 'UserId' -- updating column name from customer id to userid in orders table

ALTER TABLE [Order]
ADD CONSTRAINT FKOrder_UserID FOREIGN KEY (UserId) REFERENCES Users(UserId)

ALTER TABLE Users 
ADD UserLogin NVARCHAR(25) NULL
 , UserPassword NVARCHAR(25) NULL

CREATE TABLE Roles (--Admin and customer --
	RoleID INT NOT NULL PRIMARY KEY IDENTITY(1,1)
	, RoleDescription NVARCHAR(255)
);

CREATE TABLE Users_Roles (
	UserRoleID INT NOT NULL PRIMARY KEY IDENTITY(1,1)
	, UserID INT FOREIGN KEY (UserID) REFERENCES Users(UserId) -- Current customer ID
	, RoleID INT FOREIGN KEY (RoleID) REFERENCES Roles(RoleID)
);

INSERT INTO Roles (RoleDescription)
VALUES ('Admin')
	,	('Customer');

-- Add all existing customers to the user role table
WITH ExistingCustomers 
AS
(
	SELECT UserId FROM Users
)

INSERT INTO Users_Roles (UserID)
SELECT UserID FROM ExistingCustomers

-- Assign all existing customers to the role of customer
UPDATE Users_Roles
	SET RoleID = 2 -- Customer, 1 for admin

-- Random Customers for testing
UPDATE Users	
	SET UserLogin = 'User1'
	, UserPassword = 'customer1'
FROM Users
	WHERE UserId = 5

UPDATE Users	
	SET UserLogin = 'User2'
	, UserPassword = 'customer2'
FROM Users
	WHERE UserId = 6

-- Random Customer gets to be a admin for testing

UPDATE Users
	SET UserLogin = 'User3'
	, UserPassword = 'admin3'
FROM Users
	WHERE UserId = 7

Update Users_Roles
	SET RoleID = 1
FROM Users_Roles
	WHERE UserID = 7


