using System;
using System.Collections.Generic;

namespace OBAKPIWEBAPI.EF_Models;

public partial class OcbNotification
{
    public int Id { get; set; }

    public int? FlightId { get; set; }

    public string? Comments { get; set; }

    public bool? IsDeleted { get; set; }

    public DateTime? LastUpdate { get; set; }

    public string? Guid { get; set; }

    public virtual OcbFlight? Flight { get; set; }
}
