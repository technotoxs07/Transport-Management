CREATE TABLE [dbo].[Category] (
    [Id]       INT           IDENTITY(1,1) NOT NULL,
    [category] NVARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);
