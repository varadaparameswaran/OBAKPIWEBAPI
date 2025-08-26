using System;
using System.Collections.Generic;

namespace OBAKPIWEBAPI.EF_Models;

public partial class CrewTransport
{
    public int Id { get; set; }

    public string? StaffNumber { get; set; }

    public int? ZoneId { get; set; }

    public int? BusId { get; set; }

    public string? Status { get; set; }

    public virtual Bus? Bus { get; set; }

    public virtual CrewDetail? StaffNumberNavigation { get; set; }

    public virtual Zone? Zone { get; set; }
}
