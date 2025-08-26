using System;
using System.Collections.Generic;

namespace OBAKPIWEBAPI.EF_Models;

public partial class PilotCrewDocument
{
    public int Id { get; set; }

    public int DocumentType { get; set; }

    public string? StaffNumber { get; set; }

    public string? Comments { get; set; }

    public string? Status { get; set; }

    public DateTime? SubmitedDt { get; set; }

    public string? AdminReason { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsDeleted { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDt { get; set; }

    public string? AttachmentPath { get; set; }

    public string? FileName { get; set; }

    public virtual ICollection<CrewDocumentStatusHistory> CrewDocumentStatusHistories { get; set; } = new List<CrewDocumentStatusHistory>();

    public virtual CrewDocumentCategory DocumentTypeNavigation { get; set; } = null!;

    public virtual ICollection<PilotCrewDocRejectReason> PilotCrewDocRejectReasons { get; set; } = new List<PilotCrewDocRejectReason>();

    public virtual ICollection<PilotCrewDocumentStatusHistory> PilotCrewDocumentStatusHistories { get; set; } = new List<PilotCrewDocumentStatusHistory>();

    public virtual PilotCrewDetail? StaffNumberNavigation { get; set; }
}
