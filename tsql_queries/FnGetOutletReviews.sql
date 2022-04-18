-- ================================================
-- Template generated from Template Explorer using:
-- Create Multi-Statement Function (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the function.
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
ALTER FUNCTION FnGetOutletReviews
(
	@outlet_name VARCHAR(50)
)
RETURNS 
@outlet_reviews_table TABLE
(
	review_id INT,
	userid INT,
	rating INT,
	review_content VARCHAR(200),
	username VARCHAR(50)
)
AS
BEGIN
	-- Fill the table variable with the rows for your result set
	INSERT INTO @outlet_reviews_table
		SELECT
			Review.review_id,
			Users.userid,
			Review.rating,
			Review.review_content,
			Users.username
		FROM Review
        JOIN Users ON Review.userid = Users.userid
        JOIN Outlet ON Review.outlet_id = Outlet.outlet_id
		WHERE
			outlet_name = @outlet_name
	RETURN 
END
GO
