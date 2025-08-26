using System;
using System.Collections.Generic;

namespace OBAKPIWEBAPI.EF_Models;

public partial class DocCrewLog
{
    public int Id { get; set; }

    public int? VersionId { get; set; }

    public string? StaffNumber { get; set; }

    public DateTime? AcknowledgementDateTime { get; set; }
}
