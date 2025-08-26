using System;
using System.Collections.Generic;

namespace OBAKPIWEBAPI.EF_Models;

public partial class CrewFlightForm
{
    public int Id { get; set; }

    public int FlightId { get; set; }

    public int FlightFormId { get; set; }

    public DateTime SubmitDateAndTime { get; set; }

    public string? StaffNumber { get; set; }

    public virtual ICollection<CrewFlightFormAnswer> CrewFlightFormAnswers { get; set; } = new List<CrewFlightFormAnswer>();

    public virtual ICollection<CrewFlightFormSectionComment> CrewFlightFormSectionComments { get; set; } = new List<CrewFlightFormSectionComment>();

    public virtual OcbFlight Flight { get; set; } = null!;

    public virtual FlightForm FlightForm { get; set; } = null!;
}
