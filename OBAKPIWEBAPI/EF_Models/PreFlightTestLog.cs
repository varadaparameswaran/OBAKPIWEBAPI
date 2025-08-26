using System;
using System.Collections.Generic;

namespace OBAKPIWEBAPI.EF_Models;

public partial class PreFlightTestLog
{
    public int Id { get; set; }

    public int AnswerId { get; set; }

    public bool IsSecondChance { get; set; }

    public int CrewTestId { get; set; }

    public virtual PreFlightAnswer Answer { get; set; } = null!;

    public virtual PreFlightCrewTest CrewTest { get; set; } = null!;
}
