using System;
using System.Collections.Generic;

namespace OBAKPIWEBAPI.EF_Models;

public partial class FamForm
{
    public int Id { get; set; }

    public int FlightId { get; set; }

    public int CrewPosId { get; set; }

    public string? StaffNumber { get; set; }

    public string? Rating { get; set; }

    public string? LegalDocValidity { get; set; }

    public bool? PreFlightCheck { get; set; }

    public bool? PrePassengerBoardingCheck { get; set; }

    public bool? PassengerBoardingCheck { get; set; }

    public bool? ExitSeatsBriefingCheck { get; set; }

    public bool? PreTaxi { get; set; }

    public bool? DoorArming { get; set; }

    public bool? PreTakeOff { get; set; }

    public bool? LavatoryCruise { get; set; }

    public bool? Cruise { get; set; }

    public bool? Desent { get; set; }

    public bool? AfterLanding { get; set; }

    public bool? DoorDisarming { get; set; }

    public bool? DoorWarning { get; set; }

    public bool? DoorOpening { get; set; }

    public bool? TerminatingFlights { get; set; }

    public bool? DepartureFromAc { get; set; }

    public string? CSmComments { get; set; }

    public string? SNyComments { get; set; }

    public virtual OcbCrewPo CrewPos { get; set; } = null!;

    public virtual OcbFlight Flight { get; set; } = null!;
}
