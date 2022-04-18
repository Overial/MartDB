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
ALTER PROCEDURE ProcDeleteEmployee
	-- Add the parameters for the stored procedure here
	@org_name VARCHAR(50),
	@fio VARCHAR(50),
	@gender VARCHAR(1),
	@position VARCHAR(50),
	@phone_number VARCHAR(50),
	@email VARCHAR(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	-- SET NOCOUNT ON;

    -- Insert statements for procedure here
	DECLARE @org_id INT
	SELECT @org_id = org_id FROM Organisation WHERE org_name = @org_name

	DELETE FROM Employee
	WHERE
		org_id = @org_id AND
		fio = @fio AND
		gender = @gender AND
		position = @position AND
		phone_number = @phone_number AND
		email = @email
END
GO
