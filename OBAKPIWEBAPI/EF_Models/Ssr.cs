using System;
using System.Collections.Generic;

namespace OBAKPIWEBAPI.EF_Models;

public partial class Ssr
{
    public int Id { get; set; }

    public string? FltSeqNr { get; set; }

    public string? Origin { get; set; }

    public string? Destination { get; set; }

    public string? PaxName { get; set; }

    public string? BookingClass { get; set; }

    public string? ReqType { get; set; }

    public bool? IsDeleted { get; set; }

    public DateTime? LastUpdate { get; set; }

    public string? Guid { get; set; }

    public int? FlightId { get; set; }

    public virtual OcbFlight? Flight { get; set; }
}
