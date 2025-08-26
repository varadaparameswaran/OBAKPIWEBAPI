using System;
using System.Collections.Generic;

namespace OBAKPIWEBAPI.EF_Models;

public partial class CrewTransportRequest
{
    public int Id { get; set; }

    public DateTime? Date { get; set; }

    public DateTime? Time { get; set; }

    public int? TransportType { get; set; }

    public string? FromAddress { get; set; }

    public string? ToAddress { get; set; }

    public string? FlightDetails { get; set; }

    public DateTime? FlightDateTime { get; set; }

    public string? StaffNumber { get; set; }

    public bool? IsDeleted { get; set; }

    public string? Status { get; set; }

    public virtual PilotCrewDetail? StaffNumberNavigation { get; set; }

    public virtual CrewTransportCategory? TransportTypeNavigation { get; set; }
}
