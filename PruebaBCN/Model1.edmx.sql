
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 08/19/2023 23:48:23
-- Generated from EDMX file: C:\Users\Johan R\Desktop\PruebaBCN\PruebaBCN\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [TipoCambio];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[ExchangeRates]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ExchangeRates];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'ExchangeRates'
CREATE TABLE [dbo].[ExchangeRates] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Year] int  NULL,
    [Month] int  NULL,
    [Day] int  NULL,
    [ExchangeRateValue] float  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'ExchangeRates'
ALTER TABLE [dbo].[ExchangeRates]
ADD CONSTRAINT [PK_ExchangeRates]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------