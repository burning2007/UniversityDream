USE [GloriousFuture]
GO
/****** Object:  StoredProcedure [dbo].[usp_AccountsUpdate]    Script Date: 12/05/2012 12:52:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_AccountsUpdate] 
    @Id uniqueidentifier,
    @AccountName nvarchar(100),
    @Password nvarchar(200),
    @Email nvarchar(100),
    @QQ nvarchar(100),
    @Coins int,
    @IsLocked bit,
    @IdentityCardNumber nvarchar(100),
    @Name nvarchar(100),
    @ActivationCode nvarchar(50),
    @IsActive bit,
    @Gender bit,
    @SpecialityType nvarchar(MAX)
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	UPDATE [dbo].[Accounts]
	SET    [Id] = @Id, [AccountName] = @AccountName, [Password] = @Password, [Email] = @Email, [QQ] = @QQ, [Coins] = @Coins, [IsLocked] = @IsLocked, [IdentityCardNumber] = @IdentityCardNumber, [Name] = @Name, [ActivationCode] = @ActivationCode, [IsActive] = @IsActive, [Gender] = @Gender, [SpecialityType] = @SpecialityType
	WHERE  [Id] = @Id
	
	-- Begin Return Select <- do not remove
	SELECT [Id], [AccountName], [Password], [Email], [QQ], [Coins], [IsLocked], [IdentityCardNumber], [Name], [ActivationCode], [IsActive], [Gender], [SpecialityType]
	FROM   [dbo].[Accounts]
	WHERE  [Id] = @Id	
	-- End Return Select <- do not remove

	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_AccountsSelect]    Script Date: 12/05/2012 12:52:25 ******/
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

	SELECT [Id], [AccountName], [Password], [Email], [QQ], [Coins], [IsLocked], [IdentityCardNumber], [Name], [ActivationCode], [IsActive], [Gender], [SpecialityType] 
	FROM   [dbo].[Accounts] 
	WHERE  ([Id] = @Id OR @Id IS NULL) 

	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_AccountsInsert]    Script Date: 12/05/2012 12:52:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_AccountsInsert] 
    @Id uniqueidentifier,
    @AccountName nvarchar(100),
    @Password nvarchar(200),
    @Email nvarchar(100),
    @QQ nvarchar(100),
    @Coins int,
    @IsLocked bit,
    @IdentityCardNumber nvarchar(100),
    @Name nvarchar(100),
    @ActivationCode nvarchar(50),
    @IsActive bit,
    @Gender bit,
    @SpecialityType nvarchar(MAX)
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN
	
	INSERT INTO [dbo].[Accounts] ([Id], [AccountName], [Password], [Email], [QQ], [Coins], [IsLocked], [IdentityCardNumber], [Name], [ActivationCode], [IsActive], [Gender], [SpecialityType])
	SELECT @Id, @AccountName, @Password, @Email, @QQ, @Coins, @IsLocked, @IdentityCardNumber, @Name, @ActivationCode, @IsActive, @Gender, @SpecialityType
	
	-- Begin Return Select <- do not remove
	SELECT [Id], [AccountName], [Password], [Email], [QQ], [Coins], [IsLocked], [IdentityCardNumber], [Name], [ActivationCode], [IsActive], [Gender], [SpecialityType]
	FROM   [dbo].[Accounts]
	WHERE  [Id] = @Id
	-- End Return Select <- do not remove
               
	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_AccountsDelete]    Script Date: 12/05/2012 12:52:25 ******/
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
/****** Object:  StoredProcedure [dbo].[usp_AchievementsUpdate]    Script Date: 12/05/2012 12:52:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_AchievementsUpdate] 
    @Id uniqueidentifier,
    @Score float,
    @ACEENumber nvarchar(100),
    @Year datetime,
    @AccountId uniqueidentifier,
    @Zone_City nvarchar(MAX),
    @Zone_Province nvarchar(MAX)
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	UPDATE [dbo].[Achievements]
	SET    [Id] = @Id, [Score] = @Score, [ACEENumber] = @ACEENumber, [Year] = @Year, [AccountId] = @AccountId, [Zone_City] = @Zone_City, [Zone_Province] = @Zone_Province
	WHERE  [Id] = @Id
	
	-- Begin Return Select <- do not remove
	SELECT [Id], [Score], [ACEENumber], [Year], [AccountId], [Zone_City], [Zone_Province]
	FROM   [dbo].[Achievements]
	WHERE  [Id] = @Id	
	-- End Return Select <- do not remove

	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_AchievementsSelect]    Script Date: 12/05/2012 12:52:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_AchievementsSelect] 
    @Id UNIQUEIDENTIFIER
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  

	BEGIN TRAN

	SELECT [Id], [Score], [ACEENumber], [Year], [AccountId], [Zone_City], [Zone_Province] 
	FROM   [dbo].[Achievements] 
	WHERE  ([Id] = @Id OR @Id IS NULL) 

	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_AchievementsInsert]    Script Date: 12/05/2012 12:52:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_AchievementsInsert] 
    @Id uniqueidentifier,
    @Score float,
    @ACEENumber nvarchar(100),
    @Year datetime,
    @AccountId uniqueidentifier,
    @Zone_City nvarchar(MAX),
    @Zone_Province nvarchar(MAX)
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN
	
	INSERT INTO [dbo].[Achievements] ([Id], [Score], [ACEENumber], [Year], [AccountId], [Zone_City], [Zone_Province])
	SELECT @Id, @Score, @ACEENumber, @Year, @AccountId, @Zone_City, @Zone_Province
	
	-- Begin Return Select <- do not remove
	SELECT [Id], [Score], [ACEENumber], [Year], [AccountId], [Zone_City], [Zone_Province]
	FROM   [dbo].[Achievements]
	WHERE  [Id] = @Id
	-- End Return Select <- do not remove
               
	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_AchievementsDelete]    Script Date: 12/05/2012 12:52:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_AchievementsDelete] 
    @Id uniqueidentifier
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	DELETE
	FROM   [dbo].[Achievements]
	WHERE  [Id] = @Id

	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_AchievementHistoriesUpdate]    Script Date: 12/05/2012 12:52:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_AchievementHistoriesUpdate] 
    @Id uniqueidentifier,
    @Time datetime,
    @Score float,
    @ACEENumber nvarchar(100),
    @Year datetime,
    @AccountId uniqueidentifier,
    @Zone_City nvarchar(MAX),
    @Zone_Province nvarchar(MAX)
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	UPDATE [dbo].[AchievementHistories]
	SET    [Id] = @Id, [Time] = @Time, [Score] = @Score, [ACEENumber] = @ACEENumber, [Year] = @Year, [AccountId] = @AccountId, [Zone_City] = @Zone_City, [Zone_Province] = @Zone_Province
	WHERE  [Id] = @Id
	
	-- Begin Return Select <- do not remove
	SELECT [Id], [Time], [Score], [ACEENumber], [Year], [AccountId], [Zone_City], [Zone_Province]
	FROM   [dbo].[AchievementHistories]
	WHERE  [Id] = @Id	
	-- End Return Select <- do not remove

	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_AchievementHistoriesSelect]    Script Date: 12/05/2012 12:52:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_AchievementHistoriesSelect] 
    @Id UNIQUEIDENTIFIER
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  

	BEGIN TRAN

	SELECT [Id], [Time], [Score], [ACEENumber], [Year], [AccountId], [Zone_City], [Zone_Province] 
	FROM   [dbo].[AchievementHistories] 
	WHERE  ([Id] = @Id OR @Id IS NULL) 

	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_AchievementHistoriesInsert]    Script Date: 12/05/2012 12:52:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_AchievementHistoriesInsert] 
    @Id uniqueidentifier,
    @Time datetime,
    @Score float,
    @ACEENumber nvarchar(100),
    @Year datetime,
    @AccountId uniqueidentifier,
    @Zone_City nvarchar(MAX),
    @Zone_Province nvarchar(MAX)
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN
	
	INSERT INTO [dbo].[AchievementHistories] ([Id], [Time], [Score], [ACEENumber], [Year], [AccountId], [Zone_City], [Zone_Province])
	SELECT @Id, @Time, @Score, @ACEENumber, @Year, @AccountId, @Zone_City, @Zone_Province
	
	-- Begin Return Select <- do not remove
	SELECT [Id], [Time], [Score], [ACEENumber], [Year], [AccountId], [Zone_City], [Zone_Province]
	FROM   [dbo].[AchievementHistories]
	WHERE  [Id] = @Id
	-- End Return Select <- do not remove
               
	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_AchievementHistoriesDelete]    Script Date: 12/05/2012 12:52:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_AchievementHistoriesDelete] 
    @Id uniqueidentifier
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	DELETE
	FROM   [dbo].[AchievementHistories]
	WHERE  [Id] = @Id

	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_EnrollPlansUpdate]    Script Date: 12/05/2012 12:52:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_EnrollPlansUpdate] 
    @Id uniqueidentifier,
    @Year datetime,
    @Province nvarchar(MAX),
    @PlannedEnrollNumber int,
    @UniversitySpecialityId uniqueidentifier,
    @Batch nvarchar(MAX),
    @IsDirectional bit,
    @UniversityId uniqueidentifier,
    @SpecialityId uniqueidentifier
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	UPDATE [dbo].[EnrollPlans]
	SET    [Id] = @Id, [Year] = @Year, [Province] = @Province, [PlannedEnrollNumber] = @PlannedEnrollNumber, [UniversitySpecialityId] = @UniversitySpecialityId, [Batch] = @Batch, [IsDirectional] = @IsDirectional, [UniversityId] = @UniversityId, [SpecialityId] = @SpecialityId
	WHERE  [Id] = @Id
	
	-- Begin Return Select <- do not remove
	SELECT [Id], [Year], [Province], [PlannedEnrollNumber], [UniversitySpecialityId], [Batch], [IsDirectional], [UniversityId], [SpecialityId]
	FROM   [dbo].[EnrollPlans]
	WHERE  [Id] = @Id	
	-- End Return Select <- do not remove

	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_EnrollPlansSelect]    Script Date: 12/05/2012 12:52:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_EnrollPlansSelect] 
    @Id UNIQUEIDENTIFIER
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  

	BEGIN TRAN

	SELECT [Id], [Year], [Province], [PlannedEnrollNumber], [UniversitySpecialityId], [Batch], [IsDirectional], [UniversityId], [SpecialityId] 
	FROM   [dbo].[EnrollPlans] 
	WHERE  ([Id] = @Id OR @Id IS NULL) 

	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_EnrollPlansInsert]    Script Date: 12/05/2012 12:52:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_EnrollPlansInsert] 
    @Id uniqueidentifier,
    @Year datetime,
    @Province nvarchar(MAX),
    @PlannedEnrollNumber int,
    @UniversitySpecialityId uniqueidentifier,
    @Batch nvarchar(MAX),
    @IsDirectional bit,
    @UniversityId uniqueidentifier,
    @SpecialityId uniqueidentifier
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN
	
	INSERT INTO [dbo].[EnrollPlans] ([Id], [Year], [Province], [PlannedEnrollNumber], [UniversitySpecialityId], [Batch], [IsDirectional], [UniversityId], [SpecialityId])
	SELECT @Id, @Year, @Province, @PlannedEnrollNumber, @UniversitySpecialityId, @Batch, @IsDirectional, @UniversityId, @SpecialityId
	
	-- Begin Return Select <- do not remove
	SELECT [Id], [Year], [Province], [PlannedEnrollNumber], [UniversitySpecialityId], [Batch], [IsDirectional], [UniversityId], [SpecialityId]
	FROM   [dbo].[EnrollPlans]
	WHERE  [Id] = @Id
	-- End Return Select <- do not remove
               
	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_EnrollPlansDelete]    Script Date: 12/05/2012 12:52:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_EnrollPlansDelete] 
    @Id uniqueidentifier
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	DELETE
	FROM   [dbo].[EnrollPlans]
	WHERE  [Id] = @Id

	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_ApplicationsUpdate]    Script Date: 12/05/2012 12:52:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_ApplicationsUpdate] 
    @Id uniqueidentifier,
    @Year datetime,
    @Batch nvarchar(50),
    @ApplicationSequence int,
    @UserId uniqueidentifier,
    @SpecialityId uniqueidentifier,
    @IsSuccess bit,
    @AppTime datetime
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	UPDATE [dbo].[Applications]
	SET    [Id] = @Id, [Year] = @Year, [Batch] = @Batch, [ApplicationSequence] = @ApplicationSequence, [UserId] = @UserId, [SpecialityId] = @SpecialityId, [IsSuccess] = @IsSuccess, [AppTime] = @AppTime
	WHERE  [Id] = @Id
	
	-- Begin Return Select <- do not remove
	SELECT [Id], [Year], [Batch], [ApplicationSequence], [UserId], [SpecialityId], [IsSuccess], [AppTime]
	FROM   [dbo].[Applications]
	WHERE  [Id] = @Id	
	-- End Return Select <- do not remove

	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_ApplicationsSelect]    Script Date: 12/05/2012 12:52:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_ApplicationsSelect] 
    @Id UNIQUEIDENTIFIER
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  

	BEGIN TRAN

	SELECT [Id], [Year], [Batch], [ApplicationSequence], [UserId], [SpecialityId], [IsSuccess], [AppTime] 
	FROM   [dbo].[Applications] 
	WHERE  ([Id] = @Id OR @Id IS NULL) 

	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_ApplicationsInsert]    Script Date: 12/05/2012 12:52:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_ApplicationsInsert] 
    @Id uniqueidentifier,
    @Year datetime,
    @Batch nvarchar(50),
    @ApplicationSequence int,
    @UserId uniqueidentifier,
    @SpecialityId uniqueidentifier,
    @IsSuccess bit,
    @AppTime datetime
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN
	
	INSERT INTO [dbo].[Applications] ([Id], [Year], [Batch], [ApplicationSequence], [UserId], [SpecialityId], [IsSuccess], [AppTime])
	SELECT @Id, @Year, @Batch, @ApplicationSequence, @UserId, @SpecialityId, @IsSuccess, @AppTime
	
	-- Begin Return Select <- do not remove
	SELECT [Id], [Year], [Batch], [ApplicationSequence], [UserId], [SpecialityId], [IsSuccess], [AppTime]
	FROM   [dbo].[Applications]
	WHERE  [Id] = @Id
	-- End Return Select <- do not remove
               
	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_ApplicationsDelete]    Script Date: 12/05/2012 12:52:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_ApplicationsDelete] 
    @Id uniqueidentifier
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	DELETE
	FROM   [dbo].[Applications]
	WHERE  [Id] = @Id

	COMMIT
GO
