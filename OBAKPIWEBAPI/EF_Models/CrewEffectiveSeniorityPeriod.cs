using System;
using System.Collections.Generic;

namespace OBAKPIWEBAPI.EF_Models;

public partial class CrewEffectiveSeniorityPeriod
{
    public int Id { get; set; }

    public int? Cesid { get; set; }

    public int? PeriodId { get; set; }

    public int? PeriodSeniority { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsDeleted { get; set; }

    public virtual CrewEffectiveSeniority? Ces { get; set; }

    public virtual SeniorityPeriodDetail? Period { get; set; }
}
