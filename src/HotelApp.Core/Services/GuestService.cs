using HotelApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApp.Core.Services;
public class GuestService
{
    public List<Guest> GetGuest()
    {
        return [];
    }

    public Guest GetGuestById(int id)
    {
        return new Guest { };
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
