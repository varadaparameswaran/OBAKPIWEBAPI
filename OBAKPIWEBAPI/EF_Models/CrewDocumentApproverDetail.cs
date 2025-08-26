using System;
using System.Collections.Generic;

namespace OBAKPIWEBAPI.EF_Models;

public partial class CrewDocumentApproverDetail
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? MailId { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsDeleted { get; set; }
}
