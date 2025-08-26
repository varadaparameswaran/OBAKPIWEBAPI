using System;
using System.Collections.Generic;

namespace OBAKPIWEBAPI.EF_Models;

public partial class RosterDatum
{
    public int Id { get; set; }

    public string? Rostermonth { get; set; }

    public string? Rosteryear { get; set; }

    public string? HighSeniorityGroup { get; set; }

    public DateTime? RosterPubDate { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsDeleted { get; set; }
}
