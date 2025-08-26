using System;
using System.Collections.Generic;

namespace OBAKPIWEBAPI.EF_Models;

public partial class CrewDetail
{
    public string StaffNumber { get; set; } = null!;

    public string? FullName { get; set; }

    public string? Nation { get; set; }

    public string? Category { get; set; }

    public string? Lang1 { get; set; }

    public string? Lang2 { get; set; }

    public string? Lang3 { get; set; }

    public string? Lang4 { get; set; }

    public string? Sex { get; set; }

    public string? Address1 { get; set; }

    public string? Address2 { get; set; }

    public string? Address3 { get; set; }

    public string? Pa { get; set; }

    public virtual ICollection<CrewTeamAssignment> CrewTeamAssignments { get; set; } = new List<CrewTeamAssignment>();

    public virtual ICollection<CrewTransport> CrewTransports { get; set; } = new List<CrewTransport>();

    public virtual ICollection<OcbCrewPo> OcbCrewPos { get; set; } = new List<OcbCrewPo>();

    public virtual ICollection<OutOfBase> OutOfBases { get; set; } = new List<OutOfBase>();

    public virtual ICollection<PickupDetail> PickupDetails { get; set; } = new List<PickupDetail>();

    public virtual ICollection<SharePointLog> SharePointLogs { get; set; } = new List<SharePointLog>();

    public virtual ICollection<SharePointLogsTable> SharePointLogsTables { get; set; } = new List<SharePointLogsTable>();
}
