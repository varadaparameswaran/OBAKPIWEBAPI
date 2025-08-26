using System;
using System.Collections.Generic;

namespace OBAKPIWEBAPI.EF_Models;

public partial class CrewCategory
{
    public int Id { get; set; }

    public string? Category { get; set; }

    public int? CategoryOrder { get; set; }

    public bool? IsDeleted { get; set; }

    public DateTime? LastUpdate { get; set; }

    public string? Guid { get; set; }
}
