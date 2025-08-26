using System;
using System.Collections.Generic;

namespace OBAKPIWEBAPI.EF_Models;

public partial class PilotDetail
{
    public string StaffNumber { get; set; } = null!;

    public string? FullName { get; set; }

    public string? Nation { get; set; }

    public string? Category { get; set; }

    public string? Lang1 { get; set; }

    public string? Lang2 { get; set; }

    public string? Lang3 { get; set; }

    public string? Lang4 { get; set; }

    public string? Sex { get; set; }

    public string? Address1 { get; set; }

    public string? Address2 { get; set; }

    public string? Address3 { get; set; }

    public string? Pa { get; set; }
}
