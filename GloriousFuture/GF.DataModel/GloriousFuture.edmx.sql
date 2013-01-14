
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 11/28/2012 16:46:12
-- Generated from EDMX file: D:\Work\Project\GloriousFuture\GloriousFuture\GF.DataModel\GloriousFuture.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [GloriousFuture];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_AchievementUser]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Achievements] DROP CONSTRAINT [FK_AchievementUser];
GO
IF OBJECT_ID(N'[dbo].[FK_ApplicationSpeciality]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Applications] DROP CONSTRAINT [FK_ApplicationSpeciality];
GO
IF OBJECT_ID(N'[dbo].[FK_ApplicationUniversity]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Applications] DROP CONSTRAINT [FK_ApplicationUniversity];
GO
IF OBJECT_ID(N'[dbo].[FK_ApplicationUser]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Applications] DROP CONSTRAINT [FK_ApplicationUser];
GO
IF OBJECT_ID(N'[dbo].[FK_EnrollPlanSpeciality]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EnrollPlans] DROP CONSTRAINT [FK_EnrollPlanSpeciality];
GO
IF OBJECT_ID(N'[dbo].[FK_EnrollPlanUniversity]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EnrollPlans] DROP CONSTRAINT [FK_EnrollPlanUniversity];
GO
IF OBJECT_ID(N'[dbo].[FK_SpecialityAcceptanceStatisticSpeciality]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SpecialityAcceptanceStatistics] DROP CONSTRAINT [FK_SpecialityAcceptanceStatisticSpeciality];
GO
IF OBJECT_ID(N'[dbo].[FK_SpecialityEnrollStatisticUniversityEnrollStatistic]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SpecialityAcceptanceStatistics] DROP CONSTRAINT [FK_SpecialityEnrollStatisticUniversityEnrollStatistic];
GO
IF OBJECT_ID(N'[dbo].[FK_UniversityEnrollStatisticUniversity]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UniversityAcceptanceStatistics] DROP CONSTRAINT [FK_UniversityEnrollStatisticUniversity];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Achievements]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Achievements];
GO
IF OBJECT_ID(N'[dbo].[Applications]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Applications];
GO
IF OBJECT_ID(N'[dbo].[ApplicationStatistic_DTO]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ApplicationStatistic_DTO];
GO
IF OBJECT_ID(N'[dbo].[EnrollPlans]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EnrollPlans];
GO
IF OBJECT_ID(N'[dbo].[Specialities]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Specialities];
GO
IF OBJECT_ID(N'[dbo].[SpecialityAcceptanceStatistics]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SpecialityAcceptanceStatistics];
GO
IF OBJECT_ID(N'[dbo].[Universities]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Universities];
GO
IF OBJECT_ID(N'[dbo].[UniversityAcceptanceStatistics]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UniversityAcceptanceStatistics];
GO
IF OBJECT_ID(N'[dbo].[Users]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Users];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Users'
CREATE TABLE [dbo].[Users] (
    [Id] uniqueidentifier  NOT NULL,
    [UserName] nvarchar(max)  NOT NULL,
    [Password] nvarchar(max)  NOT NULL,
    [Email] nvarchar(max)  NOT NULL,
    [QQ] nvarchar(max)  NULL,
    [Coins] int  NOT NULL,
    [Zone_City] nvarchar(max)  NOT NULL,
    [Zone_Province] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Universities'
CREATE TABLE [dbo].[Universities] (
    [Id] uniqueidentifier  NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [UniversityType] nvarchar(max)  NOT NULL,
    [Kind] nvarchar(max)  NOT NULL,
    [Address] nvarchar(max)  NOT NULL,
    [Phone] nvarchar(max)  NULL,
    [Email] nvarchar(max)  NULL,
    [Website] nvarchar(max)  NULL,
    [BriefIntroduction] nvarchar(max)  NULL,
    [IsEducationDepartment] bit  NOT NULL,
    [Is985] bit  NOT NULL,
    [Is211] bit  NOT NULL,
    [Zone_City] nvarchar(max)  NOT NULL,
    [Zone_Province] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'EnrollPlans'
CREATE TABLE [dbo].[EnrollPlans] (
    [Id] uniqueidentifier  NOT NULL,
    [Year] datetime  NOT NULL,
    [Province] nvarchar(max)  NOT NULL,
    [PlannedEnrollNumber] int  NOT NULL,
    [UniversitySpecialityId] uniqueidentifier  NOT NULL,
    [Batch] nvarchar(max)  NOT NULL,
    [IsDirectional] bit  NOT NULL,
    [UniversityId] uniqueidentifier  NOT NULL,
    [SpecialityId] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'UniversityAcceptanceStatistics'
CREATE TABLE [dbo].[UniversityAcceptanceStatistics] (
    [Id] uniqueidentifier  NOT NULL,
    [Year] datetime  NOT NULL,
    [HighestScore] float  NOT NULL,
    [LowestScore] float  NOT NULL,
    [AverageScore] float  NOT NULL,
    [Batch] nvarchar(max)  NOT NULL,
    [ExceedScore] float  NOT NULL,
    [UniversityId] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'SpecialityAcceptanceStatistics'
CREATE TABLE [dbo].[SpecialityAcceptanceStatistics] (
    [Id] uniqueidentifier  NOT NULL,
    [UniversityEnrollStatisticId] uniqueidentifier  NOT NULL,
    [HighestScore] float  NOT NULL,
    [LowestScore] float  NOT NULL,
    [AverageScore] float  NOT NULL,
    [Province] nvarchar(max)  NOT NULL,
    [SpecialityId] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'Specialities'
CREATE TABLE [dbo].[Specialities] (
    [Id] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'Applications'
CREATE TABLE [dbo].[Applications] (
    [Id] uniqueidentifier  NOT NULL,
    [Year] datetime  NOT NULL,
    [Batch] nvarchar(max)  NOT NULL,
    [Sequence] int  NOT NULL,
    [UserId] uniqueidentifier  NOT NULL,
    [UniversityId] uniqueidentifier  NOT NULL,
    [SpecialityId] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'Achievements'
CREATE TABLE [dbo].[Achievements] (
    [UserId] uniqueidentifier  NOT NULL,
    [Score] float  NOT NULL
);
GO

-- Creating table 'ApplicationStatistic_DTO'
CREATE TABLE [dbo].[ApplicationStatistic_DTO] (
    [Id] uniqueidentifier  NOT NULL,
    [HighestScore] float  NOT NULL,
    [LowestScore] float  NOT NULL,
    [AverageScore] float  NOT NULL,
    [Totality] int  NOT NULL,
    [ScoreRank] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Users'
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT [PK_Users]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Universities'
ALTER TABLE [dbo].[Universities]
ADD CONSTRAINT [PK_Universities]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'EnrollPlans'
ALTER TABLE [dbo].[EnrollPlans]
ADD CONSTRAINT [PK_EnrollPlans]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'UniversityAcceptanceStatistics'
ALTER TABLE [dbo].[UniversityAcceptanceStatistics]
ADD CONSTRAINT [PK_UniversityAcceptanceStatistics]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'SpecialityAcceptanceStatistics'
ALTER TABLE [dbo].[SpecialityAcceptanceStatistics]
ADD CONSTRAINT [PK_SpecialityAcceptanceStatistics]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Specialities'
ALTER TABLE [dbo].[Specialities]
ADD CONSTRAINT [PK_Specialities]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Applications'
ALTER TABLE [dbo].[Applications]
ADD CONSTRAINT [PK_Applications]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [UserId] in table 'Achievements'
ALTER TABLE [dbo].[Achievements]
ADD CONSTRAINT [PK_Achievements]
    PRIMARY KEY CLUSTERED ([UserId] ASC);
GO

-- Creating primary key on [Id] in table 'ApplicationStatistic_DTO'
ALTER TABLE [dbo].[ApplicationStatistic_DTO]
ADD CONSTRAINT [PK_ApplicationStatistic_DTO]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [UniversityEnrollStatisticId] in table 'SpecialityAcceptanceStatistics'
ALTER TABLE [dbo].[SpecialityAcceptanceStatistics]
ADD CONSTRAINT [FK_SpecialityEnrollStatisticUniversityEnrollStatistic]
    FOREIGN KEY ([UniversityEnrollStatisticId])
    REFERENCES [dbo].[UniversityAcceptanceStatistics]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_SpecialityEnrollStatisticUniversityEnrollStatistic'
CREATE INDEX [IX_FK_SpecialityEnrollStatisticUniversityEnrollStatistic]
ON [dbo].[SpecialityAcceptanceStatistics]
    ([UniversityEnrollStatisticId]);
GO

-- Creating foreign key on [UniversityId] in table 'UniversityAcceptanceStatistics'
ALTER TABLE [dbo].[UniversityAcceptanceStatistics]
ADD CONSTRAINT [FK_UniversityEnrollStatisticUniversity]
    FOREIGN KEY ([UniversityId])
    REFERENCES [dbo].[Universities]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_UniversityEnrollStatisticUniversity'
CREATE INDEX [IX_FK_UniversityEnrollStatisticUniversity]
ON [dbo].[UniversityAcceptanceStatistics]
    ([UniversityId]);
GO

-- Creating foreign key on [SpecialityId] in table 'SpecialityAcceptanceStatistics'
ALTER TABLE [dbo].[SpecialityAcceptanceStatistics]
ADD CONSTRAINT [FK_SpecialityAcceptanceStatisticSpeciality]
    FOREIGN KEY ([SpecialityId])
    REFERENCES [dbo].[Specialities]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_SpecialityAcceptanceStatisticSpeciality'
CREATE INDEX [IX_FK_SpecialityAcceptanceStatisticSpeciality]
ON [dbo].[SpecialityAcceptanceStatistics]
    ([SpecialityId]);
GO

-- Creating foreign key on [UserId] in table 'Applications'
ALTER TABLE [dbo].[Applications]
ADD CONSTRAINT [FK_ApplicationUser]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ApplicationUser'
CREATE INDEX [IX_FK_ApplicationUser]
ON [dbo].[Applications]
    ([UserId]);
GO

-- Creating foreign key on [UniversityId] in table 'EnrollPlans'
ALTER TABLE [dbo].[EnrollPlans]
ADD CONSTRAINT [FK_EnrollPlanUniversity]
    FOREIGN KEY ([UniversityId])
    REFERENCES [dbo].[Universities]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_EnrollPlanUniversity'
CREATE INDEX [IX_FK_EnrollPlanUniversity]
ON [dbo].[EnrollPlans]
    ([UniversityId]);
GO

-- Creating foreign key on [SpecialityId] in table 'EnrollPlans'
ALTER TABLE [dbo].[EnrollPlans]
ADD CONSTRAINT [FK_EnrollPlanSpeciality]
    FOREIGN KEY ([SpecialityId])
    REFERENCES [dbo].[Specialities]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_EnrollPlanSpeciality'
CREATE INDEX [IX_FK_EnrollPlanSpeciality]
ON [dbo].[EnrollPlans]
    ([SpecialityId]);
GO

-- Creating foreign key on [UniversityId] in table 'Applications'
ALTER TABLE [dbo].[Applications]
ADD CONSTRAINT [FK_ApplicationUniversity]
    FOREIGN KEY ([UniversityId])
    REFERENCES [dbo].[Universities]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ApplicationUniversity'
CREATE INDEX [IX_FK_ApplicationUniversity]
ON [dbo].[Applications]
    ([UniversityId]);
GO

-- Creating foreign key on [SpecialityId] in table 'Applications'
ALTER TABLE [dbo].[Applications]
ADD CONSTRAINT [FK_ApplicationSpeciality]
    FOREIGN KEY ([SpecialityId])
    REFERENCES [dbo].[Specialities]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ApplicationSpeciality'
CREATE INDEX [IX_FK_ApplicationSpeciality]
ON [dbo].[Applications]
    ([SpecialityId]);
GO

-- Creating foreign key on [UserId] in table 'Achievements'
ALTER TABLE [dbo].[Achievements]
ADD CONSTRAINT [FK_AchievementUser]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------