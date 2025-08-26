using System;
using System.Collections.Generic;

namespace OBAKPIWEBAPI.EF_Models;

public partial class SsrCount
{
    public int Id { get; set; }

    public string? ReqType { get; set; }

    public int? TotalCount { get; set; }

    public bool? IsDeleted { get; set; }

    public DateTime? LastUpdate { get; set; }

    public string? Guid { get; set; }

    public int? FlightId { get; set; }

    public virtual OcbFlight? Flight { get; set; }
}
