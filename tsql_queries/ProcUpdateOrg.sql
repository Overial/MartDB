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
ALTER PROCEDURE ProcUpdateOrg
	-- Add the parameters for the stored procedure here
	@org_id INT,
	@old_org_name VARCHAR(50),
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
	IF @userpassword <> '' BEGIN
		UPDATE Users
		SET userpassword = @userpassword
		WHERE username = @old_org_name
	END

	UPDATE Users
	SET username = @org_name
	WHERE username = @old_org_name

	UPDATE Organisation
	SET
		org_name = @org_name,
		country = @country,
		payment_terms = @payment_terms,
		delivery_method = @delivery_method,
		contact_person = @contact_person
	WHERE
		org_id = @org_id
END
GO
