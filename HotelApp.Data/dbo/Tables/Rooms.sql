CREATE TABLE [dbo].[Rooms]
(
    [Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Number] INT NOT NULL, 
    [TypeId] INT NOT NULL, 
    [StatusId] INT NOT NULL, 
    CONSTRAINT [FK_Rooms_To_RoomStatuses] FOREIGN KEY ([StatusId]) REFERENCES [RoomStatuses]([Id]),
    CONSTRAINT [FK_Rooms_To_RoomTypes] FOREIGN KEY ([TypeId]) REFERENCES [RoomTypes]([Id]) 
)
