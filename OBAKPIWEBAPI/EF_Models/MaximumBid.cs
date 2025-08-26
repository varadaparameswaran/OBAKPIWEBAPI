using System;
using System.Collections.Generic;

namespace OBAKPIWEBAPI.EF_Models;

public partial class MaximumBid
{
    public int Id { get; set; }

    public string? BidType { get; set; }

    public string? FcBoingMax { get; set; }

    public string? FcAirbusMax { get; set; }

    public string? CmMax { get; set; }

    public string? CsMax { get; set; }

    public string? FgFaMax { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsDeleted { get; set; }
}
