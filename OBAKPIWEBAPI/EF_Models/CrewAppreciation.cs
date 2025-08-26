using System;
using System.Collections.Generic;

namespace OBAKPIWEBAPI.EF_Models;

public partial class CrewAppreciation
{
    public int Id { get; set; }

    public string? StaffNumber { get; set; }

    public string? StaffName { get; set; }

    public DateTime? AppEntryDate { get; set; }

    public string? AppEntrySubject { get; set; }

    public string? AppEntryDesc { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsDeleted { get; set; }

    public string? UpdatedBy { get; set; }

    public string? AttachmentPath { get; set; }
}
