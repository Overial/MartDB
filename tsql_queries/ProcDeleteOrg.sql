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
ALTER PROCEDURE ProcDeleteOrg
	-- Add the parameters for the stored procedure here
	@org_id INT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	-- SET NOCOUNT ON;

    -- Insert statements for procedure here
	DECLARE @org_name VARCHAR(50)
	SELECT @org_name = org_name FROM Organisation WHERE org_id = @org_id

	IF NOT EXISTS (SELECT * FROM Booking WHERE org_id = @org_id) BEGIN
		DELETE FROM Users
		WHERE username = @org_name
	END

	DELETE FROM Organisation
	WHERE org_id = @org_id
END
GO
