using System;
using System.Collections.Generic;

namespace OBAKPIWEBAPI.EF_Models;

public partial class AirportCode
{
    public int Id { get; set; }

    public string? Country { get; set; }

    public string? City { get; set; }

    public string? Code { get; set; }

    public string? AirportName { get; set; }

    public virtual ICollection<LayoverBid> LayoverBids { get; set; } = new List<LayoverBid>();
}
