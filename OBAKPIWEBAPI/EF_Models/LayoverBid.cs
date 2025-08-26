using System;
using System.Collections.Generic;

namespace OBAKPIWEBAPI.EF_Models;

public partial class LayoverBid
{
    public int Id { get; set; }

    public int? CatId { get; set; }

    public int? StnId { get; set; }

    public string? FcBoingBidlimit { get; set; }

    public string? FcAirbusBidlimit { get; set; }

    public string? CmBidlimit { get; set; }

    public string? CsBidlimit { get; set; }

    public string? FgFaBidlimit { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsDeleted { get; set; }

    public virtual LayoverCategory? Cat { get; set; }

    public virtual AirportCode? Stn { get; set; }
}
