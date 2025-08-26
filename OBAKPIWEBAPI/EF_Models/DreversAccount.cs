using System;
using System.Collections.Generic;

namespace OBAKPIWEBAPI.EF_Models;

public partial class DreversAccount
{
    public int Id { get; set; }

    public string? Username { get; set; }

    public string? Password { get; set; }

    public string? FullName { get; set; }

    public bool? IsActive { get; set; }

    public string? Salt { get; set; }

    public virtual BusesDriver? BusesDriver { get; set; }
}
