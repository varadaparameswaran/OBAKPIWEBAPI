using System;
using System.Collections.Generic;

namespace OBAKPIWEBAPI.EF_Models;

public partial class OcbCrewPo
{
    public int Id { get; set; }

    public string? StaffNumber { get; set; }

    public string? Category { get; set; }

    public string? Nurse { get; set; }

    public int? PosId { get; set; }

    public bool? ManualAdd { get; set; }

    public bool? IsDeleted { get; set; }

    public DateTime? LastUpdate { get; set; }

    public string? Guid { get; set; }

    public int? BlockId { get; set; }

    public virtual OcbBlock? Block { get; set; }

    public virtual ICollection<CrewAppraisal> CrewAppraisals { get; set; } = new List<CrewAppraisal>();

    public virtual ICollection<FamForm> FamForms { get; set; } = new List<FamForm>();

    public virtual ICollection<OcbComment> OcbComments { get; set; } = new List<OcbComment>();

    public virtual ICollection<OcbCrewPosHistory> OcbCrewPosHistories { get; set; } = new List<OcbCrewPosHistory>();

    public virtual OcbAcPo? Pos { get; set; }

    public virtual ICollection<PreFlightCrewTest> PreFlightCrewTests { get; set; } = new List<PreFlightCrewTest>();

    public virtual ICollection<PreFlightTestExlude> PreFlightTestExludes { get; set; } = new List<PreFlightTestExlude>();

    public virtual CrewDetail? StaffNumberNavigation { get; set; }
}
