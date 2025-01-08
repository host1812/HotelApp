using HotelApp.Core.Models;

namespace HotelApp.Core.Services;
public interface IRoomService
{
    List<Room> GetRooms();
}