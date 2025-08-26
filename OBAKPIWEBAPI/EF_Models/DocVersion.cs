using System;
using System.Collections.Generic;

namespace OBAKPIWEBAPI.EF_Models;

public partial class DocVersion
{
    public int Id { get; set; }

    public DateTime? RevFlightCrew { get; set; }

    public DateTime? DueDate { get; set; }
}
