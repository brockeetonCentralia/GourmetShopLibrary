
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Broc Keeton>
-- Create date: <1/7/2025>
-- Description:	<Stored procedure to input new products into the product table.>
-- =============================================
CREATE PROCEDURE InsertNewProduct
	@ProductName NVARCHAR(50),
	@SupplierId INT,
	@UnitPrice	DECIMAL(12,2),
	@Package NVARCHAR(30),
	@IsDiscontinued BIT

AS
BEGIN
	INSERT INTO Product (ProductName, SupplierId, UnitPrice, Package, IsDiscontinued) VALUES (@ProductName, @SupplierId, @UnitPrice, @Package, @IsDiscontinued); 
END
GO
