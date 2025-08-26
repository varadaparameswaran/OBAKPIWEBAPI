using System;
using System.Collections.Generic;

namespace OBAKPIWEBAPI.EF_Models;

public partial class AppraisalSection
{
    public int Id { get; set; }

    public int? AppraisalId { get; set; }

    public string? Title { get; set; }

    public bool? IsDeleted { get; set; }

    public DateTime? LastUpdate { get; set; }

    public string? Guid { get; set; }

    public bool? HasComment { get; set; }

    public int? OrderNumber { get; set; }

    public bool? IsCsm { get; set; }

    public virtual Appraisal? Appraisal { get; set; }

    public virtual ICollection<AppraisalSectionQuestion> AppraisalSectionQuestions { get; set; } = new List<AppraisalSectionQuestion>();

    public virtual ICollection<CrewAppraisalEval> CrewAppraisalEvals { get; set; } = new List<CrewAppraisalEval>();
}
