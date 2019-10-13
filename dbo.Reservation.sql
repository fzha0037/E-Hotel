<<<<<<< HEAD
﻿CREATE TABLE [dbo].[Reservation] (
    [Id]           INT            IDENTITY (1, 1) NOT NULL,
    [CheckinDate]  DATE           NOT NULL,
    [CheckoutDate] DATE           NOT NULL,
	[RoomType] NCHAR(10) NOT NULL, 
    [HotelId]      INT            NOT NULL,
    [UserId]       NVARCHAR (128) NOT NULL,
    [Description]  NVARCHAR (MAX) NOT NULL,
    
    PRIMARY KEY CLUSTERED ([Id] ASC),
    FOREIGN KEY ([UserId]) REFERENCES [dbo].[AspNetUsers] ([Id]),
    FOREIGN KEY ([HotelId]) REFERENCES [dbo].[Hotel] ([Id])
);

=======
﻿CREATE TABLE [dbo].[Reservation] (
    [Id]           INT            IDENTITY (1, 1) NOT NULL,
    [CheckinDate]  DATE           NOT NULL,
    [CheckoutDate] DATE           NOT NULL,
	[RoomType] NCHAR(10) NOT NULL, 
    [HotelId]      INT            NOT NULL,
    [UserId]       NVARCHAR (128) NOT NULL,
    [Description]  NVARCHAR (MAX) NOT NULL,
    
    PRIMARY KEY CLUSTERED ([Id] ASC),
    FOREIGN KEY ([UserId]) REFERENCES [dbo].[AspNetUsers] ([Id]),
    FOREIGN KEY ([HotelId]) REFERENCES [dbo].[Hotel] ([Id])
);

>>>>>>> 70f1a5246248991eaa302b2ea15cfc4d0c0edf10
