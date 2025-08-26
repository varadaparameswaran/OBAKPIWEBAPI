using System;
using System.Collections.Generic;

namespace OBAKPIWEBAPI.EF_Models;

public partial class Appraisal
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public bool? IsDeleted { get; set; }

    public DateTime? LastUpdate { get; set; }

    public string? Guid { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsCsm { get; set; }

    public bool? IsCrew { get; set; }

    public virtual ICollection<AppraisalSection> AppraisalSections { get; set; } = new List<AppraisalSection>();

    public virtual ICollection<CrewAppraisal> CrewAppraisals { get; set; } = new List<CrewAppraisal>();
}
