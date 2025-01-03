CREATE TABLE [dbo].[Rooms]
(
    [Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Number] NVARCHAR(10) NOT NULL, 
    [TypeId] INT NOT NULL DEFAULT 1, 
    [StatusId] INT NOT NULL DEFAULT 1, 
    CONSTRAINT [FK_Rooms_To_RoomStatuses] FOREIGN KEY ([StatusId]) REFERENCES [RoomStatuses]([Id]),
    CONSTRAINT [FK_Rooms_To_RoomTypes] FOREIGN KEY ([TypeId]) REFERENCES [RoomTypes]([Id]) 
)
