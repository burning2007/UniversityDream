USE [GloriousFuture]
GO
/****** Object:  StoredProcedure [dbo].[usp_AccountsSelectByName]    Script Date: 12/03/2012 15:29:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_AccountsSelectByName] 
    @Name nvarchar(50)
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  

	BEGIN TRAN

	SELECT [Id], [AccountName], [Password], [Email], [QQ], [Coins], [IsLocked], [IdentityCardNumber], [Name], [ActivationCode], [IsActive], [Gender] 
	FROM   [dbo].[Accounts] 
	WHERE  ([AccountName] = @Name) 

	COMMIT
	

/****** Object:  StoredProcedure [dbo].[usp_AccountsCheckExistByName]    Script Date: 12/03/2012 16:38:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_AccountsCheckExistByName] 
    @Name NVARCHAR(50),
    @isExist AS BIT OUT
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  

	BEGIN TRAN
	IF EXISTS(SELECT * FROM [dbo].[Accounts] WHERE ([AccountName] = @Name))
	  SET @isExist = 1
	ELSE
		SET @isExist = 0  

	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_AccountsCheckExistById]    Script Date: 12/03/2012 16:38:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_AccountsCheckExistById] 
    @Id UNIQUEIDENTIFIER,
    @isExist AS BIT OUT
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  

	BEGIN TRAN
	IF EXISTS(SELECT * FROM [dbo].[Accounts] WHERE ([Id] = @Id))
	  SET @isExist = 1
	ELSE
		SET @isExist = 0  

	COMMIT
GO
