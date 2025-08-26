using System;
using System.Collections.Generic;

namespace OBAKPIWEBAPI.EF_Models;

public partial class LayoverPairing
{
    public int Id { get; set; }

    public int? PairCatId { get; set; }

    public int? FleetId { get; set; }

    public string? Pairing { get; set; }

    public DateTime? OperationDate { get; set; }

    public DateTime? NextOperation { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsDeleted { get; set; }

    public virtual FleetCategory? Fleet { get; set; }

    public virtual PairingCategory? PairCat { get; set; }
}
