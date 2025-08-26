using System;
using System.Collections.Generic;

namespace OBAKPIWEBAPI.EF_Models;

public partial class PreFlightTestQuestion
{
    public int Id { get; set; }

    public int? CategoryId { get; set; }

    public string? Question { get; set; }

    public bool? Active { get; set; }

    public virtual PreFlightCategory? Category { get; set; }

    public virtual ICollection<PreFlightAnswer> PreFlightAnswers { get; set; } = new List<PreFlightAnswer>();
}
