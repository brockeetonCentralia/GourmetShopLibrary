SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Roberts, Rayleen
-- Create date: 02/06/2025
-- Description:	Add New Order Item
-- =============================================
CREATE PROCEDURE AddNewOrderItem 
	-- Add the parameters for the stored procedure here
	(@OrderId int = 0, 
	@ProductId int = 0,
	@UnitPrice decimal(12,2) = 0, 
	@Quantity int = 0)
AS
BEGIN
	INSERT INTO OrderItem
		(OrderId, ProductId, UnitPrice, Quantity)
	VALUES
		(@OrderId, @ProductID,@UnitPrice, @Quantity)
END
GO
