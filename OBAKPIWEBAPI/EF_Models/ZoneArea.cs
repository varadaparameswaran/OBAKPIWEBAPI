using System;
using System.Collections.Generic;

namespace OBAKPIWEBAPI.EF_Models;

public partial class ZoneArea
{
    public int Id { get; set; }

    public int? ZoneId { get; set; }

    public string? Area { get; set; }

    public virtual Zone? Zone { get; set; }
}
