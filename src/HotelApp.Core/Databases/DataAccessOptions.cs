using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApp.Core.Databases;

public class DataAccessOptions
{
    public bool IsStoredProcesure { get; set; }

    public delegate DataAccessOptions GetOptions();
}
