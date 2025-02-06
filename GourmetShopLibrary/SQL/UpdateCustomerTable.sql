USE [GourmetShop]
GO

/****** Object:  StoredProcedure [dbo].[UpdateProductTable]    Script Date: 2/6/2025 11:21:14 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Roberts, Rayleen
-- Create date: 01/27/2025
-- Description:	Update Product Table
-- =============================================
CREATE PROCEDURE [dbo].[UpdateCustomerTable] 
	(@Id int = 0,
	@FirstName nvarchar(40),
	@LastName nvarchar(40),
	@City nvarchar(40) ,
	@Country nvarchar(40),
	@Phone nvarchar(30) )


AS
BEGIN
	
	UPDATE Customer
		SET 
		FirstName = @FirstName,
		LastName = @LastName,
		City = @City,
		Country = @Country,
		Phone	= @Phone
		WHERE Id = @Id

END
GO