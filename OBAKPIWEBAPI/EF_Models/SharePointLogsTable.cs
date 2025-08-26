using System;
using System.Collections.Generic;

namespace OBAKPIWEBAPI.EF_Models;

public partial class SharePointLogsTable
{
    public int Id { get; set; }

    public string? LogId { get; set; }

    public DateTime? CreationTime { get; set; }

    public string? Operation { get; set; }

    public string? StaffNumber { get; set; }

    public string? SourceUrl { get; set; }

    public string? FileName { get; set; }

    public virtual CrewDetail? StaffNumberNavigation { get; set; }
}
