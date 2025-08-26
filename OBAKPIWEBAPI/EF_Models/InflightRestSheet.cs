using System;
using System.Collections.Generic;

namespace OBAKPIWEBAPI.EF_Models;

public partial class InflightRestSheet
{
    public int Id { get; set; }

    public int FlightId { get; set; }

    public string RestingStaff { get; set; } = null!;

    public string TakingOverStaff { get; set; } = null!;

    public string Location { get; set; } = null!;

    public DateTime StartTime { get; set; }

    public DateTime EndTime { get; set; }

    public string TotalTime { get; set; } = null!;
}
