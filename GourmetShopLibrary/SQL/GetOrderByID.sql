USE [GourmetShop]
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Roberts, Rayleen
-- Create date: 02/09/2025
-- Description:	Get Order by ID
-- =============================================
CREATE PROCEDURE GetOrderByID 
	@ID int = 0
AS
BEGIN


    -- Insert statements for procedure here
	SELECT OrderDate, OrderNumber, UserId, TotalAmount
	FROM [dbo].[Order]
	WHERE Id = @ID
END
GO

