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
ALTER PROCEDURE ProcUpdateBookingDates
	-- Add the parameters for the stored procedure here
	@org_name VARCHAR(50),
	@area_id INT,
	@booking_start_date DATE,
	@booking_end_date DATE
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	-- SET NOCOUNT ON;

    -- Insert statements for procedure here
	DECLARE @org_id INT
	SELECT @org_id = org_id FROM Organisation WHERE org_name = @org_name

	UPDATE Booking
	SET
		booking_start_date = @booking_start_date,
		booking_end_date = @booking_end_date
	WHERE
		org_id = @org_id AND
		area_id = @area_id
END
GO
