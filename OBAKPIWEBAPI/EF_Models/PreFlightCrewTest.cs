using System;
using System.Collections.Generic;

namespace OBAKPIWEBAPI.EF_Models;

public partial class PreFlightCrewTest
{
    public int Id { get; set; }

    public int? CrewPosId { get; set; }

    public int? FlightId { get; set; }

    public DateTime? TestDateTime { get; set; }

    public bool? AllowSecondChance { get; set; }

    public bool? DidSecondChance { get; set; }

    public bool? IsFaildTest { get; set; }

    public virtual OcbCrewPo? CrewPos { get; set; }

    public virtual OcbFlight? Flight { get; set; }

    public virtual ICollection<PreFlightComment> PreFlightComments { get; set; } = new List<PreFlightComment>();

    public virtual ICollection<PreFlightFailedComment> PreFlightFailedComments { get; set; } = new List<PreFlightFailedComment>();

    public virtual ICollection<PreFlightTestLog> PreFlightTestLogs { get; set; } = new List<PreFlightTestLog>();
}
