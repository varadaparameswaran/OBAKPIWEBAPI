using System;
using System.Collections.Generic;

namespace OBAKPIWEBAPI.EF_Models;

public partial class PreFlightFailedComment
{
    public int Id { get; set; }

    public string? Comments { get; set; }

    public int? CrewPosId { get; set; }

    public DateTime? CommentDate { get; set; }

    public int? CrewTestId { get; set; }

    public virtual PreFlightCrewTest? CrewTest { get; set; }
}
