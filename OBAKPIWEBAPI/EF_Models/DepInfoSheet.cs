using System;
using System.Collections.Generic;

namespace OBAKPIWEBAPI.EF_Models;

public partial class DepInfoSheet
{
    public int Id { get; set; }

    public int FlightId { get; set; }

    public int? BookedLoadJ { get; set; }

    public int? BookedLoadY { get; set; }

    public int? FinalLoadJ { get; set; }

    public int? FinalLoadY { get; set; }

    public int? CateredLoadJ { get; set; }

    public int? CateredLoadY { get; set; }

    public DateTime? FDBoardDateTime { get; set; }

    public string? FDBoardRemarks { get; set; }

    public DateTime? CCrewBoardedDateTime { get; set; }

    public string? CCrewBoardedRemarks { get; set; }

    public DateTime? CleanersOnDateTime { get; set; }

    public DateTime? CleanersOffDateTime { get; set; }

    public string? CleanersRemarks { get; set; }

    public DateTime? CatererOnDateTime { get; set; }

    public DateTime? CatererOffDateTime { get; set; }

    public string? CatererRemarks { get; set; }

    public DateTime? BoardingDateTime { get; set; }

    public string? BoardingRemarks { get; set; }

    public DateTime? FirstPassengerBoardedDateTime { get; set; }

    public string? FirstPassengerBoardedRemarks { get; set; }

    public DateTime? LastPassengerBoardedDateTime { get; set; }

    public string? LastPassengerBoardedRemarks { get; set; }

    public DateTime? DoorsClosedDateTime { get; set; }

    public string? DoorsClosedRemarks { get; set; }

    public bool? LandingCardsProvided { get; set; }

    public string? LandingCardsProvidedRemarks { get; set; }

    public bool? ShipsPapersOnBoard { get; set; }

    public string? ShipsPapersOnBoardRemarks { get; set; }

    public bool? VipCip { get; set; }

    public string? VipCipRemarks { get; set; }

    public bool? CabinBaggageLabeled { get; set; }

    public string? CabinBaggageLabeledRemarks { get; set; }

    public bool? CabinBaggageCompliant { get; set; }

    public string? CabinBaggageCompliantRemarks { get; set; }

    public bool? SpecialAssistance { get; set; }

    public string? SpecialAssistanceRemarks { get; set; }

    public bool? GenDec { get; set; }

    public string? GenDecRemarks { get; set; }

    public bool? PilProvided { get; set; }

    public string? PilProvidedRemarks { get; set; }

    public int? Wchc { get; set; }

    public int? Wchs { get; set; }

    public int? Wchr { get; set; }

    public int? Maas { get; set; }

    public int? Blnd { get; set; }

    public int? Deaf { get; set; }

    public int? Stcr { get; set; }

    public int? Inad { get; set; }

    public int? Depu { get; set; }

    public int? Depa { get; set; }

    public int? Meda { get; set; }

    public int? Umnr { get; set; }

    public int? Other { get; set; }

    public string? AdditionalComments { get; set; }

    public string? GroundStaffnum { get; set; }

    public string? GroundStaffname { get; set; }

    public string? GroundStaffcomments { get; set; }

    public string? CsmSign { get; set; }

    public string? GroundStaffsign { get; set; }

    public string? GsimageUrl { get; set; }

    public virtual OcbFlight Flight { get; set; } = null!;
}
