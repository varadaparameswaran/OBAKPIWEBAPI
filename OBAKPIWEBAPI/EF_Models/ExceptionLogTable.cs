using System;
using System.Collections.Generic;

namespace OBAKPIWEBAPI.EF_Models;

public partial class ExceptionLogTable
{
    public int Id { get; set; }

    public string? StaffNumber { get; set; }

    public string? RunTimeDt { get; set; }

    public string? ExceptionThrown { get; set; }
}
