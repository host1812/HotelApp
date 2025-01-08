using HotelApp.Core.Databases;
using HotelApp.Core.Models;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
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
        var sql = "SELECT * FROM dbo.Rooms";
        var results = da.LoadData<Room, dynamic>(sql, new { });
        logger.LogInformation("Successfully got data from the database");
        return results;
    }
}
