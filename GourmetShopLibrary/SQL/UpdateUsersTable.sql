USE [GourmetShop]
GO


SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Roberts, Rayleen
-- Create date: 02/06/2025
-- Description:	Update User Table
-- =============================================
CREATE PROCEDURE [dbo].[UdateUserTable] 
    (@Id int = 0,
	@FirstName nvarchar(40),
	@LastName nvarchar(50),
	@City nvarchar(40),
	@Country nvarchar(40),
	@Phone nvarchar(20),
	@UserLogin nvarchar(30),
	@UserPassword nvarchar(25))
AS
BEGIN
	UPDATE Users
		SET 
			FirstName = @FirstName,
			LastName = @LastName,
			City = @City,
			Country = @Country,
			Phone = @Phone,
			UserLogin = @UserLogin,
			UserPassword = @UserPassword

		WHERE UserId = @Id
END
GO


