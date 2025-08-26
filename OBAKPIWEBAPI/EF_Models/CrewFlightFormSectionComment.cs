using System;
using System.Collections.Generic;

namespace OBAKPIWEBAPI.EF_Models;

public partial class CrewFlightFormSectionComment
{
    public int Id { get; set; }

    public int? CrewFlightFormId { get; set; }

    public int? FlightFormSectionId { get; set; }

    public string? Comments { get; set; }

    public virtual CrewFlightForm? CrewFlightForm { get; set; }

    public virtual FlightFormSection? FlightFormSection { get; set; }
}
