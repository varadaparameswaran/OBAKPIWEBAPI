using System;
using System.Collections.Generic;

namespace OBAKPIWEBAPI.EF_Models;

public partial class CrewAppraisal
{
    public int Id { get; set; }

    public int? CrewPosId { get; set; }

    public string? AppraiserStaffNumber { get; set; }

    public int? AppraisalId { get; set; }

    public DateTime? SubmittedDateTime { get; set; }

    public int? BlockId { get; set; }

    public string? CrewComment { get; set; }

    public string? AppraiserSignatureUrl { get; set; }

    public string? AppraiseeSignatureUrl { get; set; }

    public virtual Appraisal? Appraisal { get; set; }

    public virtual OcbCrewPo? CrewPos { get; set; }
}
