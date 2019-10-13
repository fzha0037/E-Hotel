CREATE TABLE [dbo].[Hotel] (
    [Id]         INT           NOT NULL,
    [Name]       varchar (100)    NOT NULL,
    [Address]    NVARCHAR (250) NOT NULL,
    [UpdateDate] DATETIME      NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[Reservation] (
    [Id]           INT            IDENTITY (1, 1) NOT NULL,
    [CheckinDate]  DATE           NOT NULL,
    [CheckoutDate] DATE           NOT NULL,
    [HotelId]      INT            NOT NULL,
    [UserId]       NVARCHAR (128) NOT NULL,
    [Description]  nvarchar (Max)     NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    FOREIGN KEY ([UserId]) REFERENCES [dbo].[AspNetUsers] ([Id]),
    FOREIGN KEY ([HotelId]) REFERENCES [dbo].[Hotel] ([Id])
);

