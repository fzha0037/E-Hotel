CREATE TABLE [dbo].[Hotel] (
    [Id]        INT            IDENTITY (1, 1) NOT NULL,
    [Name]      VARCHAR (100)  NOT NULL,
    [Address]   NVARCHAR (250) NOT NULL,
    [StarLevel] INT            NOT NULL,
    [UpdateDate] DATE NOT NULL DEFAULT Today(), 
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [starlevel_range] CHECK ([StarLevel]>=(0) AND [StarLevel]<=(5))
);

