USE [GourmetShop]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Roberts, Rayleen
-- Create date: 02/06/25
-- Description:	
-- =============================================
CREATE PROCEDURE [dbo].[GetAllUsers] 
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT UserId, (LastName + ', ' + FirstName) AS UserName, City, Country, Phone, UserLogin, UserPassword 
	FROM Users
END
GO


