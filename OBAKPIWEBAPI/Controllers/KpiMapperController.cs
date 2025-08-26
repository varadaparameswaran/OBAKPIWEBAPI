using Microsoft.AspNetCore.Mvc;
using OBAKPIWEBAPI.DTOs;
using OBAKPIWEBAPI.Services;
using System;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using KpiScoreResult = OBAKPIWEBAPI.Services.KpiScoreResult;

namespace OBAKPIWEBAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class KpiMapperController : ControllerBase
    {
        private readonly IKpiCalculationService _kpiService;
        private readonly ILogger<KpiMapperController> _logger;

        public KpiMapperController(
            IKpiCalculationService kpiService,
            ILogger<KpiMapperController> logger)
        {
            _kpiService = kpiService;
            _logger = logger;
        }

        [HttpPost("CalculateKpis")]
        public async Task<ActionResult<IEnumerable<KpiScoreResult>>> CalculateKpis(
            [FromBody][Required] DateRangeRequest request)
        {
            if (!ModelState.IsValid)
            {
                _logger.LogWarning("Invalid request data: {@ModelState}", ModelState);
                return BadRequest(ModelState);
            }

            try
            {
                var (fromDate, toDate) = request;

                _logger.LogInformation(
                    "Calculating KPIs from {FromDate:yyyy-MM-dd HH:mm:ss} to {ToDate:yyyy-MM-dd HH:mm:ss}",
                    fromDate, toDate);

                var results = await _kpiService.CalculateKpisForDateRangeAsync(fromDate, toDate);

                return Ok(results);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error calculating KPIs for {@Request}", request);
                return StatusCode(500, new
                {
                    Error = "An error occurred while processing your request",
                    Details = ex.Message
                });
            }
        }

        [HttpGet("TestConnection")]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult TestConnection()
        {
            try
            {
                bool isConnected = _kpiService.TestDatabaseConnection();
                return Ok(new
                {
                    Status = isConnected ? "Connected" : "Disconnected",
                    Timestamp = DateTime.UtcNow
                });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Database connection test failed");
                return StatusCode(500, new
                {
                    Error = "Database connection test failed",
                    Details = ex.Message
                });
            }
        }

        [HttpGet("ByStaffNumber/{staffNumber}")]
        [ProducesResponseType(typeof(KpiScoreResult), 200)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> GetKpiByStaffNumber(
         [FromRoute][Required] string staffNumber)
        {
            try
            {
                var result = await _kpiService.CalculateKpiByStaffNumberAsync(staffNumber);

                if (result == null || string.IsNullOrEmpty(result.StaffNumber))
                {
                    return NotFound(new ProblemDetails
                    {
                        Title = "Staff Not Found",
                        Detail = $"No records found for staff number {staffNumber}",
                        Instance = HttpContext.Request.Path
                    });
                }

                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error calculating KPI for staff {StaffNumber}", staffNumber);
                return StatusCode(500, Problem(
                    title: "Staff KPI Calculation Error",
                    detail: ex.Message,
                    instance: HttpContext.Request.Path
                ));
            }
        }
    }
}