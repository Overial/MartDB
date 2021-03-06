USE [MartDB]
GO
/****** Object:  StoredProcedure [dbo].[ProcCreateBooking]    Script Date: 07.12.2021 13:20:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[ProcAddBooking]
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
	DECLARE @floor_number INT
	DECLARE @area_square INT
	
	SELECT
		@floor_number = floor_number,
		@area_square = area_square
	FROM Area WHERE area_id = @area_id

	DECLARE @price_for_square_meter_per_day INT
	SET @price_for_square_meter_per_day = 54

	DECLARE @lower_floor_coef INT
	SET @lower_floor_coef = 1

	DECLARE @higher_floor_coef INT
	SET @higher_floor_coef = 1.5

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

	DECLARE @org_id INT
	SELECT @org_id = org_id FROM Organisation WHERE org_name = @org_name

	INSERT INTO Booking
	VALUES
	(
		@org_id,
		@area_id,
		@area_cost,
		@booking_start_date,
		@booking_end_date
	)
END
