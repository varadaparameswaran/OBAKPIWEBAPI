using System;
using System.Collections.Generic;

namespace OBAKPIWEBAPI.EF_Models;

public partial class Zone
{
    public int Id { get; set; }

    public string? ZoneLetter { get; set; }

    public string? Governorates { get; set; }

    public virtual ICollection<CrewTransport> CrewTransports { get; set; } = new List<CrewTransport>();

    public virtual ICollection<ZoneArea> ZoneAreas { get; set; } = new List<ZoneArea>();
}
