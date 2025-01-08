CREATE TABLE [dbo].[Bookings]
(
    [Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [StartDate] DATETIME NOT NULL, 
    [EndDate] DATETIME NOT NULL, 
    [RoomTypeId] INT NOT NULL, 
    [GuestId] INT NOT NULL, 
    [StatusId] INT NOT NULL DEFAULT 1, 
    [TotalCost] MONEY NOT NULL,
    CONSTRAINT [FK_Bookings_To_BookingStatuses] FOREIGN KEY ([StatusId]) REFERENCES [BookingStatuses]([Id]),
    CONSTRAINT [FK_Bookings_To_Guests] FOREIGN KEY ([GuestId]) REFERENCES [Guests]([Id]),
    CONSTRAINT [FK_Bookings_To_RoomTypes] FOREIGN KEY ([RoomTypeId]) REFERENCES [RoomTypes]([Id])
)
