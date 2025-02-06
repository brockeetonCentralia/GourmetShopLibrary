SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--CHANGE THE ALTER TO CREATE
ALTER PROCEDURE ValidateUserLogin
	@UserLogin NVARCHAR(25),
	@UserPassword NVARCHAR(25)
AS
BEGIN

	SET NOCOUNT ON;

	DECLARE @UserID INT;
	DECLARE @RoleID INT;

	--Check if user exists and password matches

	SELECT @UserID = u.UserID
	FROM Users u
	WHERE u.UserLogin = @UserLogin AND u.UserPassword = @UserPassword;

	--If user does not exist, return
	IF @UserID IS NULL
    BEGIN
        PRINT 'Invalid username or password';
        RETURN;
    END
	--Get user's role
	SELECT TOP 1 @RoleID = r.RoleID
	FROM User_Roles ur
	JOIN Roles r ON ur.RoleID = r.RoleID
	WHERE ur.UserID = @UserID

	--Return user role
	IF @RoleID IS NOT NULL
		PRINT 'RoleID: ' + CAST(@RoleID AS NVARCHAR(10));
    ELSE
        PRINT 'User has no assigned role';

END
GO
