using System;
using System.Collections.Generic;

namespace OBAKPIWEBAPI.EF_Models;

public partial class DocumentRejectReason
{
    public int Id { get; set; }

    public string Description { get; set; } = null!;

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public virtual ICollection<PilotCrewDocRejectReason> PilotCrewDocRejectReasons { get; set; } = new List<PilotCrewDocRejectReason>();
}
