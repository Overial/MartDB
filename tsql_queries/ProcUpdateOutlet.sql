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
ALTER PROCEDURE ProcUpdateOutlet
	-- Add the parameters for the stored procedure here
	@outlet_id INT,
	@org_name VARCHAR(50),
	@area_id INT,
	@outlet_name VARCHAR(50),
	@trade_profile_name VARCHAR(50),
	@timetable VARCHAR(50),
	@contact_person VARCHAR(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	-- SET NOCOUNT ON;

    -- Insert statements for procedure here
	DECLARE @org_id INT
	SELECT @org_id = org_id FROM Organisation WHERE org_name = @org_name

	UPDATE Outlet
	SET
		org_id = @org_id,
		area_id = @area_id,
		outlet_name = @outlet_name,
		trade_profile_name = @trade_profile_name,
		timetable = @timetable,
		contact_person = @contact_person
	WHERE
		outlet_id = @outlet_id
END
GO
