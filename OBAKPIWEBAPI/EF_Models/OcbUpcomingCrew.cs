using System;
using System.Collections.Generic;

namespace OBAKPIWEBAPI.EF_Models;

public partial class OcbUpcomingCrew
{
    public int Id { get; set; }

    public int? FltNo { get; set; }

    public DateTime? FltDate { get; set; }

    public string? AircraftType { get; set; }

    public string? BaseStn { get; set; }

    public string? BlockName { get; set; }

    public string? StaffId { get; set; }

    public string? StaffFirstName { get; set; }

    public string? StaffLastName { get; set; }

    public string? StaffFullName { get; set; }

    public string? StaffShortName { get; set; }

    public string? StaffPos { get; set; }

    public string? StaffQualCat { get; set; }

    public string? StaffRequest { get; set; }

    public string? Pax { get; set; }

    public string? StaffNotified { get; set; }

    public string? FltOrgin { get; set; }

    public string? FltDest { get; set; }

    public string? RecUniqueId { get; set; }
}
