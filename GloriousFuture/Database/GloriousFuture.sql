USE [GloriousFuture]
GO
/****** Object:  Table [dbo].[Accounts]    Script Date: 11/29/2012 22:26:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Accounts](
	[Id] [uniqueidentifier] NOT NULL,
	[AccountName] [nvarchar](max) NOT NULL,
	[Password] [nvarchar](max) NOT NULL,
	[Email] [nvarchar](max) NOT NULL,
	[QQ] [nvarchar](max) NULL,
	[Coins] [int] NOT NULL,
	[Zone_City] [nvarchar](max) NOT NULL,
	[Zone_Province] [nvarchar](max) NOT NULL,
	[IsLocked] [bit] NOT NULL,
	[IdentityCardNumber] [int] NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Accounts] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Universities]    Script Date: 11/29/2012 22:26:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Universities](
	[Id] [uniqueidentifier] NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[UniversityType] [nvarchar](max) NOT NULL,
	[Kind] [nvarchar](max) NOT NULL,
	[Address] [nvarchar](max) NOT NULL,
	[Phone] [nvarchar](max) NULL,
	[Email] [nvarchar](max) NULL,
	[Website] [nvarchar](max) NULL,
	[BriefIntroduction] [nvarchar](max) NULL,
	[IsEducationDepartment] [bit] NOT NULL,
	[Is985] [bit] NOT NULL,
	[Is211] [bit] NOT NULL,
	[Zone_City] [nvarchar](max) NOT NULL,
	[Zone_Province] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Universities] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ApplicationUserStatistic_DTO]    Script Date: 11/29/2012 22:26:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ApplicationUserStatistic_DTO](
	[Id] [uniqueidentifier] NOT NULL,
	[UserName] [nvarchar](max) NOT NULL,
	[Email] [nvarchar](max) NOT NULL,
	[QQ] [nvarchar](max) NULL,
	[Zone_City] [nvarchar](max) NOT NULL,
	[Zone_Province] [nvarchar](max) NOT NULL,
	[Score] [float] NOT NULL,
	[SpecialityType] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_ApplicationUserStatistic_DTO] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ApplicationStatistics]    Script Date: 11/29/2012 22:26:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ApplicationStatistics](
	[Id] [uniqueidentifier] NOT NULL,
	[TotalQuantity] [int] NOT NULL,
	[SuccessQuantity] [int] NOT NULL,
	[FailQuantity] [int] NOT NULL,
	[ApplicationSequence] [int] NOT NULL,
	[Year] [datetime] NOT NULL,
 CONSTRAINT [PK_ApplicationStatistics] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ApplicationStatistic_DTO]    Script Date: 11/29/2012 22:26:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ApplicationStatistic_DTO](
	[Id] [uniqueidentifier] NOT NULL,
	[HighestScore] [float] NOT NULL,
	[LowestScore] [float] NOT NULL,
	[AverageScore] [float] NOT NULL,
	[ApplicantQuantity] [int] NOT NULL,
	[YourScoreRank] [int] NOT NULL,
	[PlannedEnrollNumber] [int] NOT NULL,
	[UniversityName] [nvarchar](max) NOT NULL,
	[SpecialityName] [nvarchar](max) NOT NULL,
	[SpecialityType] [nvarchar](max) NOT NULL,
	[Province] [nvarchar](max) NOT NULL,
	[Year] [datetime] NOT NULL,
 CONSTRAINT [PK_ApplicationStatistic_DTO] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ApplicationSequenceStatistic_DTO]    Script Date: 11/29/2012 22:26:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ApplicationSequenceStatistic_DTO](
	[Id] [uniqueidentifier] NOT NULL,
	[HighestScore] [float] NOT NULL,
	[LowestScore] [float] NOT NULL,
	[AverageScore] [float] NOT NULL,
	[ApplicationSequence] [int] NOT NULL,
	[ApplicantQuantity] [int] NOT NULL,
	[YourScoreRank] [int] NOT NULL,
 CONSTRAINT [PK_ApplicationSequenceStatistic_DTO] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Specialities]    Script Date: 11/29/2012 22:26:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Specialities](
	[Id] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_Specialities] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ScorePublishes]    Script Date: 11/29/2012 22:26:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ScorePublishes](
	[Id] [uniqueidentifier] NOT NULL,
	[Province] [nvarchar](max) NOT NULL,
	[PublishDate] [datetime] NOT NULL,
	[CollegeEntranceExamTime] [datetime] NOT NULL,
 CONSTRAINT [PK_ScorePublishes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[usp_UsersUpdate]    Script Date: 11/29/2012 22:26:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_UsersUpdate] 
    @Id uniqueidentifier,
    @UserName nvarchar(MAX),
    @Password nvarchar(MAX),
    @Email nvarchar(MAX),
    @QQ nvarchar(MAX),
    @Coins int,
    @Zone_City nvarchar(MAX),
    @Zone_Province nvarchar(MAX)
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	UPDATE [dbo].[Users]
	SET    [Id] = @Id, [UserName] = @UserName, [Password] = @Password, [Email] = @Email, [QQ] = @QQ, [Coins] = @Coins, [Zone_City] = @Zone_City, [Zone_Province] = @Zone_Province
	WHERE  [Id] = @Id
	
	-- Begin Return Select <- do not remove
	SELECT [Id], [UserName], [Password], [Email], [QQ], [Coins], [Zone_City], [Zone_Province]
	FROM   [dbo].[Users]
	WHERE  [Id] = @Id	
	-- End Return Select <- do not remove

	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_UsersSelect]    Script Date: 11/29/2012 22:26:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_UsersSelect] 
    @Id UNIQUEIDENTIFIER
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  

	BEGIN TRAN

	SELECT [Id], [UserName], [Password], [Email], [QQ], [Coins], [Zone_City], [Zone_Province] 
	FROM   [dbo].[Users] 
	WHERE  ([Id] = @Id OR @Id IS NULL) 

	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_UsersInsert]    Script Date: 11/29/2012 22:26:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_UsersInsert] 
    @Id uniqueidentifier,
    @UserName nvarchar(MAX),
    @Password nvarchar(MAX),
    @Email nvarchar(MAX),
    @QQ nvarchar(MAX),
    @Coins int,
    @Zone_City nvarchar(MAX),
    @Zone_Province nvarchar(MAX)
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN
	
	INSERT INTO [dbo].[Users] ([Id], [UserName], [Password], [Email], [QQ], [Coins], [Zone_City], [Zone_Province])
	SELECT @Id, @UserName, @Password, @Email, @QQ, @Coins, @Zone_City, @Zone_Province
	
	-- Begin Return Select <- do not remove
	SELECT [Id], [UserName], [Password], [Email], [QQ], [Coins], [Zone_City], [Zone_Province]
	FROM   [dbo].[Users]
	WHERE  [Id] = @Id
	-- End Return Select <- do not remove
               
	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_UsersDelete]    Script Date: 11/29/2012 22:26:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_UsersDelete] 
    @Id uniqueidentifier
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	DELETE
	FROM   [dbo].[Users]
	WHERE  [Id] = @Id

	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_UniversitiesUpdate]    Script Date: 11/29/2012 22:26:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_UniversitiesUpdate] 
    @Id uniqueidentifier,
    @Name nvarchar(MAX),
    @UniversityType nvarchar(MAX),
    @Kind nvarchar(MAX),
    @Address nvarchar(MAX),
    @Phone nvarchar(MAX),
    @Email nvarchar(MAX),
    @Website nvarchar(MAX),
    @BriefIntroduction nvarchar(MAX),
    @IsEducationDepartment bit,
    @Is985 bit,
    @Is211 bit,
    @Zone_City nvarchar(MAX),
    @Zone_Province nvarchar(MAX)
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	UPDATE [dbo].[Universities]
	SET    [Id] = @Id, [Name] = @Name, [UniversityType] = @UniversityType, [Kind] = @Kind, [Address] = @Address, [Phone] = @Phone, [Email] = @Email, [Website] = @Website, [BriefIntroduction] = @BriefIntroduction, [IsEducationDepartment] = @IsEducationDepartment, [Is985] = @Is985, [Is211] = @Is211, [Zone_City] = @Zone_City, [Zone_Province] = @Zone_Province
	WHERE  [Id] = @Id
	
	-- Begin Return Select <- do not remove
	SELECT [Id], [Name], [UniversityType], [Kind], [Address], [Phone], [Email], [Website], [BriefIntroduction], [IsEducationDepartment], [Is985], [Is211], [Zone_City], [Zone_Province]
	FROM   [dbo].[Universities]
	WHERE  [Id] = @Id	
	-- End Return Select <- do not remove

	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_UniversitiesSelect]    Script Date: 11/29/2012 22:26:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_UniversitiesSelect] 
    @Id UNIQUEIDENTIFIER
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  

	BEGIN TRAN

	SELECT [Id], [Name], [UniversityType], [Kind], [Address], [Phone], [Email], [Website], [BriefIntroduction], [IsEducationDepartment], [Is985], [Is211], [Zone_City], [Zone_Province] 
	FROM   [dbo].[Universities] 
	WHERE  ([Id] = @Id OR @Id IS NULL) 

	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_UniversitiesInsert]    Script Date: 11/29/2012 22:26:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_UniversitiesInsert] 
    @Id uniqueidentifier,
    @Name nvarchar(MAX),
    @UniversityType nvarchar(MAX),
    @Kind nvarchar(MAX),
    @Address nvarchar(MAX),
    @Phone nvarchar(MAX),
    @Email nvarchar(MAX),
    @Website nvarchar(MAX),
    @BriefIntroduction nvarchar(MAX),
    @IsEducationDepartment bit,
    @Is985 bit,
    @Is211 bit,
    @Zone_City nvarchar(MAX),
    @Zone_Province nvarchar(MAX)
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN
	
	INSERT INTO [dbo].[Universities] ([Id], [Name], [UniversityType], [Kind], [Address], [Phone], [Email], [Website], [BriefIntroduction], [IsEducationDepartment], [Is985], [Is211], [Zone_City], [Zone_Province])
	SELECT @Id, @Name, @UniversityType, @Kind, @Address, @Phone, @Email, @Website, @BriefIntroduction, @IsEducationDepartment, @Is985, @Is211, @Zone_City, @Zone_Province
	
	-- Begin Return Select <- do not remove
	SELECT [Id], [Name], [UniversityType], [Kind], [Address], [Phone], [Email], [Website], [BriefIntroduction], [IsEducationDepartment], [Is985], [Is211], [Zone_City], [Zone_Province]
	FROM   [dbo].[Universities]
	WHERE  [Id] = @Id
	-- End Return Select <- do not remove
               
	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_UniversitiesDelete]    Script Date: 11/29/2012 22:26:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_UniversitiesDelete] 
    @Id uniqueidentifier
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	DELETE
	FROM   [dbo].[Universities]
	WHERE  [Id] = @Id

	COMMIT
GO
/****** Object:  Table [dbo].[EnrollPlans]    Script Date: 11/29/2012 22:26:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EnrollPlans](
	[Id] [uniqueidentifier] NOT NULL,
	[Year] [datetime] NOT NULL,
	[Province] [nvarchar](max) NOT NULL,
	[PlannedEnrollNumber] [int] NOT NULL,
	[UniversitySpecialityId] [uniqueidentifier] NOT NULL,
	[Batch] [nvarchar](max) NOT NULL,
	[IsDirectional] [bit] NOT NULL,
	[UniversityId] [uniqueidentifier] NOT NULL,
	[SpecialityId] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_EnrollPlans] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Applications]    Script Date: 11/29/2012 22:26:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Applications](
	[Id] [uniqueidentifier] NOT NULL,
	[Year] [datetime] NOT NULL,
	[Batch] [nvarchar](max) NOT NULL,
	[ApplicationSequence] [int] NOT NULL,
	[UserId] [uniqueidentifier] NOT NULL,
	[UniversityId] [uniqueidentifier] NOT NULL,
	[SpecialityId] [uniqueidentifier] NOT NULL,
	[IsSuccess] [bit] NOT NULL,
 CONSTRAINT [PK_Applications] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AchivementHistories]    Script Date: 11/29/2012 22:26:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AchivementHistories](
	[Id] [uniqueidentifier] NOT NULL,
	[Time] [datetime] NOT NULL,
	[AccountId] [uniqueidentifier] NOT NULL,
	[Score] [float] NOT NULL,
	[SpecialityType] [nvarchar](max) NOT NULL,
	[ACEENumber] [nvarchar](max) NULL,
 CONSTRAINT [PK_AchivementHistories] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Achievements]    Script Date: 11/29/2012 22:26:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Achievements](
	[AccountId] [uniqueidentifier] NOT NULL,
	[Score] [float] NOT NULL,
	[SpecialityType] [nvarchar](max) NOT NULL,
	[ACEENumber] [nvarchar](max) NULL,
 CONSTRAINT [PK_Achievements] PRIMARY KEY CLUSTERED 
(
	[AccountId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UniversityAcceptanceStatistics]    Script Date: 11/29/2012 22:26:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UniversityAcceptanceStatistics](
	[Id] [uniqueidentifier] NOT NULL,
	[Year] [datetime] NOT NULL,
	[HighestScore] [float] NOT NULL,
	[LowestScore] [float] NOT NULL,
	[AverageScore] [float] NOT NULL,
	[Batch] [nvarchar](max) NOT NULL,
	[ExceedScore] [float] NOT NULL,
	[UniversityId] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_UniversityAcceptanceStatistics] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[usp_ApplicationSequenceStatistic]    Script Date: 11/29/2012 22:26:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_ApplicationSequenceStatistic] 

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT top 1 TotalQuantity as  ApplicantQuantity, ApplicationSequence, 100 as AverageScore, 20 as HighestScore,30 as LowestScore,10 as YourScoreRank  from ApplicationStatistics
END
GO
/****** Object:  StoredProcedure [dbo].[usp_SpecialitiesUpdate]    Script Date: 11/29/2012 22:26:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_SpecialitiesUpdate] 
    @Id uniqueidentifier
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	UPDATE [dbo].[Specialities]
	SET    [Id] = @Id
	WHERE  [Id] = @Id
	
	-- Begin Return Select <- do not remove
	SELECT [Id]
	FROM   [dbo].[Specialities]
	WHERE  [Id] = @Id	
	-- End Return Select <- do not remove

	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_SpecialitiesSelect]    Script Date: 11/29/2012 22:26:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_SpecialitiesSelect] 
    @Id UNIQUEIDENTIFIER
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  

	BEGIN TRAN

	SELECT [Id] 
	FROM   [dbo].[Specialities] 
	WHERE  ([Id] = @Id OR @Id IS NULL) 

	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_SpecialitiesInsert]    Script Date: 11/29/2012 22:26:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_SpecialitiesInsert] 
    @Id uniqueidentifier
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN
	
	INSERT INTO [dbo].[Specialities] ([Id])
	SELECT @Id
	
	-- Begin Return Select <- do not remove
	SELECT [Id]
	FROM   [dbo].[Specialities]
	WHERE  [Id] = @Id
	-- End Return Select <- do not remove
               
	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_SpecialitiesDelete]    Script Date: 11/29/2012 22:26:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_SpecialitiesDelete] 
    @Id uniqueidentifier
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	DELETE
	FROM   [dbo].[Specialities]
	WHERE  [Id] = @Id

	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_ScorePublishesUpdate]    Script Date: 11/29/2012 22:26:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_ScorePublishesUpdate] 
    @Id uniqueidentifier,
    @Province nvarchar(MAX),
    @PublishDate datetime,
    @Year datetime
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	UPDATE [dbo].[ScorePublishes]
	SET    [Id] = @Id, [Province] = @Province, [PublishDate] = @PublishDate, [Year] = @Year
	WHERE  [Id] = @Id
	
	-- Begin Return Select <- do not remove
	SELECT [Id], [Province], [PublishDate], [Year]
	FROM   [dbo].[ScorePublishes]
	WHERE  [Id] = @Id	
	-- End Return Select <- do not remove

	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_ScorePublishesSelect]    Script Date: 11/29/2012 22:26:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_ScorePublishesSelect] 
    @Id UNIQUEIDENTIFIER
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  

	BEGIN TRAN

	SELECT [Id], [Province], [PublishDate], [Year] 
	FROM   [dbo].[ScorePublishes] 
	WHERE  ([Id] = @Id OR @Id IS NULL) 

	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_ScorePublishesInsert]    Script Date: 11/29/2012 22:26:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_ScorePublishesInsert] 
    @Id uniqueidentifier,
    @Province nvarchar(MAX),
    @PublishDate datetime,
    @Year datetime
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN
	
	INSERT INTO [dbo].[ScorePublishes] ([Id], [Province], [PublishDate], [Year])
	SELECT @Id, @Province, @PublishDate, @Year
	
	-- Begin Return Select <- do not remove
	SELECT [Id], [Province], [PublishDate], [Year]
	FROM   [dbo].[ScorePublishes]
	WHERE  [Id] = @Id
	-- End Return Select <- do not remove
               
	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_ScorePublishesDelete]    Script Date: 11/29/2012 22:26:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_ScorePublishesDelete] 
    @Id uniqueidentifier
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	DELETE
	FROM   [dbo].[ScorePublishes]
	WHERE  [Id] = @Id

	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_EnrollPlansUpdate]    Script Date: 11/29/2012 22:26:28 ******/
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
/****** Object:  StoredProcedure [dbo].[usp_EnrollPlansSelect]    Script Date: 11/29/2012 22:26:28 ******/
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
/****** Object:  StoredProcedure [dbo].[usp_EnrollPlansInsert]    Script Date: 11/29/2012 22:26:28 ******/
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
/****** Object:  StoredProcedure [dbo].[usp_EnrollPlansDelete]    Script Date: 11/29/2012 22:26:28 ******/
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
/****** Object:  StoredProcedure [dbo].[usp_ApplicationsUpdate]    Script Date: 11/29/2012 22:26:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_ApplicationsUpdate] 
    @Id uniqueidentifier,
    @Year datetime,
    @Batch nvarchar(MAX),
    @ApplicationSequence int,
    @UserId uniqueidentifier,
    @UniversityId uniqueidentifier,
    @SpecialityId uniqueidentifier
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	UPDATE [dbo].[Applications]
	SET    [Id] = @Id, [Year] = @Year, [Batch] = @Batch, [ApplicationSequence] = @ApplicationSequence, [UserId] = @UserId, [UniversityId] = @UniversityId, [SpecialityId] = @SpecialityId
	WHERE  [Id] = @Id
	
	-- Begin Return Select <- do not remove
	SELECT [Id], [Year], [Batch], [ApplicationSequence], [UserId], [UniversityId], [SpecialityId]
	FROM   [dbo].[Applications]
	WHERE  [Id] = @Id	
	-- End Return Select <- do not remove

	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_ApplicationsSelect]    Script Date: 11/29/2012 22:26:28 ******/
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

	SELECT [Id], [Year], [Batch], [ApplicationSequence], [UserId], [UniversityId], [SpecialityId] 
	FROM   [dbo].[Applications] 
	WHERE  ([Id] = @Id OR @Id IS NULL) 

	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_ApplicationsInsert]    Script Date: 11/29/2012 22:26:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_ApplicationsInsert] 
    @Id uniqueidentifier,
    @Year datetime,
    @Batch nvarchar(MAX),
    @ApplicationSequence int,
    @UserId uniqueidentifier,
    @UniversityId uniqueidentifier,
    @SpecialityId uniqueidentifier
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN
	
	INSERT INTO [dbo].[Applications] ([Id], [Year], [Batch], [ApplicationSequence], [UserId], [UniversityId], [SpecialityId])
	SELECT @Id, @Year, @Batch, @ApplicationSequence, @UserId, @UniversityId, @SpecialityId
	
	-- Begin Return Select <- do not remove
	SELECT [Id], [Year], [Batch], [ApplicationSequence], [UserId], [UniversityId], [SpecialityId]
	FROM   [dbo].[Applications]
	WHERE  [Id] = @Id
	-- End Return Select <- do not remove
               
	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_ApplicationsDelete]    Script Date: 11/29/2012 22:26:28 ******/
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
/****** Object:  StoredProcedure [dbo].[usp_AchievementsUpdate]    Script Date: 11/29/2012 22:26:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_AchievementsUpdate] 
    @UserId uniqueidentifier,
    @Score float,
    @SpecialityType nvarchar(MAX),
    @ACEENumber nvarchar(MAX)
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	UPDATE [dbo].[Achievements]
	SET    [UserId] = @UserId, [Score] = @Score, [SpecialityType] = @SpecialityType, [ACEENumber] = @ACEENumber
	WHERE  [UserId] = @UserId
	
	-- Begin Return Select <- do not remove
	SELECT [UserId], [Score], [SpecialityType], [ACEENumber]
	FROM   [dbo].[Achievements]
	WHERE  [UserId] = @UserId	
	-- End Return Select <- do not remove

	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_AchievementsSelect]    Script Date: 11/29/2012 22:26:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_AchievementsSelect] 
    @UserId UNIQUEIDENTIFIER
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  

	BEGIN TRAN

	SELECT [UserId], [Score], [SpecialityType], [ACEENumber] 
	FROM   [dbo].[Achievements] 
	WHERE  ([UserId] = @UserId OR @UserId IS NULL) 

	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_AchievementsInsert]    Script Date: 11/29/2012 22:26:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_AchievementsInsert] 
    @UserId uniqueidentifier,
    @Score float,
    @SpecialityType nvarchar(MAX),
    @ACEENumber nvarchar(MAX)
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN
	
	INSERT INTO [dbo].[Achievements] ([UserId], [Score], [SpecialityType], [ACEENumber])
	SELECT @UserId, @Score, @SpecialityType, @ACEENumber
	
	-- Begin Return Select <- do not remove
	SELECT [UserId], [Score], [SpecialityType], [ACEENumber]
	FROM   [dbo].[Achievements]
	WHERE  [UserId] = @UserId
	-- End Return Select <- do not remove
               
	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_AchievementsDelete]    Script Date: 11/29/2012 22:26:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_AchievementsDelete] 
    @UserId uniqueidentifier
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	DELETE
	FROM   [dbo].[Achievements]
	WHERE  [UserId] = @UserId

	COMMIT
GO
/****** Object:  Table [dbo].[SpecialityAcceptanceStatistics]    Script Date: 11/29/2012 22:26:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SpecialityAcceptanceStatistics](
	[Id] [uniqueidentifier] NOT NULL,
	[UniversityEnrollStatisticId] [uniqueidentifier] NOT NULL,
	[HighestScore] [float] NOT NULL,
	[LowestScore] [float] NOT NULL,
	[AverageScore] [float] NOT NULL,
	[Province] [nvarchar](max) NOT NULL,
	[SpecialityId] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_SpecialityAcceptanceStatistics] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[usp_UniversityAcceptanceStatisticsUpdate]    Script Date: 11/29/2012 22:26:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_UniversityAcceptanceStatisticsUpdate] 
    @Id uniqueidentifier,
    @Year datetime,
    @HighestScore float,
    @LowestScore float,
    @AverageScore float,
    @Batch nvarchar(MAX),
    @ExceedScore float,
    @UniversityId uniqueidentifier
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	UPDATE [dbo].[UniversityAcceptanceStatistics]
	SET    [Id] = @Id, [Year] = @Year, [HighestScore] = @HighestScore, [LowestScore] = @LowestScore, [AverageScore] = @AverageScore, [Batch] = @Batch, [ExceedScore] = @ExceedScore, [UniversityId] = @UniversityId
	WHERE  [Id] = @Id
	
	-- Begin Return Select <- do not remove
	SELECT [Id], [Year], [HighestScore], [LowestScore], [AverageScore], [Batch], [ExceedScore], [UniversityId]
	FROM   [dbo].[UniversityAcceptanceStatistics]
	WHERE  [Id] = @Id	
	-- End Return Select <- do not remove

	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_UniversityAcceptanceStatisticsSelect]    Script Date: 11/29/2012 22:26:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_UniversityAcceptanceStatisticsSelect] 
    @Id UNIQUEIDENTIFIER
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  

	BEGIN TRAN

	SELECT [Id], [Year], [HighestScore], [LowestScore], [AverageScore], [Batch], [ExceedScore], [UniversityId] 
	FROM   [dbo].[UniversityAcceptanceStatistics] 
	WHERE  ([Id] = @Id OR @Id IS NULL) 

	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_UniversityAcceptanceStatisticsInsert]    Script Date: 11/29/2012 22:26:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_UniversityAcceptanceStatisticsInsert] 
    @Id uniqueidentifier,
    @Year datetime,
    @HighestScore float,
    @LowestScore float,
    @AverageScore float,
    @Batch nvarchar(MAX),
    @ExceedScore float,
    @UniversityId uniqueidentifier
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN
	
	INSERT INTO [dbo].[UniversityAcceptanceStatistics] ([Id], [Year], [HighestScore], [LowestScore], [AverageScore], [Batch], [ExceedScore], [UniversityId])
	SELECT @Id, @Year, @HighestScore, @LowestScore, @AverageScore, @Batch, @ExceedScore, @UniversityId
	
	-- Begin Return Select <- do not remove
	SELECT [Id], [Year], [HighestScore], [LowestScore], [AverageScore], [Batch], [ExceedScore], [UniversityId]
	FROM   [dbo].[UniversityAcceptanceStatistics]
	WHERE  [Id] = @Id
	-- End Return Select <- do not remove
               
	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_UniversityAcceptanceStatisticsDelete]    Script Date: 11/29/2012 22:26:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_UniversityAcceptanceStatisticsDelete] 
    @Id uniqueidentifier
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	DELETE
	FROM   [dbo].[UniversityAcceptanceStatistics]
	WHERE  [Id] = @Id

	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_SpecialityAcceptanceStatisticsUpdate]    Script Date: 11/29/2012 22:26:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_SpecialityAcceptanceStatisticsUpdate] 
    @Id uniqueidentifier,
    @UniversityEnrollStatisticId uniqueidentifier,
    @HighestScore float,
    @LowestScore float,
    @AverageScore float,
    @Province nvarchar(MAX),
    @SpecialityId uniqueidentifier
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	UPDATE [dbo].[SpecialityAcceptanceStatistics]
	SET    [Id] = @Id, [UniversityEnrollStatisticId] = @UniversityEnrollStatisticId, [HighestScore] = @HighestScore, [LowestScore] = @LowestScore, [AverageScore] = @AverageScore, [Province] = @Province, [SpecialityId] = @SpecialityId
	WHERE  [Id] = @Id
	
	-- Begin Return Select <- do not remove
	SELECT [Id], [UniversityEnrollStatisticId], [HighestScore], [LowestScore], [AverageScore], [Province], [SpecialityId]
	FROM   [dbo].[SpecialityAcceptanceStatistics]
	WHERE  [Id] = @Id	
	-- End Return Select <- do not remove

	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_SpecialityAcceptanceStatisticsSelect]    Script Date: 11/29/2012 22:26:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_SpecialityAcceptanceStatisticsSelect] 
    @Id UNIQUEIDENTIFIER
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  

	BEGIN TRAN

	SELECT [Id], [UniversityEnrollStatisticId], [HighestScore], [LowestScore], [AverageScore], [Province], [SpecialityId] 
	FROM   [dbo].[SpecialityAcceptanceStatistics] 
	WHERE  ([Id] = @Id OR @Id IS NULL) 

	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_SpecialityAcceptanceStatisticsInsert]    Script Date: 11/29/2012 22:26:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_SpecialityAcceptanceStatisticsInsert] 
    @Id uniqueidentifier,
    @UniversityEnrollStatisticId uniqueidentifier,
    @HighestScore float,
    @LowestScore float,
    @AverageScore float,
    @Province nvarchar(MAX),
    @SpecialityId uniqueidentifier
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN
	
	INSERT INTO [dbo].[SpecialityAcceptanceStatistics] ([Id], [UniversityEnrollStatisticId], [HighestScore], [LowestScore], [AverageScore], [Province], [SpecialityId])
	SELECT @Id, @UniversityEnrollStatisticId, @HighestScore, @LowestScore, @AverageScore, @Province, @SpecialityId
	
	-- Begin Return Select <- do not remove
	SELECT [Id], [UniversityEnrollStatisticId], [HighestScore], [LowestScore], [AverageScore], [Province], [SpecialityId]
	FROM   [dbo].[SpecialityAcceptanceStatistics]
	WHERE  [Id] = @Id
	-- End Return Select <- do not remove
               
	COMMIT
GO
/****** Object:  StoredProcedure [dbo].[usp_SpecialityAcceptanceStatisticsDelete]    Script Date: 11/29/2012 22:26:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_SpecialityAcceptanceStatisticsDelete] 
    @Id uniqueidentifier
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  
	
	BEGIN TRAN

	DELETE
	FROM   [dbo].[SpecialityAcceptanceStatistics]
	WHERE  [Id] = @Id

	COMMIT
GO
/****** Object:  ForeignKey [FK_AchievementUser]    Script Date: 11/29/2012 22:26:30 ******/
ALTER TABLE [dbo].[Achievements]  WITH CHECK ADD  CONSTRAINT [FK_AchievementUser] FOREIGN KEY([AccountId])
REFERENCES [dbo].[Accounts] ([Id])
GO
ALTER TABLE [dbo].[Achievements] CHECK CONSTRAINT [FK_AchievementUser]
GO
/****** Object:  ForeignKey [FK_AchivementHistoryAccount]    Script Date: 11/29/2012 22:26:30 ******/
ALTER TABLE [dbo].[AchivementHistories]  WITH CHECK ADD  CONSTRAINT [FK_AchivementHistoryAccount] FOREIGN KEY([AccountId])
REFERENCES [dbo].[Accounts] ([Id])
GO
ALTER TABLE [dbo].[AchivementHistories] CHECK CONSTRAINT [FK_AchivementHistoryAccount]
GO
/****** Object:  ForeignKey [FK_ApplicationSpeciality]    Script Date: 11/29/2012 22:26:30 ******/
ALTER TABLE [dbo].[Applications]  WITH CHECK ADD  CONSTRAINT [FK_ApplicationSpeciality] FOREIGN KEY([SpecialityId])
REFERENCES [dbo].[Specialities] ([Id])
GO
ALTER TABLE [dbo].[Applications] CHECK CONSTRAINT [FK_ApplicationSpeciality]
GO
/****** Object:  ForeignKey [FK_ApplicationUniversity]    Script Date: 11/29/2012 22:26:30 ******/
ALTER TABLE [dbo].[Applications]  WITH CHECK ADD  CONSTRAINT [FK_ApplicationUniversity] FOREIGN KEY([UniversityId])
REFERENCES [dbo].[Universities] ([Id])
GO
ALTER TABLE [dbo].[Applications] CHECK CONSTRAINT [FK_ApplicationUniversity]
GO
/****** Object:  ForeignKey [FK_ApplicationUser]    Script Date: 11/29/2012 22:26:30 ******/
ALTER TABLE [dbo].[Applications]  WITH CHECK ADD  CONSTRAINT [FK_ApplicationUser] FOREIGN KEY([UserId])
REFERENCES [dbo].[Accounts] ([Id])
GO
ALTER TABLE [dbo].[Applications] CHECK CONSTRAINT [FK_ApplicationUser]
GO
/****** Object:  ForeignKey [FK_EnrollPlanSpeciality]    Script Date: 11/29/2012 22:26:30 ******/
ALTER TABLE [dbo].[EnrollPlans]  WITH CHECK ADD  CONSTRAINT [FK_EnrollPlanSpeciality] FOREIGN KEY([SpecialityId])
REFERENCES [dbo].[Specialities] ([Id])
GO
ALTER TABLE [dbo].[EnrollPlans] CHECK CONSTRAINT [FK_EnrollPlanSpeciality]
GO
/****** Object:  ForeignKey [FK_EnrollPlanUniversity]    Script Date: 11/29/2012 22:26:30 ******/
ALTER TABLE [dbo].[EnrollPlans]  WITH CHECK ADD  CONSTRAINT [FK_EnrollPlanUniversity] FOREIGN KEY([UniversityId])
REFERENCES [dbo].[Universities] ([Id])
GO
ALTER TABLE [dbo].[EnrollPlans] CHECK CONSTRAINT [FK_EnrollPlanUniversity]
GO
/****** Object:  ForeignKey [FK_SpecialityAcceptanceStatisticSpeciality]    Script Date: 11/29/2012 22:26:30 ******/
ALTER TABLE [dbo].[SpecialityAcceptanceStatistics]  WITH CHECK ADD  CONSTRAINT [FK_SpecialityAcceptanceStatisticSpeciality] FOREIGN KEY([SpecialityId])
REFERENCES [dbo].[Specialities] ([Id])
GO
ALTER TABLE [dbo].[SpecialityAcceptanceStatistics] CHECK CONSTRAINT [FK_SpecialityAcceptanceStatisticSpeciality]
GO
/****** Object:  ForeignKey [FK_SpecialityEnrollStatisticUniversityEnrollStatistic]    Script Date: 11/29/2012 22:26:30 ******/
ALTER TABLE [dbo].[SpecialityAcceptanceStatistics]  WITH CHECK ADD  CONSTRAINT [FK_SpecialityEnrollStatisticUniversityEnrollStatistic] FOREIGN KEY([UniversityEnrollStatisticId])
REFERENCES [dbo].[UniversityAcceptanceStatistics] ([Id])
GO
ALTER TABLE [dbo].[SpecialityAcceptanceStatistics] CHECK CONSTRAINT [FK_SpecialityEnrollStatisticUniversityEnrollStatistic]
GO
/****** Object:  ForeignKey [FK_UniversityEnrollStatisticUniversity]    Script Date: 11/29/2012 22:26:30 ******/
ALTER TABLE [dbo].[UniversityAcceptanceStatistics]  WITH CHECK ADD  CONSTRAINT [FK_UniversityEnrollStatisticUniversity] FOREIGN KEY([UniversityId])
REFERENCES [dbo].[Universities] ([Id])
GO
ALTER TABLE [dbo].[UniversityAcceptanceStatistics] CHECK CONSTRAINT [FK_UniversityEnrollStatisticUniversity]
GO
