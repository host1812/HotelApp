using HotelApp.Core.Databases;
using HotelApp.Core.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApp.Core.Services;
public class BookingService : IBookingService
{
    private readonly ILogger<BookingService> logger;
    private readonly IDataAccess da;

    public BookingService(ILogger<BookingService> logger, IDataAccess da)
    {
        this.logger = logger;
        this.da = da;
    }

    public List<Booking> GetBooking()
    {
        var sql = "SELECT Id, StartDate, EndDate, RoomTypeId, GuestId, StatusId, TotalCost FROM dbo.Bookings";
        var results = da.LoadData<Booking, dynamic>(sql, new { });
        logger.LogInformation("Got list of all bookings from the database");
        return results;
    }

    public List<Booking> GetBooking(DateTime startDate, DateTime endDate)
    {
        var sql = "SELECT Id, StartDate, EndDate, RoomTypeId, GuestId, StatusId, TotalCost FROM dbo.Bookings WHERE StartDate >= @StartDate AND EndDate <= @EndDate";
        var results = da.LoadData<Booking, dynamic>(sql, new { StartDate = startDate, EndDate = endDate });
        logger.LogInformation($"Got list of bookings for specific dates from the database. StartDate: {startDate}, EndDate: {endDate}");
        return results;
    }
}
