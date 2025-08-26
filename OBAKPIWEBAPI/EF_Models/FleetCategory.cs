using System;
using System.Collections.Generic;

namespace OBAKPIWEBAPI.EF_Models;

public partial class FleetCategory
{
    public int Id { get; set; }

    public string? Fleet { get; set; }

    public virtual ICollection<LayoverPairing> LayoverPairings { get; set; } = new List<LayoverPairing>();
}
