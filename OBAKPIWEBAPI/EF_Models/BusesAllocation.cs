using System;
using System.Collections.Generic;

namespace OBAKPIWEBAPI.EF_Models;

public partial class BusesAllocation
{
    public int Id { get; set; }

    public int? BusId { get; set; }

    public int? GroupId { get; set; }

    public DateTime? PickipDateTime { get; set; }

    public virtual Bus? Bus { get; set; }

    public virtual TransportGroup? Group { get; set; }
}
