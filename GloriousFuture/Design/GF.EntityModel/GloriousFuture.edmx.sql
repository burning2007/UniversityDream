
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 12/22/2012 11:08:47
-- Generated from EDMX file: E:\Job\Study\Dream\GloriousFuture\Design\GF.EntityModel\GloriousFuture.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [YG];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_Achievements_HighSchool]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Achievements] DROP CONSTRAINT [FK_Achievements_HighSchool];
GO
IF OBJECT_ID(N'[dbo].[FK_Achievements_Regions]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Achievements] DROP CONSTRAINT [FK_Achievements_Regions];
GO
IF OBJECT_ID(N'[dbo].[FK_Achievements_Users]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Achievements] DROP CONSTRAINT [FK_Achievements_Users];
GO
IF OBJECT_ID(N'[dbo].[FK_Applications_Specialities]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Applications] DROP CONSTRAINT [FK_Applications_Specialities];
GO
IF OBJECT_ID(N'[dbo].[FK_Applications_Universities]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Applications] DROP CONSTRAINT [FK_Applications_Universities];
GO
IF OBJECT_ID(N'[dbo].[FK_Applications_Users]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Applications] DROP CONSTRAINT [FK_Applications_Users];
GO
IF OBJECT_ID(N'[dbo].[FK_PayRecords_Users]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PayRecords] DROP CONSTRAINT [FK_PayRecords_Users];
GO
IF OBJECT_ID(N'[dbo].[FK_RechargeRecords_Users]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[RechargeRecords] DROP CONSTRAINT [FK_RechargeRecords_Users];
GO
IF OBJECT_ID(N'[dbo].[FK_ScorePublishes_Regions]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ScorePublishes] DROP CONSTRAINT [FK_ScorePublishes_Regions];
GO
IF OBJECT_ID(N'[dbo].[FK_SpecialityAcceptanceStatistics_Specialities]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SpecialityAcceptanceStatistics] DROP CONSTRAINT [FK_SpecialityAcceptanceStatistics_Specialities];
GO
IF OBJECT_ID(N'[dbo].[FK_SpecialityAcceptanceStatistics_UniversityAcceptanceStatistics]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SpecialityAcceptanceStatistics] DROP CONSTRAINT [FK_SpecialityAcceptanceStatistics_UniversityAcceptanceStatistics];
GO
IF OBJECT_ID(N'[dbo].[FK_UniversityAcceptanceStatistics_Regions]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UniversityAcceptanceStatistics] DROP CONSTRAINT [FK_UniversityAcceptanceStatistics_Regions];
GO
IF OBJECT_ID(N'[dbo].[FK_UniversityAcceptanceStatistics_Universities]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UniversityAcceptanceStatistics] DROP CONSTRAINT [FK_UniversityAcceptanceStatistics_Universities];
GO
IF OBJECT_ID(N'[dbo].[FK_UniversityEnrollPlans_Regions]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UniversityEnrollPlans] DROP CONSTRAINT [FK_UniversityEnrollPlans_Regions];
GO
IF OBJECT_ID(N'[dbo].[FK_UniversityEnrollPlans_Specialities]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UniversityEnrollPlans] DROP CONSTRAINT [FK_UniversityEnrollPlans_Specialities];
GO
IF OBJECT_ID(N'[dbo].[FK_UniversityEnrollPlans_Universities]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UniversityEnrollPlans] DROP CONSTRAINT [FK_UniversityEnrollPlans_Universities];
GO
IF OBJECT_ID(N'[dbo].[FK_Users_Roles]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Users] DROP CONSTRAINT [FK_Users_Roles];
GO
IF OBJECT_ID(N'[dbo].[FK_Users_Universities]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Users] DROP CONSTRAINT [FK_Users_Universities];
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
IF OBJECT_ID(N'[dbo].[ApplicationStatistics]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ApplicationStatistics];
GO
IF OBJECT_ID(N'[dbo].[HighSchools]', 'U') IS NOT NULL
    DROP TABLE [dbo].[HighSchools];
GO
IF OBJECT_ID(N'[dbo].[PayRecords]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PayRecords];
GO
IF OBJECT_ID(N'[dbo].[RechargeRecords]', 'U') IS NOT NULL
    DROP TABLE [dbo].[RechargeRecords];
GO
IF OBJECT_ID(N'[dbo].[Regions]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Regions];
GO
IF OBJECT_ID(N'[dbo].[Roles]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Roles];
GO
IF OBJECT_ID(N'[dbo].[ScorePublishes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ScorePublishes];
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
IF OBJECT_ID(N'[dbo].[UniversityEnrollPlans]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UniversityEnrollPlans];
GO
IF OBJECT_ID(N'[dbo].[Users]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Users];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'HighSchools'
CREATE TABLE [dbo].[HighSchools] (
    [Id] uniqueidentifier  NOT NULL,
    [SchoolName] nvarchar(200)  NOT NULL,
    [RegionId] int  NOT NULL
);
GO

-- Creating table 'PayRecords'
CREATE TABLE [dbo].[PayRecords] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [UserId] uniqueidentifier  NOT NULL,
    [Action] nvarchar(500)  NOT NULL,
    [Coins] int  NOT NULL,
    [ActionTime] datetime  NOT NULL
);
GO

-- Creating table 'RechargeRecords'
CREATE TABLE [dbo].[RechargeRecords] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [UserId] uniqueidentifier  NOT NULL,
    [Coins] int  NOT NULL,
    [RechargeTime] datetime  NOT NULL
);
GO

-- Creating table 'Regions'
CREATE TABLE [dbo].[Regions] (
    [Id] uniqueidentifier  NOT NULL,
    [Gbcode] int  NOT NULL,
    [Name] nvarchar(100)  NOT NULL,
    [Class] int  NOT NULL
);
GO

-- Creating table 'Roles'
CREATE TABLE [dbo].[Roles] (
    [Id] uniqueidentifier  NOT NULL,
    [Name] nvarchar(300)  NOT NULL,
    [Description] nvarchar(300)  NULL
);
GO

-- Creating table 'ScorePublishes'
CREATE TABLE [dbo].[ScorePublishes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [ProvinceId] uniqueidentifier  NOT NULL,
    [PublishDate] datetime  NOT NULL
);
GO

-- Creating table 'Specialities'
CREATE TABLE [dbo].[Specialities] (
    [Id] uniqueidentifier  NOT NULL,
    [Name] nvarchar(200)  NOT NULL,
    [Category] nvarchar(50)  NOT NULL,
    [SpecialityCode] nvarchar(200)  NULL
);
GO

-- Creating table 'Universities'
CREATE TABLE [dbo].[Universities] (
    [Id] uniqueidentifier  NOT NULL,
    [Name] nvarchar(200)  NOT NULL,
    [UniversityType] nvarchar(50)  NOT NULL,
    [Subjection] nvarchar(50)  NOT NULL,
    [Location] nvarchar(200)  NOT NULL,
    [EducationLevel] nvarchar(50)  NOT NULL,
    [SchoolType] nvarchar(100)  NOT NULL,
    [Is985] bit  NOT NULL,
    [Is211] bit  NOT NULL,
    [IsNational] bit  NOT NULL,
    [UniversityCode] nvarchar(200)  NULL
);
GO

-- Creating table 'Users'
CREATE TABLE [dbo].[Users] (
    [Id] uniqueidentifier  NOT NULL,
    [UserName] nvarchar(100)  NOT NULL,
    [Password] nvarchar(200)  NOT NULL,
    [Email] nvarchar(100)  NOT NULL,
    [QQ] nvarchar(100)  NULL,
    [Coins] int  NOT NULL,
    [IsLocked] bit  NOT NULL,
    [IDCardNo] nvarchar(100)  NULL,
    [ChineseName] nvarchar(100)  NULL,
    [Gender] bit  NOT NULL,
    [IsIDCardValid] bit  NOT NULL,
    [LastActivityDate] datetime  NOT NULL,
    [RoleId] uniqueidentifier  NOT NULL,
    [UniversityId] uniqueidentifier  NULL
);
GO

-- Creating table 'Achievements'
CREATE TABLE [dbo].[Achievements] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Score] float  NOT NULL,
    [ACEENumber] nvarchar(100)  NULL,
    [Year] int  NOT NULL,
    [CourseType] nvarchar(50)  NOT NULL,
    [UserId] uniqueidentifier  NOT NULL,
    [HighSchoolId] uniqueidentifier  NOT NULL,
    [ProvinceId] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'Applications'
CREATE TABLE [dbo].[Applications] (
    [Id] uniqueidentifier  NOT NULL,
    [Year] int  NOT NULL,
    [Batch] nvarchar(50)  NOT NULL,
    [ApplicationSequence] int  NOT NULL,
    [UserId] uniqueidentifier  NOT NULL,
    [SpecialityId] uniqueidentifier  NOT NULL,
    [IsAccepted] bit  NOT NULL,
    [ApplyTime] datetime  NOT NULL,
    [UniversityId] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'ApplicationStatistics'
CREATE TABLE [dbo].[ApplicationStatistics] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [TotalQuantity] int  NOT NULL,
    [SuccessQuantity] int  NOT NULL,
    [FailQuantity] int  NOT NULL,
    [ApplicationSequence] int  NOT NULL,
    [Year] int  NOT NULL
);
GO

-- Creating table 'SpecialityAcceptanceStatistics'
CREATE TABLE [dbo].[SpecialityAcceptanceStatistics] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [HighestScore] float  NOT NULL,
    [LowestScore] float  NOT NULL,
    [AverageScore] float  NOT NULL,
    [SpecialityId] uniqueidentifier  NOT NULL,
    [PlannedEnrollNumber] int  NOT NULL,
    [RealEnrollNumber] int  NOT NULL,
    [Batch] nvarchar(50)  NOT NULL,
    [Year] int  NOT NULL,
    [UniversityAcceptanceStatisticsId] int  NOT NULL
);
GO

-- Creating table 'UniversityAcceptanceStatistics'
CREATE TABLE [dbo].[UniversityAcceptanceStatistics] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Year] int  NOT NULL,
    [HighestScore] float  NOT NULL,
    [LowestScore] float  NOT NULL,
    [AverageScore] float  NOT NULL,
    [Batch] nvarchar(50)  NOT NULL,
    [UniversityId] uniqueidentifier  NOT NULL,
    [ProvinceId] uniqueidentifier  NOT NULL,
    [AcceptNumber] int  NOT NULL
);
GO

-- Creating table 'UniversityEnrollPlans'
CREATE TABLE [dbo].[UniversityEnrollPlans] (
    [Id] int  NOT NULL,
    [PlannedNumber] int  NOT NULL,
    [Year] int  NOT NULL,
    [ProvinceId] uniqueidentifier  NOT NULL,
    [Batch] nvarchar(50)  NOT NULL,
    [PlanCategory] nvarchar(200)  NOT NULL,
    [UniversityId] uniqueidentifier  NOT NULL,
    [SpecialityId] uniqueidentifier  NOT NULL,
    [CourseType] nvarchar(50)  NOT NULL,
    [StudyYears] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'HighSchools'
ALTER TABLE [dbo].[HighSchools]
ADD CONSTRAINT [PK_HighSchools]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'PayRecords'
ALTER TABLE [dbo].[PayRecords]
ADD CONSTRAINT [PK_PayRecords]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'RechargeRecords'
ALTER TABLE [dbo].[RechargeRecords]
ADD CONSTRAINT [PK_RechargeRecords]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Regions'
ALTER TABLE [dbo].[Regions]
ADD CONSTRAINT [PK_Regions]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Roles'
ALTER TABLE [dbo].[Roles]
ADD CONSTRAINT [PK_Roles]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ScorePublishes'
ALTER TABLE [dbo].[ScorePublishes]
ADD CONSTRAINT [PK_ScorePublishes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Specialities'
ALTER TABLE [dbo].[Specialities]
ADD CONSTRAINT [PK_Specialities]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Universities'
ALTER TABLE [dbo].[Universities]
ADD CONSTRAINT [PK_Universities]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Users'
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT [PK_Users]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Achievements'
ALTER TABLE [dbo].[Achievements]
ADD CONSTRAINT [PK_Achievements]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Applications'
ALTER TABLE [dbo].[Applications]
ADD CONSTRAINT [PK_Applications]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ApplicationStatistics'
ALTER TABLE [dbo].[ApplicationStatistics]
ADD CONSTRAINT [PK_ApplicationStatistics]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'SpecialityAcceptanceStatistics'
ALTER TABLE [dbo].[SpecialityAcceptanceStatistics]
ADD CONSTRAINT [PK_SpecialityAcceptanceStatistics]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'UniversityAcceptanceStatistics'
ALTER TABLE [dbo].[UniversityAcceptanceStatistics]
ADD CONSTRAINT [PK_UniversityAcceptanceStatistics]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'UniversityEnrollPlans'
ALTER TABLE [dbo].[UniversityEnrollPlans]
ADD CONSTRAINT [PK_UniversityEnrollPlans]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [UserId] in table 'PayRecords'
ALTER TABLE [dbo].[PayRecords]
ADD CONSTRAINT [FK_PayRecords_Users]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_PayRecords_Users'
CREATE INDEX [IX_FK_PayRecords_Users]
ON [dbo].[PayRecords]
    ([UserId]);
GO

-- Creating foreign key on [UserId] in table 'RechargeRecords'
ALTER TABLE [dbo].[RechargeRecords]
ADD CONSTRAINT [FK_RechargeRecords_Users]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_RechargeRecords_Users'
CREATE INDEX [IX_FK_RechargeRecords_Users]
ON [dbo].[RechargeRecords]
    ([UserId]);
GO

-- Creating foreign key on [ProvinceId] in table 'ScorePublishes'
ALTER TABLE [dbo].[ScorePublishes]
ADD CONSTRAINT [FK_ScorePublishes_Regions]
    FOREIGN KEY ([ProvinceId])
    REFERENCES [dbo].[Regions]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ScorePublishes_Regions'
CREATE INDEX [IX_FK_ScorePublishes_Regions]
ON [dbo].[ScorePublishes]
    ([ProvinceId]);
GO

-- Creating foreign key on [RoleId] in table 'Users'
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT [FK_Users_Roles]
    FOREIGN KEY ([RoleId])
    REFERENCES [dbo].[Roles]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_Users_Roles'
CREATE INDEX [IX_FK_Users_Roles]
ON [dbo].[Users]
    ([RoleId]);
GO

-- Creating foreign key on [UniversityId] in table 'Users'
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT [FK_Users_Universities]
    FOREIGN KEY ([UniversityId])
    REFERENCES [dbo].[Universities]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_Users_Universities'
CREATE INDEX [IX_FK_Users_Universities]
ON [dbo].[Users]
    ([UniversityId]);
GO

-- Creating foreign key on [HighSchoolId] in table 'Achievements'
ALTER TABLE [dbo].[Achievements]
ADD CONSTRAINT [FK_Achievements_HighSchool]
    FOREIGN KEY ([HighSchoolId])
    REFERENCES [dbo].[HighSchools]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_Achievements_HighSchool'
CREATE INDEX [IX_FK_Achievements_HighSchool]
ON [dbo].[Achievements]
    ([HighSchoolId]);
GO

-- Creating foreign key on [UserId] in table 'Achievements'
ALTER TABLE [dbo].[Achievements]
ADD CONSTRAINT [FK_Achievements_Users]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_Achievements_Users'
CREATE INDEX [IX_FK_Achievements_Users]
ON [dbo].[Achievements]
    ([UserId]);
GO

-- Creating foreign key on [SpecialityId] in table 'Applications'
ALTER TABLE [dbo].[Applications]
ADD CONSTRAINT [FK_Applications_Specialities]
    FOREIGN KEY ([SpecialityId])
    REFERENCES [dbo].[Specialities]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_Applications_Specialities'
CREATE INDEX [IX_FK_Applications_Specialities]
ON [dbo].[Applications]
    ([SpecialityId]);
GO

-- Creating foreign key on [UniversityId] in table 'Applications'
ALTER TABLE [dbo].[Applications]
ADD CONSTRAINT [FK_Applications_Universities]
    FOREIGN KEY ([UniversityId])
    REFERENCES [dbo].[Universities]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_Applications_Universities'
CREATE INDEX [IX_FK_Applications_Universities]
ON [dbo].[Applications]
    ([UniversityId]);
GO

-- Creating foreign key on [UserId] in table 'Applications'
ALTER TABLE [dbo].[Applications]
ADD CONSTRAINT [FK_Applications_Users]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_Applications_Users'
CREATE INDEX [IX_FK_Applications_Users]
ON [dbo].[Applications]
    ([UserId]);
GO

-- Creating foreign key on [ProvinceId] in table 'UniversityAcceptanceStatistics'
ALTER TABLE [dbo].[UniversityAcceptanceStatistics]
ADD CONSTRAINT [FK_UniversityAcceptanceStatistics_Regions]
    FOREIGN KEY ([ProvinceId])
    REFERENCES [dbo].[Regions]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_UniversityAcceptanceStatistics_Regions'
CREATE INDEX [IX_FK_UniversityAcceptanceStatistics_Regions]
ON [dbo].[UniversityAcceptanceStatistics]
    ([ProvinceId]);
GO

-- Creating foreign key on [ProvinceId] in table 'UniversityEnrollPlans'
ALTER TABLE [dbo].[UniversityEnrollPlans]
ADD CONSTRAINT [FK_UniversityEnrollPlans_Regions]
    FOREIGN KEY ([ProvinceId])
    REFERENCES [dbo].[Regions]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_UniversityEnrollPlans_Regions'
CREATE INDEX [IX_FK_UniversityEnrollPlans_Regions]
ON [dbo].[UniversityEnrollPlans]
    ([ProvinceId]);
GO

-- Creating foreign key on [SpecialityId] in table 'SpecialityAcceptanceStatistics'
ALTER TABLE [dbo].[SpecialityAcceptanceStatistics]
ADD CONSTRAINT [FK_SpecialityAcceptanceStatistics_Specialities]
    FOREIGN KEY ([SpecialityId])
    REFERENCES [dbo].[Specialities]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_SpecialityAcceptanceStatistics_Specialities'
CREATE INDEX [IX_FK_SpecialityAcceptanceStatistics_Specialities]
ON [dbo].[SpecialityAcceptanceStatistics]
    ([SpecialityId]);
GO

-- Creating foreign key on [SpecialityId] in table 'UniversityEnrollPlans'
ALTER TABLE [dbo].[UniversityEnrollPlans]
ADD CONSTRAINT [FK_UniversityEnrollPlans_Specialities]
    FOREIGN KEY ([SpecialityId])
    REFERENCES [dbo].[Specialities]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_UniversityEnrollPlans_Specialities'
CREATE INDEX [IX_FK_UniversityEnrollPlans_Specialities]
ON [dbo].[UniversityEnrollPlans]
    ([SpecialityId]);
GO

-- Creating foreign key on [UniversityAcceptanceStatisticsId] in table 'SpecialityAcceptanceStatistics'
ALTER TABLE [dbo].[SpecialityAcceptanceStatistics]
ADD CONSTRAINT [FK_SpecialityAcceptanceStatistics_UniversityAcceptanceStatistics]
    FOREIGN KEY ([UniversityAcceptanceStatisticsId])
    REFERENCES [dbo].[UniversityAcceptanceStatistics]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_SpecialityAcceptanceStatistics_UniversityAcceptanceStatistics'
CREATE INDEX [IX_FK_SpecialityAcceptanceStatistics_UniversityAcceptanceStatistics]
ON [dbo].[SpecialityAcceptanceStatistics]
    ([UniversityAcceptanceStatisticsId]);
GO

-- Creating foreign key on [UniversityId] in table 'UniversityAcceptanceStatistics'
ALTER TABLE [dbo].[UniversityAcceptanceStatistics]
ADD CONSTRAINT [FK_UniversityAcceptanceStatistics_Universities]
    FOREIGN KEY ([UniversityId])
    REFERENCES [dbo].[Universities]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_UniversityAcceptanceStatistics_Universities'
CREATE INDEX [IX_FK_UniversityAcceptanceStatistics_Universities]
ON [dbo].[UniversityAcceptanceStatistics]
    ([UniversityId]);
GO

-- Creating foreign key on [UniversityId] in table 'UniversityEnrollPlans'
ALTER TABLE [dbo].[UniversityEnrollPlans]
ADD CONSTRAINT [FK_UniversityEnrollPlans_Universities]
    FOREIGN KEY ([UniversityId])
    REFERENCES [dbo].[Universities]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_UniversityEnrollPlans_Universities'
CREATE INDEX [IX_FK_UniversityEnrollPlans_Universities]
ON [dbo].[UniversityEnrollPlans]
    ([UniversityId]);
GO

-- Creating foreign key on [ProvinceId] in table 'Achievements'
ALTER TABLE [dbo].[Achievements]
ADD CONSTRAINT [FK_Achievements_Regions]
    FOREIGN KEY ([ProvinceId])
    REFERENCES [dbo].[Regions]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_Achievements_Regions'
CREATE INDEX [IX_FK_Achievements_Regions]
ON [dbo].[Achievements]
    ([ProvinceId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------