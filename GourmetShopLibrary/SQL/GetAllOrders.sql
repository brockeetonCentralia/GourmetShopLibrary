USE [GourmetShop]
GO

/****** Object:  StoredProcedure [dbo].[GetAllSuppliers]    Script Date: 2/9/2025 12:47:12 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		Roberts, Rayleen
-- Create date: 02/09/2025
-- Description:	GetAllOrders
-- =============================================
CREATE PROCEDURE [dbo].[GetAllOrders] 
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT Id, OrderDate, OrderNumber, UserID, TotalAmount
	FROM [dbo].[Order]
END
GO