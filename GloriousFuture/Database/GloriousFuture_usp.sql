USE [GloriousFuture]
GO
/****** Object:  StoredProcedure [dbo].[usp_GetAccountDTOByName]    Script Date: 12/03/2012 22:20:09 ******/
DROP PROCEDURE [dbo].[usp_GetAccountDTOByName]
GO
/****** Object:  StoredProcedure [dbo].[usp_GetAccountDTOByName]    Script Date: 12/03/2012 22:20:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Danny Chen
-- Create date: 2012-12-02
-- Description:	AccountDTO store procedure
-- =============================================
CREATE PROCEDURE [dbo].[usp_GetAccountDTOByName] 
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
END
GO

/****** Object:  StoredProcedure [dbo].[usp_AccountsUpdate]    Script Date: 12/03/2012 15:28:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_AccountsUpdate] 
    @Id uniqueidentifier,
    @AccountName nvarchar(MAX),
    @Password nvarchar(MAX),
    @Email nvarchar(MAX),
    @QQ nvarchar(MAX),
    @Coins int,
    @IsLocked bit,
    @IdentityCardNumber nvarchar(MAX),
    @Name nvarchar(MAX),
    @ActivationCode nvarchar(MAX),
    @IsActive bit,
    @Gender bit
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	UPDATE [dbo].[Accounts]
	SET    [Id] = @Id, [AccountName] = @AccountName, [Password] = @Password, [Email] = @Email, [QQ] = @QQ, [Coins] = @Coins, [IsLocked] = @IsLocked, [IdentityCardNumber] = @IdentityCardNumber, [Name] = @Name, [ActivationCode] = @ActivationCode, [IsActive] = @IsActive, [Gender] = @Gender
	WHERE  [Id] = @Id
	
	-- Begin Return Select <- do not remove
	SELECT [Id], [AccountName], [Password], [Email], [QQ], [Coins], [IsLocked], [IdentityCardNumber], [Name], [ActivationCode], [IsActive], [Gender]
	FROM   [dbo].[Accounts]
	WHERE  [Id] = @Id	
	-- End Return Select <- do not remove

	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_AccountsSelect]    Script Date: 12/03/2012 15:28:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_AccountsSelect] 
    @Id UNIQUEIDENTIFIER
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  

	BEGIN TRAN

	SELECT [Id], [AccountName], [Password], [Email], [QQ], [Coins], [IsLocked], [IdentityCardNumber], [Name], [ActivationCode], [IsActive], [Gender] 
	FROM   [dbo].[Accounts] 
	WHERE  ([Id] = @Id) 

	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_AccountsInsert]    Script Date: 12/03/2012 15:28:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_AccountsInsert] 
    @Id uniqueidentifier,
    @AccountName nvarchar(MAX),
    @Password nvarchar(MAX),
    @Email nvarchar(MAX),
    @QQ nvarchar(MAX),
    @Coins int,
    @IsLocked bit,
    @IdentityCardNumber nvarchar(MAX),
    @Name nvarchar(MAX),
    @ActivationCode nvarchar(MAX),
    @IsActive bit,
    @Gender bit
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN
	
	INSERT INTO [dbo].[Accounts] ([Id], [AccountName], [Password], [Email], [QQ], [Coins], [IsLocked], [IdentityCardNumber], [Name], [ActivationCode], [IsActive], [Gender])
	SELECT @Id, @AccountName, @Password, @Email, @QQ, @Coins, @IsLocked, @IdentityCardNumber, @Name, @ActivationCode, @IsActive, @Gender
	
	-- Begin Return Select <- do not remove
	SELECT [Id], [AccountName], [Password], [Email], [QQ], [Coins], [IsLocked], [IdentityCardNumber], [Name], [ActivationCode], [IsActive], [Gender]
	FROM   [dbo].[Accounts]
	WHERE  [Id] = @Id
	-- End Return Select <- do not remove
               
	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_AccountsDelete]    Script Date: 12/03/2012 15:28:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_AccountsDelete] 
    @Id uniqueidentifier
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	DELETE
	FROM   [dbo].[Accounts]
	WHERE  [Id] = @Id

	COMMIT
GO
