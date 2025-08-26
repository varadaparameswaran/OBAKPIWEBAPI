using System;
using System.Collections.Generic;

namespace OBAKPIWEBAPI.EF_Models;

public partial class FlightFormSectionItem
{
    public int Id { get; set; }

    public int FlightFormSectionId { get; set; }

    public string ItemTitle { get; set; } = null!;

    public bool? IsDeleted { get; set; }

    public virtual ICollection<CrewFlightFormAnswer> CrewFlightFormAnswers { get; set; } = new List<CrewFlightFormAnswer>();

    public virtual FlightFormSection FlightFormSection { get; set; } = null!;
}
