using System;
using System.Collections.Generic;

namespace OBAKPIWEBAPI.EF_Models;

public partial class CrewGroomingRemark
{
    public int Id { get; set; }

    public string StaffNo { get; set; } = null!;

    public string Remarks { get; set; } = null!;

    public string? CreatedBy { get; set; }

    public DateTime CreatedDate { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }
}
