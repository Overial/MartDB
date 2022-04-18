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
ALTER PROCEDURE ProcUpdateOutletRating
	-- Add the parameters for the stored procedure here
	@outlet_name VARCHAR(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	-- SET NOCOUNT ON;

    -- Insert statements for procedure here
	DECLARE @outlet_id INT
	SELECT @outlet_id = outlet_id FROM Outlet WHERE outlet_name = @outlet_name

	DECLARE @new_rating DECIMAL(10,1)
	SET @new_rating = 0.0
	
	IF EXISTS (SELECT * FROM Review WHERE outlet_id = @outlet_id) BEGIN
		SELECT @new_rating = AVG(CAST(rating AS DECIMAL(10,1))) FROM Review WHERE outlet_id = @outlet_id
	END

	UPDATE Outlet
	SET rating = @new_rating
	WHERE outlet_id = @outlet_id
END
GO
