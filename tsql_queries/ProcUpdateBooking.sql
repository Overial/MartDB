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
ALTER PROCEDURE ProcUpdateBooking
	-- Add the parameters for the stored procedure here
	@booking_id INT,
	@org_name VARCHAR(50),
	@area_id INT,
	@booking_start_date DATE,
	@booking_end_date DATE
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	-- SET NOCOUNT ON;

	DECLARE @org_id INT
	SELECT @org_id = org_id FROM Organisation WHERE org_name = @org_name

    -- Insert statements for procedure here
	UPDATE Booking
	SET	
		org_id = @org_id,
		area_id = @area_id,
		booking_start_date = @booking_start_date,
		booking_end_date = @booking_end_date
	WHERE
		booking_id = @booking_id
END
GO
