using HotelApp.Core.Models;

namespace HotelApp.Core.Services;
public interface IBookingService
{
    List<Booking> GetBooking();
    List<Booking> GetBooking(DateTime startDate, DateTime endDate);
}