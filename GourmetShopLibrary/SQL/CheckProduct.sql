USE [GourmetShop]
GO
/****** Object:  StoredProcedure [dbo].[DeleteSupplier]    Script Date: 1/27/2025 10:33:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE CheckProduct
	@SupplierId INT

AS
BEGIN
	SET NOCOUNT ON;
	
	SELECT COUNT(*) FROM Product WHERE Id = @SupplierId

END
