using System;
using System.Collections.Generic;

namespace OBAKPIWEBAPI.EF_Models;

public partial class OcbFlight
{
    public int Id { get; set; }

    public string? FltNo { get; set; }

    public DateTime? FlightDate { get; set; }

    public string? Orig { get; set; }

    public string? Dest { get; set; }

    public string? ReqLimit { get; set; }

    public bool? IsDeleted { get; set; }

    public DateTime? LastUpdate { get; set; }

    public string? Guid { get; set; }

    public int? BlockId { get; set; }

    public string? Eqp { get; set; }

    public virtual OcbBlock? Block { get; set; }

    public virtual ICollection<CrewFlightForm> CrewFlightForms { get; set; } = new List<CrewFlightForm>();

    public virtual ICollection<DepInfoSheet> DepInfoSheets { get; set; } = new List<DepInfoSheet>();

    public virtual ICollection<FamForm> FamForms { get; set; } = new List<FamForm>();

    public virtual ICollection<FlightMeal> FlightMeals { get; set; } = new List<FlightMeal>();

    public virtual ICollection<MealsCount> MealsCounts { get; set; } = new List<MealsCount>();

    public virtual ICollection<OcbAllocationScreen> OcbAllocationScreens { get; set; } = new List<OcbAllocationScreen>();

    public virtual ICollection<OcbNotification> OcbNotifications { get; set; } = new List<OcbNotification>();

    public virtual ICollection<PotableWater> PotableWaters { get; set; } = new List<PotableWater>();

    public virtual ICollection<PreBookedMeal> PreBookedMeals { get; set; } = new List<PreBookedMeal>();

    public virtual ICollection<PreFlightCrewTest> PreFlightCrewTests { get; set; } = new List<PreFlightCrewTest>();

    public virtual ICollection<PreFlightTestExlude> PreFlightTestExludes { get; set; } = new List<PreFlightTestExlude>();

    public virtual ICollection<SpecialMeal> SpecialMeals { get; set; } = new List<SpecialMeal>();

    public virtual ICollection<SsrCount> SsrCounts { get; set; } = new List<SsrCount>();

    public virtual ICollection<Ssr> Ssrs { get; set; } = new List<Ssr>();
}
