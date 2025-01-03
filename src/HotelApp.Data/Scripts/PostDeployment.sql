/*
Post-Deployment Script Template                            
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.        
 Use SQLCMD syntax to include a file in the post-deployment script.            
 Example:      :r .\myfile.sql                                
 Use SQLCMD syntax to reference a variable in the post-deployment script.        
 Example:      :setvar TableName MyTable                            
               SELECT * FROM [$(TableName)]                    
--------------------------------------------------------------------------------------
*/

IF NOT EXISTS (SELECT 1 FROM dbo.RoomTypes)
BEGIN
  INSERT INTO dbo.RoomTypes(Title,Description)
  VALUES
    ('Single King Size Bed', 'A room with a single king-size bed and a window.'),
    ('Two King Size Beds', 'A room with two king-size beds and a window.'),
    ('Executive Suite', 'Two rooms, each with a king-size bed and a window.');
END

IF NOT EXISTS (SELECT 1 FROM dbo.RoomStatuses)
BEGIN
  INSERT INTO dbo.RoomStatuses(Title)
  VALUES
    ('Available'),
    ('Booked'),
    ('Occupied');
END

IF NOT EXISTS (SELECT 1 FROM dbo.Rooms)
BEGIN
  INSERT INTO dbo.Rooms(Number,StatusId,TypeId)
  VALUES
    ('101', 1, 1),
    ('102', 1, 2),
    ('201', 1, 1),
    ('202', 1, 2),
    ('301', 1, 1),
    ('302', 1, 2),
    ('401', 1, 3),
    ('402', 1, 3);
END

IF NOT EXISTS (SELECT 1 FROM dbo.Guests)
BEGIN
  INSERT INTO dbo.Guests(FirstName,LastName,Email,PhoneNumber)
  VALUES
    ('Alex', 'Fed', 'a@a.com', '555-1111'),
    ('Abbra', 'Greg', 'b@a.com', '555-1112'),
    ('Anna', 'Ty', 'c@a.com', '555-1113');
END

IF NOT EXISTS (SELECT 1 FROM dbo.BookingStatuses)
BEGIN
  INSERT INTO dbo.BookingStatuses(Title)
  VALUES
    ('Confirmed'),
    ('Pending'),
    ('Closed'),
    ('Cancelled');
END

IF NOT EXISTS (SELECT 1 FROM dbo.Bookings)
BEGIN
  INSERT INTO dbo.Bookings(StartDate,EndDate,RoomId,GuestId,StatusId,TotalCost)
  VALUES
    ('2024-11-12', '2024-11-31', 1, 1, 1, 1059.99),
    ('2024-11-15', '2024-11-18', 8, 2, 1, 399.78),
    ('2024-12-01', '2024-12-04', 6, 3, 1, 994.35);
END

