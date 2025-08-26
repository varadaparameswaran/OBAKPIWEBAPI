using System;
using System.Collections.Generic;

namespace OBAKPIWEBAPI.EF_Models;

public partial class PreBookedMeal
{
    public int Id { get; set; }

    public string? Class { get; set; }

    public string? MealType { get; set; }

    public string? PassengerName { get; set; }

    public string? Equipment { get; set; }

    public string? Departure { get; set; }

    public string? Arrival { get; set; }

    public string? AircraftType { get; set; }

    public string? Remarks { get; set; }

    public string? FltSeqNr { get; set; }

    public bool? IsDeleted { get; set; }

    public DateTime? LastUpdate { get; set; }

    public string? Guid { get; set; }

    public int? FlightId { get; set; }

    public virtual OcbFlight? Flight { get; set; }
}
