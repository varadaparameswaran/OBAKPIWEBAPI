using System;
using System.Collections.Generic;

namespace OBAKPIWEBAPI.EF_Models;

public partial class CrewTransportCategory
{
    public int Id { get; set; }

    public string? Category { get; set; }

    public string? CategoryDesc { get; set; }

    public bool? IsDeleted { get; set; }

    public bool? IsActive { get; set; }

    public virtual ICollection<CrewTransportRequest> CrewTransportRequests { get; set; } = new List<CrewTransportRequest>();
}
