using HotelApp.Core.Databases;
using HotelApp.Core.Models;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HotelApp.Core.Services;
public class RoomService : IRoomService
{
    private readonly ILogger<RoomService> logger;
    private readonly IDataAccess da;

    public RoomService(ILogger<RoomService> logger, IDataAccess da)
    {
        this.logger = logger;
        this.da = da;
    }

    public List<Room> GetRooms()
    {
        var sql = "SELECT Id, Number, StatusId, TypeId FROM dbo.Rooms";
        var rooms = da.LoadData<Room, dynamic>(sql, new { });
        logger.LogInformation("Successfully got data from the database");
        return rooms;
    }

    public List<RoomType> GetRoomTypes()
    {
        var sql = "SELECT Id, Title, Description, BasePrice FROM dbo.RoomTypes";
        var roomTypes = da.LoadData<RoomType, dynamic>(sql, new { });
        logger.LogInformation("Successfully got data from the database");
        return roomTypes;
    }
    public List<RoomStatus> GetRoomStatuses()
    {
        var sql = "SELECT Id, Title FROM dbo.RoomStatuses";
        var roomStatuses = da.LoadData<RoomStatus, dynamic>(sql, new { });
        logger.LogInformation("Successfully got data from the database");
        return roomStatuses;
    }
}
