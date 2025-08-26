using System;
using System.Collections.Generic;

namespace OBAKPIWEBAPI.EF_Models;

public partial class CrewAccessIdAttachment
{
    public int Id { get; set; }

    public string StaffNumber { get; set; } = null!;

    public string AttachmentPath { get; set; } = null!;

    public DateTime SubmissionDate { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public string? GeneratedAccessId { get; set; }
}
