using System;
using System.Collections.Generic;

namespace OBAKPIWEBAPI.EF_Models;

public partial class MealsCount
{
    public int Id { get; set; }

    public int? J { get; set; }

    public int? Y { get; set; }

    public int? S { get; set; }

    public bool? IsDeleted { get; set; }

    public DateTime? LastUpdate { get; set; }

    public string? Guid { get; set; }

    public int? FlightId { get; set; }

    public virtual OcbFlight? Flight { get; set; }
}
