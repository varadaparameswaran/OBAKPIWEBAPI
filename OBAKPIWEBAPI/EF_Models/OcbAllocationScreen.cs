using System;
using System.Collections.Generic;

namespace OBAKPIWEBAPI.EF_Models;

public partial class OcbAllocationScreen
{
    public int Id { get; set; }

    public int? FlightId { get; set; }

    public string? RoomNumber { get; set; }

    public string? Status { get; set; }

    public string? Duty { get; set; }

    public virtual OcbFlight? Flight { get; set; }
}
