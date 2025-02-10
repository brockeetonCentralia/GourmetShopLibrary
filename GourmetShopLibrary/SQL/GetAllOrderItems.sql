USE [GourmetShop]
GO
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		Roberts, Rayleen
-- Create date: 02/09/2025
-- Description:	GetAllOrders
-- =============================================
CREATE PROCEDURE [dbo].[GetAllOrderItems] 
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT Id, OrderId, ProductId, UnitPrice, Quantity
	FROM [dbo].[OrderItem]
END
GO


