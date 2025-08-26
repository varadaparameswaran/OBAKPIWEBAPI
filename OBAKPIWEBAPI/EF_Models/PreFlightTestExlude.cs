using System;
using System.Collections.Generic;

namespace OBAKPIWEBAPI.EF_Models;

public partial class PreFlightTestExlude
{
    public int Id { get; set; }

    public int? CrewPosId { get; set; }

    public string? Comments { get; set; }

    public string? StaffNumber { get; set; }

    public DateTime? CommentDate { get; set; }

    public int? FlightId { get; set; }

    public virtual OcbCrewPo? CrewPos { get; set; }

    public virtual OcbFlight? Flight { get; set; }
}
