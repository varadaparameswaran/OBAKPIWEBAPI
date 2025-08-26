using System;
using System.Collections.Generic;

namespace OBAKPIWEBAPI.EF_Models;

public partial class PreFlightComment
{
    public int Id { get; set; }

    public int CrewTestId { get; set; }

    public string? Comments { get; set; }

    public string? StaffNumber { get; set; }

    public string? DelayTime { get; set; }

    public virtual PreFlightCrewTest CrewTest { get; set; } = null!;
}
