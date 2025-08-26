using System;
using System.Collections.Generic;

namespace OBAKPIWEBAPI.EF_Models;

public partial class AiportTimeZone
{
    public int Id { get; set; }

    public string? AirportCode { get; set; }

    public int? TimeDiff { get; set; }
}
