using HotelApp.Core.Databases;
using HotelApp.Core.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApp.Core.Services;
public class GuestService
{
    private readonly ILogger<GuestService> logger;
    private readonly IDataAccess da;
    
    public GuestService(ILogger<GuestService> logger, IDataAccess da)
    {
        this.logger = logger;
        this.da = da;
    }

    public List<Guest> GetGuest()
    {
        var sql = "SELECT Id, FirstName, LastName, Email, PhoneNumber FROM dbo.Guests";
        var results = da.LoadData<Guest, dynamic>(sql, new { });
        logger.LogInformation("Successfully got all guests from the database");
        return results;
    }

    public Guest GetGuestById(int id)
    {
        var sql = "SELECT Id, FirstName, LastName, Email, PhoneNumber FROM dbo.Guests WHERE Id = $Id";
        var results = da.LoadData<Guest, dynamic>(sql, new { Id = id });
        logger.LogInformation($"Successfully got guest from the database. Id = {id}");
        return results[0];
    }

    public Guest GetGuestByFirstName(string firstName)
    {
        return new Guest { };
    }

    public Guest GetGuestByLastName(string lastName)
    {
        return new Guest { };
    }

    public Guest GetGuestByEmail(string email)
    {
        return new Guest { };
    }

}
