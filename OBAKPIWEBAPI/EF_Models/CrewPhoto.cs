using System;
using System.Collections.Generic;

namespace OBAKPIWEBAPI.EF_Models;

public partial class CrewPhoto
{
    public int Id { get; set; }

    public string? StaffNumber { get; set; }

    public string? AttachmentPath { get; set; }
}
