using System;
using System.Collections.Generic;

namespace OBAKPIWEBAPI.EF_Models;

public partial class DocCategory
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public string? FolderName { get; set; }
}
