
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 07/06/2017 16:17:23
-- Generated from EDMX file: C:\Users\Kokli Lau\Documents\Visual Studio 2015\Projects\CMS031874v4\CMS031874v4\Models\EntityDataModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [db_cms];
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

-- Creating table 'Shipments'
CREATE TABLE [dbo].[Shipments] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Booking_date] nvarchar(max)  NOT NULL,
    [Shipping_date] nvarchar(max)  NOT NULL,
    [Destination] nvarchar(max)  NOT NULL,
    [Type] nvarchar(max)  NOT NULL,
    [Weight] nvarchar(max)  NOT NULL,
    [Ship_regnum] nvarchar(max)  NOT NULL,
    [Status] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Shipments'
ALTER TABLE [dbo].[Shipments]
ADD CONSTRAINT [PK_Shipments]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------