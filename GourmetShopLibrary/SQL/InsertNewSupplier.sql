
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Broc Keeton>
-- Create date: <1/7/2025>
-- Description:	<Stored procedure to input new suppliers into the supplier table.>
-- =============================================
CREATE PROCEDURE InsertNewSupplier
	@CompanyName NVARCHAR(40),
	@ContactName NVARCHAR(50),
	@ContactTitle NVARCHAR(40),
	@City NVARCHAR(40),
	@Country NVARCHAR(40),
	@Phone NVARCHAR(30),
	@Fax NVARCHAR(30)

AS
BEGIN
	INSERT INTO Supplier(CompanyName, ContactName, ContactTitle, City, Country, Phone, Fax) VALUES (@CompanyName, @ContactName, @ContactTitle, @City, @Country, @Phone, @Fax); 
END
GO
