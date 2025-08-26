using System;
using System.Collections.Generic;

namespace OBAKPIWEBAPI.EF_Models;

public partial class WeightVarianceSetting
{
    public int Id { get; set; }

    public decimal VariancePercentage { get; set; }

    public string? Description { get; set; }

    public bool? Isactive { get; set; }

    public bool? Isdeleted { get; set; }

    public DateTime? CreatedAt { get; set; }

    public string? CreatedBy { get; set; }

    public virtual ICollection<WeightMinMaxSetting> WeightMinMaxSettings { get; set; } = new List<WeightMinMaxSetting>();
}
