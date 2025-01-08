using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApp.Core.Models;
public class Room
{
    public int Id { get; set; }
    public string Number { get; set; } = string.Empty;
    public int TypeId { get; set; }
    public int StatusId { get; set; }
}
