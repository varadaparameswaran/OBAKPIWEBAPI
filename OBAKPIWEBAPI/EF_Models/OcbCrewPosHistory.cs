using System;
using System.Collections.Generic;

namespace OBAKPIWEBAPI.EF_Models;

public partial class OcbCrewPosHistory
{
    public int Id { get; set; }

    public int CrewPosId { get; set; }

    public int PosId { get; set; }

    public virtual OcbCrewPo CrewPos { get; set; } = null!;

    public virtual OcbAcPo Pos { get; set; } = null!;
}
