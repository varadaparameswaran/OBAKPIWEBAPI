using System;
using System.Collections.Generic;

namespace OBAKPIWEBAPI.EF_Models;

public partial class Fleet
{
    public int Id { get; set; }

    public string? Fleet1 { get; set; }

    public virtual ICollection<PreFlightCategory> PreFlightCategories { get; set; } = new List<PreFlightCategory>();
}
