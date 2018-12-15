
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 12/15/2018 18:58:14
-- Generated from EDMX file: D:\Сохранить\Other\lll курс\ll модуль\БД\wow-case-cs-app\WowCaseApp\Model\MetaDataBD.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [MetaDB];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_AttributeTable]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AttributeSet] DROP CONSTRAINT [FK_AttributeTable];
GO
IF OBJECT_ID(N'[dbo].[FK_TableTable]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TableSet] DROP CONSTRAINT [FK_TableTable];
GO
IF OBJECT_ID(N'[dbo].[FK_TableTable1]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TableSet] DROP CONSTRAINT [FK_TableTable1];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[TableSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TableSet];
GO
IF OBJECT_ID(N'[dbo].[AttributeSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AttributeSet];
GO
IF OBJECT_ID(N'[dbo].[ViewSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ViewSet];
GO
IF OBJECT_ID(N'[dbo].[ReportSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ReportSet];
GO
IF OBJECT_ID(N'[dbo].[QuerySet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[QuerySet];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'TableSet'
CREATE TABLE [dbo].[TableSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [RealName] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'AttributeSet'
CREATE TABLE [dbo].[AttributeSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [RealName] nvarchar(max)  NOT NULL,
    [Type] nvarchar(max)  NOT NULL,
    [IsIndexed] bit  NOT NULL,
    [IsNullable] bit  NOT NULL,
    [IsFKey] bit  NOT NULL,
    [IsPKey] bit  NOT NULL,
    [AttributeTable_Attribute_Id] int  NOT NULL
);
GO

-- Creating table 'ViewSet'
CREATE TABLE [dbo].[ViewSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Data] varbinary(max)  NOT NULL
);
GO

-- Creating table 'ReportSet'
CREATE TABLE [dbo].[ReportSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Data] varbinary(max)  NOT NULL
);
GO

-- Creating table 'QuerySet'
CREATE TABLE [dbo].[QuerySet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [QueryText] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'TableTable'
CREATE TABLE [dbo].[TableTable] (
    [ParentTables_Id] int  NOT NULL,
    [ChildTables_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'TableSet'
ALTER TABLE [dbo].[TableSet]
ADD CONSTRAINT [PK_TableSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'AttributeSet'
ALTER TABLE [dbo].[AttributeSet]
ADD CONSTRAINT [PK_AttributeSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ViewSet'
ALTER TABLE [dbo].[ViewSet]
ADD CONSTRAINT [PK_ViewSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ReportSet'
ALTER TABLE [dbo].[ReportSet]
ADD CONSTRAINT [PK_ReportSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'QuerySet'
ALTER TABLE [dbo].[QuerySet]
ADD CONSTRAINT [PK_QuerySet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [ParentTables_Id], [ChildTables_Id] in table 'TableTable'
ALTER TABLE [dbo].[TableTable]
ADD CONSTRAINT [PK_TableTable]
    PRIMARY KEY CLUSTERED ([ParentTables_Id], [ChildTables_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [AttributeTable_Attribute_Id] in table 'AttributeSet'
ALTER TABLE [dbo].[AttributeSet]
ADD CONSTRAINT [FK_AttributeTable]
    FOREIGN KEY ([AttributeTable_Attribute_Id])
    REFERENCES [dbo].[TableSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AttributeTable'
CREATE INDEX [IX_FK_AttributeTable]
ON [dbo].[AttributeSet]
    ([AttributeTable_Attribute_Id]);
GO

-- Creating foreign key on [ParentTables_Id] in table 'TableTable'
ALTER TABLE [dbo].[TableTable]
ADD CONSTRAINT [FK_TableTable_Table]
    FOREIGN KEY ([ParentTables_Id])
    REFERENCES [dbo].[TableSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [ChildTables_Id] in table 'TableTable'
ALTER TABLE [dbo].[TableTable]
ADD CONSTRAINT [FK_TableTable_Table1]
    FOREIGN KEY ([ChildTables_Id])
    REFERENCES [dbo].[TableSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TableTable_Table1'
CREATE INDEX [IX_FK_TableTable_Table1]
ON [dbo].[TableTable]
    ([ChildTables_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------