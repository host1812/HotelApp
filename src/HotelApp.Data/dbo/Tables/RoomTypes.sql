CREATE TABLE [dbo].[RoomTypes]
(
    [Id] INT NOT NULL PRIMARY KEY IDENTITY,
    [Title] NVARCHAR(250) NOT NULL,
    [Description] NVARCHAR(2048) NOT NULL,
    [BasePrice] MONEY NOT NULL,
)
