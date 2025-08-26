using System;
using System.Collections.Generic;

namespace OBAKPIWEBAPI.EF_Models;

public partial class Bus
{
    public int Id { get; set; }

    public string? BusNumber { get; set; }

    public int? BusCapacity { get; set; }

    public bool? IsDeleted { get; set; }

    public virtual ICollection<BusesAllocation> BusesAllocations { get; set; } = new List<BusesAllocation>();

    public virtual ICollection<BusesDriver> BusesDrivers { get; set; } = new List<BusesDriver>();

    public virtual ICollection<CrewTransport> CrewTransports { get; set; } = new List<CrewTransport>();

    public virtual ICollection<PickupDetail> PickupDetails { get; set; } = new List<PickupDetail>();
}
