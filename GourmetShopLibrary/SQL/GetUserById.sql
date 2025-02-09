USE [GourmetShop]
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Roberts, Rayleen
-- Create date: 02/09/2025
-- Description:	Get User by ID
-- =============================================
CREATE PROCEDURE GetUserByID 
	@Id int = 0
AS
BEGIN


    -- Insert statements for procedure here
	SELECT UserId, FirstName, LastName, City, Country, Phone, UserLogin, UserPassword
	FROM [dbo].[Users]
	WHERE UserId = @Id
END
GO

