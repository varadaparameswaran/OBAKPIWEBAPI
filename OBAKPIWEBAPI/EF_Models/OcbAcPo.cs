using System;
using System.Collections.Generic;

namespace OBAKPIWEBAPI.EF_Models;

public partial class OcbAcPo
{
    public int Id { get; set; }

    public string? Eqp { get; set; }

    public string? PosCode { get; set; }

    public string? PosDisc { get; set; }

    public string? Door { get; set; }

    public string? Family { get; set; }

    public virtual ICollection<OcbCrewPo> OcbCrewPos { get; set; } = new List<OcbCrewPo>();

    public virtual ICollection<OcbCrewPosHistory> OcbCrewPosHistories { get; set; } = new List<OcbCrewPosHistory>();
}
