-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE ProcAddOrg
	-- Add the parameters for the stored procedure here
	@org_name VARCHAR(50),
	@country VARCHAR(50),
	@payment_terms VARCHAR(50),
	@delivery_method VARCHAR(50),
	@contact_person VARCHAR(50),
	@userpassword VARCHAR(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	-- SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO Users
	VALUES
	(
		@org_name,
		@userpassword,
		'organisation'
	)

	INSERT INTO Organisation
	VALUES
	(
		@org_name,
		@country,
		@payment_terms,
		@delivery_method,
		@contact_person
	)
END
GO
