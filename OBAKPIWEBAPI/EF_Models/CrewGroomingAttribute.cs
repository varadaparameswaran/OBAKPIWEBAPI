using System;
using System.Collections.Generic;

namespace OBAKPIWEBAPI.EF_Models;

public partial class CrewGroomingAttribute
{
    public int Id { get; set; }

    public string? EmployeeNumber { get; set; }

    public string? EmployeeName { get; set; }

    public string? HairColor { get; set; }

    public string? EyeColor { get; set; }

    public decimal? Height { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public int? HairColorCd { get; set; }

    public int? EyeColorCd { get; set; }

    public string? Gender { get; set; }

    public string? Nationality { get; set; }
}
