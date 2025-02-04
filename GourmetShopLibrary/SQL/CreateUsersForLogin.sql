USE GourmetShop;

CREATE TABLE Users (
	UserId INT PRIMARY KEY,
	userName VARCHAR(50),
	passWord VARCHAR(50),
	Role VARCHAR(20)
);

INSERT INTO Users (
	UserId,
	userName,
	passWord,
	Role
)
VALUES (
	'1',
	'user1',
	'password',
	'User'
);

INSERT INTO Users (
	UserId,
	userName,
	passWord,
	Role
)
VALUES (
	'2',
	'admin1',
	'password',
	'Admin'
);

