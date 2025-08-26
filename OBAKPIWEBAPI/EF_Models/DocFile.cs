using System;
using System.Collections.Generic;

namespace OBAKPIWEBAPI.EF_Models;

public partial class DocFile
{
    public int Id { get; set; }

    public int? CategoryId { get; set; }

    public string? Title { get; set; }

    public string? DocUrl { get; set; }

    public string? Version { get; set; }

    public bool? IsActive { get; set; }
}
