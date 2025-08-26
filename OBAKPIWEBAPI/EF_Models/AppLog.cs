using System;
using System.Collections.Generic;

namespace OBAKPIWEBAPI.EF_Models;

public partial class AppLog
{
    public int Id { get; set; }

    public string? ApplicationName { get; set; }

    public DateTime? ActionDateTime { get; set; }

    public string? ActionDesc { get; set; }

    public string? Type { get; set; }

    public string? JobGuid { get; set; }
}
