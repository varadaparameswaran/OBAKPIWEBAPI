using System;
using System.Collections.Generic;

namespace OBAKPIWEBAPI.EF_Models;

public partial class PilotCrewDocRejectReason
{
    public int Id { get; set; }

    public int DocId { get; set; }

    public int ReasonId { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public int? HistoryId { get; set; }

    public virtual PilotCrewDocument Doc { get; set; } = null!;

    public virtual PilotCrewDocumentStatusHistory? History { get; set; }

    public virtual DocumentRejectReason Reason { get; set; } = null!;
}
