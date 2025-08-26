using System;
using System.Collections.Generic;

namespace OBAKPIWEBAPI.EF_Models;

public partial class CrewLeaveRequest
{
    public int Id { get; set; }

    public string? StaffNumber { get; set; }

    public DateTime? FromDate { get; set; }

    public DateTime? ToDate { get; set; }

    public string? LeaveReason { get; set; }

    public string? Status { get; set; }

    public DateTime? SubmittedTime { get; set; }

    public string? AdminReason { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsDeleted { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDt { get; set; }

    public virtual PilotCrewDetail? StaffNumberNavigation { get; set; }
}
