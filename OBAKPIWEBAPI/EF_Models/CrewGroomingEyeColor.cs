using System;
using System.Collections.Generic;

namespace OBAKPIWEBAPI.EF_Models;

public partial class CrewGroomingEyeColor
{
    public int Id { get; set; }

    public string? EyeClr { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsDeleted { get; set; }

    public virtual ICollection<CrewGrooming> CrewGroomings { get; set; } = new List<CrewGrooming>();
}
