using System;
using System.Collections.Generic;

namespace OBAKPIWEBAPI.EF_Models;

public partial class AppraisalQuestionAnswer
{
    public int Id { get; set; }

    public int? QuestionId { get; set; }

    public string? Answer { get; set; }

    public string? Description { get; set; }

    public int? OrderNum { get; set; }

    public bool? IsDeleted { get; set; }

    public DateTime? LastUpdate { get; set; }

    public string? Guid { get; set; }

    public int? Score { get; set; }

    public virtual ICollection<CrewAppraisalEval> CrewAppraisalEvals { get; set; } = new List<CrewAppraisalEval>();

    public virtual AppraisalSectionQuestion? Question { get; set; }
}
