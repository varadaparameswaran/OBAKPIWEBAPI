using System;
using System.Collections.Generic;

namespace OBAKPIWEBAPI.EF_Models;

public partial class OcbBlock
{
    public int Id { get; set; }

    public string? BlockNo { get; set; }

    public int? DaysNo { get; set; }

    public DateTime? BlockDate { get; set; }

    public DateTime? EndDate { get; set; }

    public DateTime? StartTime { get; set; }

    public DateTime? EndTime { get; set; }

    public string? Eqp { get; set; }

    public bool? IsDeleted { get; set; }

    public DateTime? LastUpdate { get; set; }

    public string? Guid { get; set; }

    public bool? Delay { get; set; }

    public bool? ManualEdit { get; set; }

    public virtual ICollection<OcbCrewPo> OcbCrewPos { get; set; } = new List<OcbCrewPo>();

    public virtual ICollection<OcbFlight> OcbFlights { get; set; } = new List<OcbFlight>();
}
