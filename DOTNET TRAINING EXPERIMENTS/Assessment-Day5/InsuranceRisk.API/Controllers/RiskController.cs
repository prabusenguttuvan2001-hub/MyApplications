using InsuranceRisk.API.DTOs;
using InsuranceRisk.Application.Interfaces;
using InsuranceRisk.Domain.Models;
using InsuranceRisk.Infrastructure.Logging;
using Microsoft.AspNetCore.Mvc;

namespace InsuranceRisk.API.Controllers
{
    [ApiController]
    [Route("risk")]
    public class RiskController : ControllerBase
    {
        private readonly IApplicantValidator _applicantValidator;
        private readonly IRiskService _riskService;
        private readonly ILoggerService _logger;

        public RiskController(
            IApplicantValidator applicantValidator,
            IRiskService riskService,
            ILoggerService logger)
        {
            _applicantValidator = applicantValidator;
            _riskService = riskService;
            _logger = logger;
        }

        [HttpPost("evaluate")]
        public IActionResult Evaluate(RiskRequest request)
        {
            try
            {
               
                _applicantValidator.Validate(request);

               
                EligibilityResult result = _riskService.Evaluate(request);

               
                RiskResponse response = new RiskResponse
                {
                    Eligible = result.IsEligible,
                    Score = result.Profile.Score,
                    Tier = result.Profile.Tier,
                    Message = result.Message
                };

                return Ok(response);
            }
            catch (Exception ex)
            {
               
                _logger.LogError("Error in risk evaluation: " + ex.Message);

                return BadRequest(new
                {
                    Error = ex.Message
                });
            }
        }

        [HttpGet("health")]
        public IActionResult Health()
        {
            return Ok("Risk API is running");
        }
    }
}
