using System;
using System.Collections.Generic;

namespace OBAKPIWEBAPI.EF_Models;

public partial class PairingCategory
{
    public int Id { get; set; }

    public string? CategoryName { get; set; }

    public int? SeperationDay { get; set; }

    public virtual ICollection<LayoverPairing> LayoverPairings { get; set; } = new List<LayoverPairing>();
}
