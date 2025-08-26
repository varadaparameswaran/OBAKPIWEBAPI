using System;
using System.Collections.Generic;

namespace OBAKPIWEBAPI.EF_Models;

public partial class PreFlightCategory
{
    public int Id { get; set; }

    public string? Category { get; set; }

    public int? FleetId { get; set; }

    public virtual Fleet? Fleet { get; set; }

    public virtual ICollection<PreFlightTestQuestion> PreFlightTestQuestions { get; set; } = new List<PreFlightTestQuestion>();
}
