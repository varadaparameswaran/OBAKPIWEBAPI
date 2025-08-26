using System;
using System.Collections.Generic;

namespace OBAKPIWEBAPI.EF_Models;

public partial class VwRecency
{
    public long? Seqnum { get; set; }

    public string StaffNumber { get; set; } = null!;

    public DateTime? BlockDate { get; set; }

    public string? PosCode { get; set; }

    public string? FullName { get; set; }

    public string? Family { get; set; }

    public DateTime? ExpiryDate { get; set; }
}
