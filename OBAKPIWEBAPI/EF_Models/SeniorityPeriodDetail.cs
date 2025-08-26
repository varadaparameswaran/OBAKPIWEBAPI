using System;
using System.Collections.Generic;

namespace OBAKPIWEBAPI.EF_Models;

public partial class SeniorityPeriodDetail
{
    public int Id { get; set; }

    public int? PeriodMonth { get; set; }

    public int? PeriodYear { get; set; }

    public bool? IsActive { get; set; }

    public virtual ICollection<CrewEffectiveSeniorityPeriod> CrewEffectiveSeniorityPeriods { get; set; } = new List<CrewEffectiveSeniorityPeriod>();
}
