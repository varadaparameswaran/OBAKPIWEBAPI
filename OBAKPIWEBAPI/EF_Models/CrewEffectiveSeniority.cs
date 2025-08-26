using System;
using System.Collections.Generic;

namespace OBAKPIWEBAPI.EF_Models;

public partial class CrewEffectiveSeniority
{
    public int Id { get; set; }

    public string? CrewId { get; set; }

    public int? GroupNo { get; set; }

    public int? GroupSeniority { get; set; }

    public bool? IsActive { get; set; }

    public string? Fleet { get; set; }

    public int? NetSeniority { get; set; }

    public virtual PilotCrewDetail? Crew { get; set; }

    public virtual ICollection<CrewEffectiveSeniorityPeriod> CrewEffectiveSeniorityPeriods { get; set; } = new List<CrewEffectiveSeniorityPeriod>();
}
