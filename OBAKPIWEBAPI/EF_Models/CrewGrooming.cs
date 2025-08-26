using System;
using System.Collections.Generic;

namespace OBAKPIWEBAPI.EF_Models;

public partial class CrewGrooming
{
    public int Id { get; set; }

    public string? StaffNumber { get; set; }

    public int? HairColorCd { get; set; }

    public int? EyeColorCd { get; set; }

    public decimal? Height { get; set; }

    public decimal? MinimumWeight { get; set; }

    public decimal? MaximumWeight { get; set; }

    public int? WeightStatusId { get; set; }

    public decimal? Weight { get; set; }

    public DateTime? WeightEntryDate { get; set; }

    public string? Remarks { get; set; }

    public string? Status { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsDeleted { get; set; }

    public string? UpdatedBy { get; set; }

    public virtual CrewGroomingEyeColor? EyeColorCdNavigation { get; set; }

    public virtual CrewGroomingHairColor? HairColorCdNavigation { get; set; }

    public virtual PilotCrewDetail? StaffNumberNavigation { get; set; }

    public virtual CrewGroomingWeightStatus? WeightStatus { get; set; }
}
