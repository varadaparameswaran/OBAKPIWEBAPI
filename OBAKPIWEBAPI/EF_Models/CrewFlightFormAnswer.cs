using System;
using System.Collections.Generic;

namespace OBAKPIWEBAPI.EF_Models;

public partial class CrewFlightFormAnswer
{
    public int Id { get; set; }

    public int CrewFlightFormId { get; set; }

    public int FlightFormSectionItemId { get; set; }

    public string Answer { get; set; } = null!;

    public virtual CrewFlightForm CrewFlightForm { get; set; } = null!;

    public virtual FlightFormSectionItem FlightFormSectionItem { get; set; } = null!;
}
