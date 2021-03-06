USE [GloriousFuture]
GO
/****** Object:  StoredProcedure [dbo].[usp_GetAccountDTOByName]    Script Date: 12/04/2012 07:37:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Danny Chen
-- Create date: 2012-12-02
-- Description:	AccountDTO store procedure
-- =============================================
Create PROCEDURE [dbo].[usp_GetAccountDTOByName] 
	@AccountName nvarchar(50)	
AS
BEGIN
	SELECT  
		A.AccountName
		,B.ACEENumber
		,A.Coins
		,A.Email
		,A.[Gender]
		,A.Id
		,A.IdentityCardNumber
		,A.QQ
		,B.Score
		,B.SpecialityType
		,B.[Year]
		,B.Zone_City
		,B.Zone_Province			
	From 
		Accounts A
	INNER JOIN 
		Achievements B
	ON 
		A.AccountName = B.AccountId
	WHERE 
		A.AccountName = @AccountName
		AND Year(B.[Year]) = Year(GETDATE())
END
GO