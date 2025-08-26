using System;
using System.Collections.Generic;

namespace OBAKPIWEBAPI.EF_Models;

public partial class AppraisalTeamLead
{
    public int Id { get; set; }

    public string? StaffNumber { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsDeleted { get; set; }

    public string? FullName { get; set; }

    public string? StaffData { get; set; }

    public string? Category { get; set; }

    public string? TeamName { get; set; }

    public virtual ICollection<CrewTeamAssignment> CrewTeamAssignments { get; set; } = new List<CrewTeamAssignment>();
}
