using System;
using System.Collections.Generic;

namespace OBAKPIWEBAPI.EF_Models;

public partial class CrewGroomingWeightStatus
{
    public int Id { get; set; }

    public string? WeightStatus { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsDeleted { get; set; }

    public virtual ICollection<CrewGrooming> CrewGroomings { get; set; } = new List<CrewGrooming>();

    public virtual ICollection<CrewWeightDetailList> CrewWeightDetailLists { get; set; } = new List<CrewWeightDetailList>();
}
