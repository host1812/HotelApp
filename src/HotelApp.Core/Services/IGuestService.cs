using HotelApp.Core.Models;

namespace HotelApp.Core.Services;
public interface IGuestService
{
    List<Guest> GetGuest();
    Guest GetGuestByEmail(string email);
    Guest GetGuestByFirstName(string firstName);
    Guest GetGuestById(int id);
    Guest GetGuestByLastName(string lastName);
}