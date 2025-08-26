using System;
using System.Collections.Generic;

namespace OBAKPIWEBAPI.EF_Models;

public partial class CrewDocumentStatusHistory
{
    public int Id { get; set; }

    public int DocumentId { get; set; }

    public string? StaffNumber { get; set; }

    public string? Comments { get; set; }

    public string? Status { get; set; }

    public DateTime? ChangeDt { get; set; }

    public string? AttachmentPath { get; set; }

    public virtual PilotCrewDocument Document { get; set; } = null!;
}
