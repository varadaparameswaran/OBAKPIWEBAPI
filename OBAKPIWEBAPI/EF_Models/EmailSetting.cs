using System;
using System.Collections.Generic;

namespace OBAKPIWEBAPI.EF_Models;

public partial class EmailSetting
{
    public int Id { get; set; }

    public string? Smtpserver { get; set; }

    public string? Smtpport { get; set; }

    public string? EmailUsername { get; set; }

    public string? EmailFromPass { get; set; }

    public string? EmailFrom { get; set; }

    public string? Type { get; set; }
}
