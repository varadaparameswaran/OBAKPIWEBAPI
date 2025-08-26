using System;
using System.Collections.Generic;

namespace OBAKPIWEBAPI.EF_Models;

public partial class WeightMinMaxSetting
{
    public int Id { get; set; }

    public decimal? MinWeight { get; set; }

    public decimal? MaxWeight { get; set; }

    public decimal? Height { get; set; }

    public string? Gender { get; set; }

    public bool? Isactive { get; set; }

    public bool? Isdeleted { get; set; }

    public string? Description { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? ModifiedAt { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public int? VarianceSettingsId { get; set; }

    public virtual WeightVarianceSetting? VarianceSettings { get; set; }
}
