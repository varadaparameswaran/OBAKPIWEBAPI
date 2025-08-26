using System;
using System.Collections.Generic;

namespace OBAKPIWEBAPI.EF_Models;

public partial class FlightFormSection
{
    public int Id { get; set; }

    public int FlightFormId { get; set; }

    public string SectionTitle { get; set; } = null!;

    public bool? IsDeleted { get; set; }

    public virtual ICollection<CrewFlightFormSectionComment> CrewFlightFormSectionComments { get; set; } = new List<CrewFlightFormSectionComment>();

    public virtual FlightForm FlightForm { get; set; } = null!;

    public virtual ICollection<FlightFormSectionItem> FlightFormSectionItems { get; set; } = new List<FlightFormSectionItem>();
}
