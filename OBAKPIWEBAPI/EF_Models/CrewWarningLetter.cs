using System;
using System.Collections.Generic;

namespace OBAKPIWEBAPI.EF_Models;

public partial class CrewWarningLetter
{
    public int Id { get; set; }

    public string? StaffNumber { get; set; }

    public DateTime? WarnEntryDate { get; set; }

    public string? WarnEntrySubject { get; set; }

    public string? WarnEntryDesc { get; set; }

    public string? WarnEntryType { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsDeleted { get; set; }

    public string? ReportedBy { get; set; }

    public string? UpdatedBy { get; set; }

    public string? AttachmentPath { get; set; }

    public string? StaffName { get; set; }
}
