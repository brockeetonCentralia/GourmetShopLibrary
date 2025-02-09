USE [GourmetShop]
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Roberts, Rayleen
-- Create date: 02/09/2025
-- Description:	Get Order Item by ID
-- =============================================
CREATE PROCEDURE GetOrderItemByID 
	@ID int = 0
AS
BEGIN


    -- Insert statements for procedure here
	SELECT OrderId, ProductId, UnitPrice, Quantity
	FROM [dbo].[OrderItem]
	WHERE Id = @ID
END
GO

