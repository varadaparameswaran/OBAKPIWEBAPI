using System;
using System.Collections.Generic;

namespace OBAKPIWEBAPI.EF_Models;

public partial class EvalSectionsComment
{
    public int Id { get; set; }

    public int? CrewAppraisalId { get; set; }

    public int? SectionId { get; set; }

    public string? Comment { get; set; }

    public bool? IsDeleted { get; set; }

    public DateTime? LastUpdate { get; set; }

    public string? Guid { get; set; }
}
