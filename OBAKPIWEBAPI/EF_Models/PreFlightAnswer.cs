using System;
using System.Collections.Generic;

namespace OBAKPIWEBAPI.EF_Models;

public partial class PreFlightAnswer
{
    public int Id { get; set; }

    public int QuestionId { get; set; }

    public string AnswerText { get; set; } = null!;

    public bool Answer { get; set; }

    public virtual ICollection<PreFlightTestLog> PreFlightTestLogs { get; set; } = new List<PreFlightTestLog>();

    public virtual PreFlightTestQuestion Question { get; set; } = null!;
}
