using System;
using System.Collections.Generic;

namespace OBAKPIWEBAPI.EF_Models;

public partial class CrewGroomingHairColor
{
    public int Id { get; set; }

    public string? HairClr { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsDeleted { get; set; }

    public virtual ICollection<CrewGrooming> CrewGroomings { get; set; } = new List<CrewGrooming>();
}
