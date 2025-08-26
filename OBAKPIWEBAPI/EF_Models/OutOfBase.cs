using System;
using System.Collections.Generic;

namespace OBAKPIWEBAPI.EF_Models;

public partial class OutOfBase
{
    public int Id { get; set; }

    public string? StaffNumber { get; set; }

    public DateTime? DateFrom { get; set; }

    public DateTime? DateTo { get; set; }

    public string? Comments { get; set; }

    public virtual CrewDetail? StaffNumberNavigation { get; set; }
}
