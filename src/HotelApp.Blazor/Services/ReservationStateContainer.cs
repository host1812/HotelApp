using HotelApp.Core.Models;

namespace HotelApp.Blazor.Services;

public class ReservationStateContainer
{
    private RoomType? roomType;

    public RoomType? Value
    {
        get => roomType;
        set
        {
            roomType = value;
            NotifyStateChanged();
        }
    }

    public event Action? OnChange;

    private void NotifyStateChanged() => OnChange?.Invoke();
}
