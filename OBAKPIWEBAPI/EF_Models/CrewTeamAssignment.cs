using System;
using System.Collections.Generic;

namespace OBAKPIWEBAPI.EF_Models;

public partial class CrewTeamAssignment
{
    public int Id { get; set; }

    public string? StaffNumber { get; set; }

    public int? TeamId { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsDeleted { get; set; }

    public string? Status { get; set; }

    public string? UpdatedBy { get; set; }

    public virtual CrewDetail? StaffNumberNavigation { get; set; }

    public virtual AppraisalTeamLead? Team { get; set; }
}
