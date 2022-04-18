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
ALTER PROCEDURE ProcAddReview
	-- Add the parameters for the stored procedure here
	@username VARCHAR(50),
	@outlet_name VARCHAR(50),
	@rating INT,
	@review_content VARCHAR(200)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	-- SET NOCOUNT ON;

    -- Insert statements for procedure here
	DECLARE @userid INT
	SELECT @userid = userid FROM Users WHERE username = @username

	DECLARE @outlet_id INT
	SELECT @outlet_id = outlet_id FROM Outlet WHERE outlet_name = @outlet_name

	INSERT INTO Review
	VALUES
	(
		@userid,
		@outlet_id,
		@rating,
		@review_content
	)
END
GO
