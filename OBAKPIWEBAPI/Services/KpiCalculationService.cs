using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using OBAKPIWEBAPI.Data;
using OBAKPIWEBAPI.EF_Models;

namespace OBAKPIWEBAPI.Services
{
    public class KpiCalculationService : IKpiCalculationService
    {
        private readonly AppraisalDbContext _context;
        private readonly ILogger<KpiCalculationService> _logger;

        // KPI weightings and section mappings with role exclusions
        private static readonly Dictionary<string, (int Weight, string[] Sections, string[] ExcludedRoles)> KpiMappings =
            new Dictionary<string, (int, string[], string[])>
            {
                ["SafetyKpi"] = (15, new[] { "Safety and Security" }, Array.Empty<string>()),
                ["CorePerformanceKpi"] = (35, new[] {
                    "Pre Flight Briefing",
                    "Cleanliness",
                    "Job Knowledge & Technical Skills",
                    "Communication",
                    "Customer Service Excellence",
                    "Service"
                }, new[] { "FG" }), // FG excluded from some sections
                ["PressurePerformanceKpi"] = (15, new[] {
                    "Problem Solving",
                    "Teamwork & Resilience"
                }, new[] { "CSM", "CS" }),
                ["LeadershipKpi"] = (15, new[] {
                    "Leadership",
                    "People management"
                }, new[] { "FG", "FA" }),
                ["ImageKpi"] = (20, new[] { "Appearance & Uniform" }, Array.Empty<string>())
            };

        public KpiCalculationService(
            AppraisalDbContext context,
            ILogger<KpiCalculationService> logger)
        {
            _context = context;
            _logger = logger;
        }

        public async Task<List<KpiScoreResult>> CalculateKpisForDateRangeAsync(DateTime fromDate, DateTime toDate)
        {
            var results = new List<KpiScoreResult>();

            try
            {
                var appraisals = await _context.CrewAppraisals
                    .Include(ca => ca.CrewPos)
                    .Where(ca => ca.SubmittedDateTime != null &&
                                ca.SubmittedDateTime >= fromDate &&
                                ca.SubmittedDateTime <= toDate)
                    .ToListAsync();

                foreach (var appraisal in appraisals)
                {
                    try
                    {
                        var evaluations = await _context.CrewAppraisalEvals
                            .Include(e => e.Section)
                            .Include(e => e.Answer)
                            .Where(e => e.CrewAppraisalId == appraisal.Id)
                            .ToListAsync();

                        var crewRole = DetermineCrewRole(appraisal.CrewPos);
                        var kpiResult = CalculateKpiScores(evaluations, crewRole);

                        kpiResult.StaffNumber = appraisal.CrewPos?.StaffNumber ?? string.Empty;
                        kpiResult.CrewPosId = appraisal.CrewPosId;
                        kpiResult.EvaluationDate = appraisal.SubmittedDateTime.Value;

                        results.Add(kpiResult);
                    }
                    catch (Exception ex)
                    {
                        _logger.LogError(ex, $"Error processing appraisal for CrewPosId: {appraisal.CrewPosId}");
                        results.Add(CreateDefaultResult(appraisal));
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving appraisals");
            }

            return results;
        }

        /* private KpiScoreResult CalculateKpiScores(List<CrewAppraisalEval> evaluations, string crewRole)
         {
             var result = new KpiScoreResult();

             foreach (var kpi in KpiMappings)
             {
                 var property = typeof(KpiScoreResult).GetProperty(kpi.Key);

                 // Skip if role is excluded from this KPI
                 if (kpi.Value.ExcludedRoles.Contains(crewRole))
                 {
                     property.SetValue(result, 0m);
                     continue;
                 }

                 // Filter sections and handle FG-specific exclusions for Core KPI
                 var applicableSections = kpi.Value.Sections;
                 if (crewRole == "FG" && kpi.Key == "CorePerformanceKpi")
                 {
                     applicableSections = kpi.Value.Sections
                         .Except(new[] { "Pre Flight Briefing", "Service" })
                         .ToArray();
                 }

                 decimal score = evaluations
                     .Where(e => applicableSections.Contains(e.Section?.Title))
                     .Select(e => e.Answer?.Score ?? 3m)
                     .DefaultIfEmpty(3m)
                     .Average();

                 property.SetValue(result, ConvertTo5PointScale(score));
             }

             // Calculate weighted total (100% distribution)
             decimal totalScore = KpiMappings.Sum(kpi =>
                 (decimal)kpi.Value.Weight / 100 *
                 (decimal)typeof(KpiScoreResult).GetProperty(kpi.Key).GetValue(result));

             result.TotalKpiScore = Math.Round(totalScore, 1);
             return result;
         }*/

        private decimal ConvertTo5PointScale(decimal originalScore)
        {
            if (originalScore > 4) return originalScore;
            return Math.Round(1m + ((originalScore - 1m) / 3m * 4m), 1);
        }

        private string DetermineCrewRole(OcbCrewPo crewPos)
        {
            if (crewPos == null) return "FA";
            string normalizedRole = (crewPos.Category ?? "").Trim()
                .ToUpper()
                .Replace(" ", "")
                .Replace("-", "");

            return normalizedRole switch
            {
                var r when r.Contains("CSM") || r.Contains("MANAGER") => "CSM",
                var r when r.Contains("CS") || r.Contains("SENIOR") => "CS",
                var r when r.Contains("FG") || r.Contains("GOLD") => "FG",
                _ => "FA"
            };
        }

        private KpiScoreResult CreateDefaultResult(CrewAppraisal appraisal)
        {
            return new KpiScoreResult
            {
                StaffNumber = appraisal.CrewPos?.StaffNumber ?? string.Empty,
                CrewPosId = appraisal.CrewPosId,
                EvaluationDate = appraisal.SubmittedDateTime.Value,
                SafetyKpi = 3.0m,
                CorePerformanceKpi = 3.0m,
                PressurePerformanceKpi = 0.0m,
                LeadershipKpi = 0.0m,
                ImageKpi = 3.0m,
                TotalKpiScore = 3.0m
            };
        }

        public bool TestDatabaseConnection()
        {
            try
            {
                return _context.Database.CanConnect();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Database connection test failed");
                return false;
            }
        }

        private KpiScoreResult CalculateKpiScores(List<CrewAppraisalEval> evaluations, string crewRole)
        {
            var result = new KpiScoreResult();

            // Safety KPI (always calculated)
            result.SafetyKpi = CalculateSectionScore(evaluations, "Safety and Security");

            // Core Performance KPI (special handling)
            if (crewRole == "FG")
            {
                // FG gets partial core sections (exclude Pre-Flight and Service)
                var coreSections = new[] {
            "Cleanliness",
            "Job Knowledge & Technical Skills",
            "Communication",
            "Customer Service Excellence"
        };
                result.CorePerformanceKpi = CalculateSectionScore(evaluations, coreSections);
            }
            else
            {
                // All other roles get full core sections
                result.CorePerformanceKpi = CalculateSectionScore(evaluations, new[] {
            "Pre Flight Briefing",
            "Cleanliness",
            "Job Knowledge & Technical Skills",
            "Communication",
            "Customer Service Excellence",
            "Service"
        });
            }

            // Role-specific KPIs
            result.PressurePerformanceKpi = (crewRole == "CS" || crewRole == "CSM")
                ? 0m
                : CalculateSectionScore(evaluations, new[] { "Problem Solving", "Teamwork & Resilience" });

            result.LeadershipKpi = (crewRole == "FG" || crewRole == "FA")
                ? 0m
                : CalculateSectionScore(evaluations, new[] { "Leadership", "People management" });

            // Image KPI (always calculated)
            result.ImageKpi = CalculateSectionScore(evaluations, "Appearance & Uniform");

            // Calculate weighted total
            result.TotalKpiScore = CalculateWeightedTotal(result, crewRole);

            return result;
        }

        private decimal CalculateSectionScore(List<CrewAppraisalEval> evaluations, params string[] sectionTitles)
        {
            var scores = evaluations
                .Where(e => sectionTitles.Contains(e.Section?.Title))
                .Select(e => e.Answer?.Score ?? 3m)
                .DefaultIfEmpty(3m)
                .ToList();

            return ConvertTo5PointScale(scores.Average());
        }

        private decimal CalculateWeightedTotal(KpiScoreResult result, string crewRole)
        {
            // Base weights (total 85% - missing 15% from excluded KPIs)
            var baseWeights = new Dictionary<string, decimal>
            {
                ["SafetyKpi"] = 0.15m,
                ["CorePerformanceKpi"] = 0.35m,
                ["ImageKpi"] = 0.20m,
                ["LeadershipKpi"] = (crewRole == "CS" || crewRole == "CSM") ? 0.15m : 0m,
                ["PressurePerformanceKpi"] = (crewRole == "FG" || crewRole == "FA") ? 0.15m : 0m
            };

            // Calculate actual total weight (will be less than 100% when KPIs are excluded)
            decimal totalAssignedWeight = baseWeights.Values.Sum();

            // Redistribute weights proportionally to reach 100%
            var adjustedWeights = baseWeights.ToDictionary(
                w => w.Key,
                w => w.Value / totalAssignedWeight  // Normalize to 100%
            );

            // Calculate final score with proper weight distribution
            decimal totalScore =
                result.SafetyKpi * adjustedWeights["SafetyKpi"] +
                result.CorePerformanceKpi * adjustedWeights["CorePerformanceKpi"] +
                result.ImageKpi * adjustedWeights["ImageKpi"] +
                result.LeadershipKpi * adjustedWeights["LeadershipKpi"] +
                result.PressurePerformanceKpi * adjustedWeights["PressurePerformanceKpi"];

            return Math.Round(totalScore, 1);
        }

        public async Task<KpiScoreResult> CalculateKpiByStaffNumberAsync(string staffNumber)
        {
            try
            {
                // Step 1: Get all crew positions for this staff number
                var crewPositions = await _context.OcbCrewPos
                    .Where(cp => cp.StaffNumber == staffNumber)
                    .ToListAsync();

                if (!crewPositions.Any())
                {
                    _logger.LogWarning("Staff number {StaffNumber} not found", staffNumber);
                    return CreateDefaultResult(staffNumber);
                }

                // Step 2: For each position, get the most recent appraisal with evaluations
                var results = new List<KpiScoreResult>();

                foreach (var crewPos in crewPositions)
                {
                    // Get the most recent appraisal
                    var appraisal = await _context.CrewAppraisals
                        .Where(a => a.CrewPosId == crewPos.Id)
                        .OrderByDescending(a => a.SubmittedDateTime)
                        .FirstOrDefaultAsync();

                    if (appraisal == null)
                    {
                        _logger.LogWarning("No appraisal found for position {CrewPosId}", crewPos.Id);
                        continue;
                    }

                    // Get evaluations separately (like in CalculateKpisForDateRangeAsync)
                    var evaluations = await _context.CrewAppraisalEvals
                        .Include(e => e.Section)
                        .Include(e => e.Answer)
                        .Where(e => e.CrewAppraisalId == appraisal.Id)
                        .ToListAsync();

                    if (evaluations == null || !evaluations.Any())
                    {
                        _logger.LogWarning("No evaluations found for appraisal {AppraisalId}", appraisal.Id);
                        continue;
                    }

                    // Calculate KPIs
                    var crewRole = DetermineCrewRole(crewPos);
                    var kpiResult = CalculateKpiScores(evaluations, crewRole);

                    kpiResult.StaffNumber = staffNumber;
                    kpiResult.CrewPosId = crewPos.Id;
                    kpiResult.EvaluationDate = appraisal.SubmittedDateTime ?? DateTime.UtcNow;

                    results.Add(kpiResult);
                }

                // Step 3: Return the most recent result or default if none found
                var finalResult = results
                    .OrderByDescending(r => r.EvaluationDate)
                    .FirstOrDefault();

                if (finalResult == null)
                {
                    _logger.LogWarning("No valid appraisals found for staff {StaffNumber}", staffNumber);
                    return CreateDefaultResult(staffNumber, crewPositions.First().Id);
                }

                _logger.LogInformation("Returning KPIs for staff {StaffNumber}, position {CrewPosId}",
                    staffNumber, finalResult.CrewPosId);
                return finalResult;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error calculating KPI for staff {StaffNumber}", staffNumber);
                return CreateDefaultResult(staffNumber);
            }
        }



        private KpiScoreResult CreateDefaultResult(string staffNumber, int? crewPosId = null)
        {
            return new KpiScoreResult
            {
                StaffNumber = staffNumber,
                CrewPosId = crewPosId,
                EvaluationDate = DateTime.UtcNow,
                SafetyKpi = 0m,
                CorePerformanceKpi = 0m,
                PressurePerformanceKpi = 0m,
                LeadershipKpi = 0m,
                ImageKpi = 0m,
                TotalKpiScore = 0m
            };
        }
    }



    public interface IKpiCalculationService
    {
        Task<List<KpiScoreResult>> CalculateKpisForDateRangeAsync(DateTime fromDate, DateTime toDate);

        Task<KpiScoreResult> CalculateKpiByStaffNumberAsync(string staffNumber);
        bool TestDatabaseConnection();
    }


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
