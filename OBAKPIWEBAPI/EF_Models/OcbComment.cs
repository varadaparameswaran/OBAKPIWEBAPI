using System;
using System.Collections.Generic;

namespace OBAKPIWEBAPI.EF_Models;

public partial class OcbComment
{
    public int Id { get; set; }

    public int? CrewPosId { get; set; }

    public string? Comment { get; set; }

    public DateTime? DateTime { get; set; }

    public string? Time { get; set; }

    public virtual OcbCrewPo? CrewPos { get; set; }
}
