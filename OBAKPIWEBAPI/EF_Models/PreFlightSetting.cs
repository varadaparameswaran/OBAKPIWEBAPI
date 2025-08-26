using System;
using System.Collections.Generic;

namespace OBAKPIWEBAPI.EF_Models;

public partial class PreFlightSetting
{
    public int Id { get; set; }

    public int? NumOfMin { get; set; }

    public int? NumOfTry { get; set; }

    public string? EmailUsername { get; set; }

    public string? EmailSendFrom { get; set; }

    public string? EmailSendFromPassword { get; set; }

    public string? EmailSendTo { get; set; }

    public string? EmailSmtp { get; set; }

    public bool? ChangeQuestionIfWrong { get; set; }

    public int? NumOfQuestions { get; set; }

    public int? NumOfCorrect { get; set; }

    public string? PassPercentage { get; set; }
}
