USE [ThucTap]
GO
/****** Object:  StoredProcedure [dbo].[INSERT_KHOA]    Script Date: 7/29/2023 3:05:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[INSERT_KHOA]
	-- Add the parameters for the stored procedure here
	@NAME NVARCHAR(10),
	@DETAIL NVARCHAR(100),
	@PHONE NVARCHAR(10)

AS
BEGIN
	INSERT INTO TBLKhoa
VALUES(@NAME, @DETAIL, @PHONE)
END
