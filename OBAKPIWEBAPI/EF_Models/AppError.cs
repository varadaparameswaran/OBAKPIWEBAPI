using System;
using System.Collections.Generic;

namespace OBAKPIWEBAPI.EF_Models;

public partial class AppError
{
    public int Id { get; set; }

    public string? PageName { get; set; }

    public string? FunctionName { get; set; }

    public string? ErrorMessage { get; set; }

    public string? LineNumber { get; set; }

    public DateTime? Datetime { get; set; }

    public string? StaffNumber { get; set; }

    public string? ApplicationName { get; set; }

    public string? VersionNumber { get; set; }
}
