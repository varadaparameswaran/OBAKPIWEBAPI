using System;
using System.Collections.Generic;

namespace OBAKPIWEBAPI.EF_Models;

public partial class LayoverCategory
{
    public int Id { get; set; }

    public string? CategoryName { get; set; }

    public virtual ICollection<LayoverBid> LayoverBids { get; set; } = new List<LayoverBid>();
}
