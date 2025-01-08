using HotelApp.Core.Models;

namespace HotelApp.Blazor.Models;

public class RoomView
{
    public int Id { get; set; }
    public string Number { get; set; } = string.Empty;
    public RoomType Type { get; set; } = new RoomType();
    public RoomStatus Status { get; set; } = new RoomStatus();
}
