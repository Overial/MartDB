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
ALTER PROCEDURE ProcAddOutlet
	-- Add the parameters for the stored procedure here
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

	DECLARE @org_id INT
	SELECT @org_id = org_id FROM Organisation WHERE org_name = @org_name

    -- Insert statements for procedure here
	INSERT INTO Outlet
	VALUES
	(
		@org_id,
		@area_id,
		@outlet_name,
		@trade_profile_name,
		@timetable,
		0.0,
		@contact_person
	)
END
GO
