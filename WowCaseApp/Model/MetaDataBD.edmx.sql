
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 12/04/2018 13:47:21
-- Generated from EDMX file: D:\Сохранить\Other\lll курс\БД\wow-case-cs-app\WowCaseApp\MetaDataBD.edmx
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


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'TableSet'
CREATE TABLE [dbo].[TableSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [DBName] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'AttributeSet'
CREATE TABLE [dbo].[AttributeSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Type] nvarchar(max)  NOT NULL,
    [Indexed] bit  NOT NULL,
    [Nullable] bit  NOT NULL,
    [DBName] nvarchar(max)  NOT NULL,
    [IsFKey] nvarchar(max)  NOT NULL,
    [IsPKey] bit  NOT NULL,
    [Table_Id] int  NOT NULL
);
GO

-- Creating table 'FormSet'
CREATE TABLE [dbo].[FormSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'ReportSet'
CREATE TABLE [dbo].[ReportSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'QuerySet'
CREATE TABLE [dbo].[QuerySet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'AttributeInFormSet'
CREATE TABLE [dbo].[AttributeInFormSet] (
    [Id] int  NOT NULL,
    [PointX] float  NOT NULL,
    [PointY] float  NOT NULL,
    [Width] float  NOT NULL,
    [Height] float  NOT NULL,
    [Form_Id] int  NOT NULL,
    [Origin_Id] int  NOT NULL
);
GO

-- Creating table 'AttributeInReportSet'
CREATE TABLE [dbo].[AttributeInReportSet] (
    [Id] int  NOT NULL,
    [PointX] float  NOT NULL,
    [PointY] float  NOT NULL,
    [Width] float  NOT NULL,
    [Height] float  NOT NULL,
    [Report_Id] int  NOT NULL,
    [Origin_Id] int  NOT NULL
);
GO

-- Creating table 'TableTable'
CREATE TABLE [dbo].[TableTable] (
    [TableTable_Table1_Id] int  NOT NULL,
    [Tables_Id] int  NOT NULL
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

-- Creating primary key on [Id] in table 'FormSet'
ALTER TABLE [dbo].[FormSet]
ADD CONSTRAINT [PK_FormSet]
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

-- Creating primary key on [Id] in table 'AttributeInFormSet'
ALTER TABLE [dbo].[AttributeInFormSet]
ADD CONSTRAINT [PK_AttributeInFormSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'AttributeInReportSet'
ALTER TABLE [dbo].[AttributeInReportSet]
ADD CONSTRAINT [PK_AttributeInReportSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [TableTable_Table1_Id], [Tables_Id] in table 'TableTable'
ALTER TABLE [dbo].[TableTable]
ADD CONSTRAINT [PK_TableTable]
    PRIMARY KEY CLUSTERED ([TableTable_Table1_Id], [Tables_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Table_Id] in table 'AttributeSet'
ALTER TABLE [dbo].[AttributeSet]
ADD CONSTRAINT [FK_AttributeTable]
    FOREIGN KEY ([Table_Id])
    REFERENCES [dbo].[TableSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AttributeTable'
CREATE INDEX [IX_FK_AttributeTable]
ON [dbo].[AttributeSet]
    ([Table_Id]);
GO

-- Creating foreign key on [Report_Id] in table 'AttributeInReportSet'
ALTER TABLE [dbo].[AttributeInReportSet]
ADD CONSTRAINT [FK_AttributeInReportReport]
    FOREIGN KEY ([Report_Id])
    REFERENCES [dbo].[ReportSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AttributeInReportReport'
CREATE INDEX [IX_FK_AttributeInReportReport]
ON [dbo].[AttributeInReportSet]
    ([Report_Id]);
GO

-- Creating foreign key on [Form_Id] in table 'AttributeInFormSet'
ALTER TABLE [dbo].[AttributeInFormSet]
ADD CONSTRAINT [FK_AttributeInFormForm]
    FOREIGN KEY ([Form_Id])
    REFERENCES [dbo].[FormSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AttributeInFormForm'
CREATE INDEX [IX_FK_AttributeInFormForm]
ON [dbo].[AttributeInFormSet]
    ([Form_Id]);
GO

-- Creating foreign key on [TableTable_Table1_Id] in table 'TableTable'
ALTER TABLE [dbo].[TableTable]
ADD CONSTRAINT [FK_TableTable_Table]
    FOREIGN KEY ([TableTable_Table1_Id])
    REFERENCES [dbo].[TableSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Tables_Id] in table 'TableTable'
ALTER TABLE [dbo].[TableTable]
ADD CONSTRAINT [FK_TableTable_Table1]
    FOREIGN KEY ([Tables_Id])
    REFERENCES [dbo].[TableSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TableTable_Table1'
CREATE INDEX [IX_FK_TableTable_Table1]
ON [dbo].[TableTable]
    ([Tables_Id]);
GO

-- Creating foreign key on [Origin_Id] in table 'AttributeInFormSet'
ALTER TABLE [dbo].[AttributeInFormSet]
ADD CONSTRAINT [FK_AttributeAttributeInForm]
    FOREIGN KEY ([Origin_Id])
    REFERENCES [dbo].[AttributeSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AttributeAttributeInForm'
CREATE INDEX [IX_FK_AttributeAttributeInForm]
ON [dbo].[AttributeInFormSet]
    ([Origin_Id]);
GO

-- Creating foreign key on [Origin_Id] in table 'AttributeInReportSet'
ALTER TABLE [dbo].[AttributeInReportSet]
ADD CONSTRAINT [FK_AttributeAttributeInReport]
    FOREIGN KEY ([Origin_Id])
    REFERENCES [dbo].[AttributeSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AttributeAttributeInReport'
CREATE INDEX [IX_FK_AttributeAttributeInReport]
ON [dbo].[AttributeInReportSet]
    ([Origin_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------