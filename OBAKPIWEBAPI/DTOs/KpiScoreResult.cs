using System;

namespace OBAKPIWEBAPI.DTOs
{
    public class KpiScoreResult
    {
        public string StaffNumber { get; set; }
        public int? CrewPosId { get; set; }
        public decimal SafetyKpi { get; set; }
        public decimal CorePerformanceKpi { get; set; }
        public decimal PressurePerformanceKpi { get; set; }
        public decimal LeadershipKpi { get; set; }
        public decimal ImageKpi { get; set; }
        public decimal TotalKpiScore { get; set; }
        public DateTime EvaluationDate { get; set; }
    }
}
