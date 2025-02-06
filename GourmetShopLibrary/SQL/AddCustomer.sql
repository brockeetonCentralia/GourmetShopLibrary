
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Roberts, Rayleen
-- Create date: 02/06/2025
-- Description:	Add New Customer
-- =============================================
CREATE PROCEDURE AddCustomer 
	-- Add the parameters for the stored procedure here
	(@FirstName nvarchar(40), 
	@LastName nvarchar(40) ,
	@City nvarchar(40) ,
	@Country nvarchar(40)  ,
	@Phone nvarchar(20) )



AS
BEGIN
	INSERT INTO Customer
		(FirstName, LastName, City, Country, Phone)
		VALUES
		( @FirstName, @LastName, @City, @Country, @Phone)
END
GO
