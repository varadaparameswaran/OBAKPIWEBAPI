using System;
using System.Collections.Generic;

namespace OBAKPIWEBAPI.EF_Models;

public partial class CrewCommendation
{
    public int Id { get; set; }

    public string? StaffNumber { get; set; }

    public string? StaffName { get; set; }

    public DateTime? CommEntryDate { get; set; }

    public string? CommEntrySubject { get; set; }

    public string? CommEntryDesc { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsDeleted { get; set; }

    public string? UpdatedBy { get; set; }

    public string? AttachmentPath { get; set; }
}
