USE [GourmetShop]
GO

/****** Object:  StoredProcedure [dbo].[DeleteUserByID]    Script Date: 2/9/2025 12:11:11 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		Roberts,Rayleen
-- Create date: 01/27/2025
-- Description:	Delete Product Record by ID
-- =============================================
CREATE PROCEDURE [dbo].[DeleteUserByID] 
	(@Id int = 0)
AS
BEGIN
	DELETE FROM Users
	Where UserId = @Id 
END
GO


