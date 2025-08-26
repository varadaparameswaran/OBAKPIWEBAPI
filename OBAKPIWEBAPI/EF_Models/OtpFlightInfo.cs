using System;
using System.Collections.Generic;

namespace OBAKPIWEBAPI.EF_Models;

public partial class OtpFlightInfo
{
    public long SequenceNumber { get; set; }

    public DateOnly? FlightDate { get; set; }

    public string? FlightNumber { get; set; }

    public DateTime? ScheduledDepartureDateTime { get; set; }

    public DateTime? ScheduledArrivalDateTime { get; set; }

    public DateTime? ActualDepartureDateTime { get; set; }

    public DateTime? ActualArrivalDateTime { get; set; }

    public DateTime? PublishDepartureDateTime { get; set; }

    public DateTime? PublishArrivalDateTime { get; set; }

    public string? ActualDepartureAirport { get; set; }

    public string? ActualArrivalAirport { get; set; }

    public string? Status { get; set; }

    public string? CurrentStatus { get; set; }

    public int Id { get; set; }

    public int? LegSequenceNumber { get; set; }

    public virtual OtpPassengerDetail? OtpPassengerDetail { get; set; }
}
