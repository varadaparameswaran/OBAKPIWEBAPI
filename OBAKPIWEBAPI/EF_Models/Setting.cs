using System;
using System.Collections.Generic;

namespace OBAKPIWEBAPI.EF_Models;

public partial class Setting
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public string? Value { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDt { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsDeleted { get; set; }

    public string? TitleTextVal { get; set; }
}
