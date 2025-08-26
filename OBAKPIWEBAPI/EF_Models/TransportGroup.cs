using System;
using System.Collections.Generic;

namespace OBAKPIWEBAPI.EF_Models;

public partial class TransportGroup
{
    public int Id { get; set; }

    public string? GroupName { get; set; }

    public virtual ICollection<BusesAllocation> BusesAllocations { get; set; } = new List<BusesAllocation>();

    public virtual ICollection<PickupDetail> PickupDetails { get; set; } = new List<PickupDetail>();
}
