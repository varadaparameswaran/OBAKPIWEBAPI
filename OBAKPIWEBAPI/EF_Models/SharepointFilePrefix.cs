using System;
using System.Collections.Generic;

namespace OBAKPIWEBAPI.EF_Models;

public partial class SharepointFilePrefix
{
    public int Id { get; set; }

    public string? FilePrefix { get; set; }

    public bool? Isactive { get; set; }

    public bool? Isdeleted { get; set; }
}
