using System;
using System.Collections.Generic;

namespace OBAKPIWEBAPI.EF_Models;

public partial class FlightForm
{
    public int Id { get; set; }

    public string FormName { get; set; } = null!;

    public virtual ICollection<CrewFlightForm> CrewFlightForms { get; set; } = new List<CrewFlightForm>();

    public virtual ICollection<FlightFormSection> FlightFormSections { get; set; } = new List<FlightFormSection>();
}
