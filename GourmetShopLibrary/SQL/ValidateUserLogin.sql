SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--CHANGE THE ALTER TO CREATE
ALTER PROCEDURE ValidateUserLogin
	@userName VARCHAR(50),
	@passWord VARCHAR(50)
AS
BEGIN

	SET NOCOUNT ON;

	DECLARE @UserRole NVARCHAR(20);

	IF EXISTS (SELECT 1 FROM Users WHERE userName = @userName AND passWord = @passWord)
		BEGIN
			SELECT @UserRole = Role FROM Users WHERE userName = @userName;
			SELECT 1 AS Result, @UserRole AS UserRole;
		END
	ELSE
		SELECT 0 As Result, NULL AS UserRole;

END
GO
