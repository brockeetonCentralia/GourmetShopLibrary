SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE UpdateProduct
	@ProductId INT,
	@ProductName NVARCHAR(50),
	@SupplierId INT,
	@UnitPrice	DECIMAL(12,2),
	@Package NVARCHAR(30),
	@IsDiscontinued BIT
AS
BEGIN
	SET NOCOUNT ON;
	
	UPDATE Product SET ProductName =  @ProductName, SupplierId = @SupplierId, UnitPrice = @UnitPrice, Package = @Package, IsDiscontinued = @IsDiscontinued WHERE Id = @ProductId

END
GO