using System;
using System.Collections.Generic;

namespace OBAKPIWEBAPI.EF_Models;

public partial class VwRecencySummary
{
    public string StaffNumber { get; set; } = null!;

    public DateTime? BlockDate { get; set; }

    public string? FullName { get; set; }

    public string? Family { get; set; }

    public DateTime? ExpiryDate { get; set; }
}
