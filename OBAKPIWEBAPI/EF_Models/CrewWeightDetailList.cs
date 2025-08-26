using System;
using System.Collections.Generic;

namespace OBAKPIWEBAPI.EF_Models;

public partial class CrewWeightDetailList
{
    public int Id { get; set; }

    public string? EmployeeNumber { get; set; }

    public string? EmployeeName { get; set; }

    public DateTime? DateFrom { get; set; }

    public DateTime? DateTo { get; set; }

    public DateTime? DateWeight { get; set; }

    public decimal? Weight { get; set; }

    public int? WeightStatusId { get; set; }

    public decimal? GainLoss { get; set; }

    public string? Remarks { get; set; }

    public string? UpdatedBy { get; set; }

    public bool? IsDeleted { get; set; }

    public virtual CrewGroomingWeightStatus? WeightStatus { get; set; }
}
