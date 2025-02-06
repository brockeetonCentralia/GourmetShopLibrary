
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Roberts, Rayleen
-- Create date: 02/06/2025
-- Description:	Add New Order
-- =============================================
CREATE PROCEDURE AddOrder 
	-- Add the parameters for the stored procedure here
	(@OrderDate datetime, 
	@OrderNumber nvarchar(10),
	@CustomerID int,
	@TotalAmount decimal(12,2))

AS
BEGIN

		INSERT INTO [dbo].[Order]
		(OrderDate, OrderNumber, CustomerId, TotalAmount)
		VALUES
		( @OrderDate, @OrderNumber, @CustomerID, @TotalAmount)
END
GO
