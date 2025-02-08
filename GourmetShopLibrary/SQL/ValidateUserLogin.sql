SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--CHANGE THE ALTER TO CREATE
ALTER PROCEDURE ValidateUserLogin
	@UserLogin NVARCHAR(25),
	@UserPassword NVARCHAR(25),
	@RoleID INT OUTPUT
AS
BEGIN

	SET NOCOUNT ON;

	DECLARE @UserID INT;

	--Check if user exists and password matches

	SELECT @UserID = u.UserID
	FROM Users u
	WHERE u.UserLogin = @UserLogin AND u.UserPassword = @UserPassword;

	--If user does not exist, return
	IF @UserID IS NULL
    BEGIN
        SET @RoleID = NULL;
        RETURN;
    END
	--Get user's role
	SELECT TOP 1 @RoleID = r.RoleID
	FROM User_Roles ur
	WHERE ur.UserID = @UserID

	--Return user role
    IF @RoleID IS NULL
        SET @RoleID = 0;

END
GO
