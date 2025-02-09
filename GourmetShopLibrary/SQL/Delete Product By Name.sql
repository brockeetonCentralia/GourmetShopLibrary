USE [GourmetShop]
GO

/****** Object:  StoredProcedure [dbo].[DeleteProductByName]    Script Date: 2/6/2025 7:10:33 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Roberts, Rayleen
-- Create date: 01/27/2025
-- Description:	Delete Record From Product Table
-- =============================================
CREATE PROCEDURE [dbo].[DeleteProductByName] 
	(@ProductName nvarchar(50))
AS
BEGIN
	DELETE FROM Product
	WHERE ProductName = @ProductName
END
GO


