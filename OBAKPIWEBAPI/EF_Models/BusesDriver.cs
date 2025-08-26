using System;
using System.Collections.Generic;

namespace OBAKPIWEBAPI.EF_Models;

public partial class BusesDriver
{
    public int Id { get; set; }

    public int? BusId { get; set; }

    public int? DriverId { get; set; }

    public virtual Bus? Bus { get; set; }

    public virtual DreversAccount? Driver { get; set; }
}
