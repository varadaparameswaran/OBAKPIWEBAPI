using System;
using System.Collections.Generic;

namespace OBAKPIWEBAPI.EF_Models;

public partial class CrewAppraisalEval
{
    public int Id { get; set; }

    public int? CrewAppraisalId { get; set; }

    public int? QuestionId { get; set; }

    public int? SectionId { get; set; }

    public string? Comments { get; set; }

    public bool? IsDeleted { get; set; }

    public DateTime? LastUpdate { get; set; }

    public string? Guid { get; set; }

    public int? AnswerId { get; set; }

    public virtual AppraisalQuestionAnswer? Answer { get; set; }

    public virtual AppraisalSection? Section { get; set; }
}
