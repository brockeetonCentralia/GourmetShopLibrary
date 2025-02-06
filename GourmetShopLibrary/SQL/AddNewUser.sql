
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Roberts, Rayleen
-- Create date: 02/06/2025
-- Description:	Add New User
-- =============================================
CREATE PROCEDURE AddNewUser 
	-- Add the parameters for the stored procedure here
	(@FirstName nvarchar(40) = 0, 
	@LastName nvarchar(40) = 0,
	@City nvarchar(40) = 0,
	@Country nvarchar(40) = 0,
	@Phone nvarchar(20) = 0,
	@UserLogin nvarchar(25) = 0,
	@UserPassword nvarchar(25) = 0)
AS
BEGIN
	INSERT INTO [dbo].[Users]
	(FirstName, LastName, City, Country, Phone, UserLogin, UserPassword)
	
	VALUES
	(@FirstName, @LastName, @City, @Country, @Phone, @UserLogin, @UserPassword)



END
GO