using System;
using System.Collections.Generic;

namespace OBAKPIWEBAPI.EF_Models;

public partial class BlockDeleteLog
{
    public int Id { get; set; }

    public string? BlockNo { get; set; }

    public int? BlockId { get; set; }

    public DateTime? DeleteTime { get; set; }

    public string? StaffNumber { get; set; }

    public DateTime? BlockDate { get; set; }

    public string? DeleteIntervelSetting { get; set; }
}
