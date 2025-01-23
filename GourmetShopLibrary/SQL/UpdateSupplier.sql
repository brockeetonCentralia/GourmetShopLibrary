SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE UpdateSupplier
	@SupplierId INT,
	@CompanyName NVARCHAR(40),
	@ContactName NVARCHAR(50),
	@ContactTitle NVARCHAR(40),
	@City NVARCHAR(40),
	@Country NVARCHAR(40),
	@Phone NVARCHAR(30),
	@Fax NVARCHAR(30)
AS
BEGIN
	SET NOCOUNT ON;
	
	UPDATE Supplier SET ContactName = @ContactName, CompanyName = @CompanyName, ContactTitle = @ContactTitle, City = @City, Country = @Country, Phone = @Phone, Fax = @Fax WHERE Id = @SupplierID

END
GO