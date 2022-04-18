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
ALTER PROCEDURE ProcUpdateBookingCost
	-- Add the parameters for the stored procedure here
	@booking_id INT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	-- SET NOCOUNT ON;

    -- Insert statements for procedure here
	DECLARE @floor_number INT
	DECLARE @area_square INT

	SELECT
		@floor_number = Area.floor_number,
		@area_square = Area.area_square
	FROM Booking
	JOIN Area ON Booking.area_id = Area.area_id
	WHERE booking_id = @booking_id

	DECLARE @price_for_square_meter_per_day INT
	SET @price_for_square_meter_per_day = 54

	DECLARE @lower_floor_coef INT
	SET @lower_floor_coef = 1

	DECLARE @higher_floor_coef INT
	SET @higher_floor_coef = 1.5

	DECLARE @booking_start_date DATE
	DECLARE @booking_end_date DATE
	SELECT
		@booking_start_date = booking_start_date,
		@booking_end_date = booking_end_date
	FROM Booking
	WHERE booking_id = @booking_id

	DECLARE @date_diff INT
	SET @date_diff = DATEDIFF(DAY, @booking_start_date, @booking_end_date)

	DECLARE @area_cost INT
	SET @area_cost = 0

	IF @floor_number <= 3 BEGIN
		SET @area_cost = @area_square * @price_for_square_meter_per_day * @lower_floor_coef * @date_diff
	END
	ELSE IF @floor_number <= 6 BEGIN
		SET @area_cost = @area_square * @price_for_square_meter_per_day * @higher_floor_coef * @date_diff
	END

	UPDATE Booking
	SET cost = @area_cost
	WHERE booking_id = @booking_id
END
GO
