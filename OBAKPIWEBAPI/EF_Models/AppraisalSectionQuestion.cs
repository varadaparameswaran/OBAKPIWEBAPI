using System;
using System.Collections.Generic;

namespace OBAKPIWEBAPI.EF_Models;

public partial class AppraisalSectionQuestion
{
    public int Id { get; set; }

    public int? AppraisalSectionId { get; set; }

    public string? Title { get; set; }

    public string? Question { get; set; }

    public bool? IsDeleted { get; set; }

    public DateTime? LastUpdate { get; set; }

    public string? Guid { get; set; }

    public bool? HasComment { get; set; }

    public int? OrderNumber { get; set; }

    public virtual ICollection<AppraisalQuestionAnswer> AppraisalQuestionAnswers { get; set; } = new List<AppraisalQuestionAnswer>();

    public virtual AppraisalSection? AppraisalSection { get; set; }
}
