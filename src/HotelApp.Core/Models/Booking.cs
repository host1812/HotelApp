using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApp.Core.Models;
public class Booking
{
    public int Id { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public int RoomTypeId { get; set; }
    public int GuestId { get; set; }
    public int StatusId { get; set; }
    public decimal TotalCost { get; set; }
}
