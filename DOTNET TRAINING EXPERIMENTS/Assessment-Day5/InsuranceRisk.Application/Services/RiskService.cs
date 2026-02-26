using InsuranceRisk.API.DTOs;
using InsuranceRisk.Application.Interfaces;
using InsuranceRisk.Application.Risk;
using InsuranceRisk.Domain.Enums;
using InsuranceRisk.Domain.Models;
using InsuranceRisk.Infrastructure.Logging;
using System;

namespace InsuranceRisk.Application.Services
{
    public class RiskService : IRiskService
    {
        private readonly ILoggerService _logger;

        public RiskService(ILoggerService logger)
        {
            _logger = logger;
        }

        public EligibilityResult Evaluate(RiskRequest request)
        {
            try
            {
                _logger.LogInfo("Risk evaluation started");

                ClaimHistory history = new ClaimHistory(request.Incidents);

                Applicant applicant = new Applicant(
                    request.Age,
                    request.Experience,
                    history
                );

                Policy policy = new Policy(request.PolicyType);

                IRiskCalculator calculator =
                    RiskCalculatorFactory.GetCalculator(policy.Type);

                RiskProfile profile =
                    calculator.Calculate(applicant, policy);

                bool eligible;

                if (profile.Tier == RiskTier.High)
                {
                    eligible = false;
                }
                else
                {
                    eligible = true;
                }

                string message;

                if (eligible)
                {
                    message = "Applicant approved";
                }
                else
                {
                    message = "Applicant rejected due to high risk";
                }

                _logger.LogInfo("Risk evaluation completed");

                return new EligibilityResult(eligible, profile, message);
            }
            catch (Exception ex)
            {
                _logger.LogError("Error in RiskService: " + ex.Message);
                throw;
            }
        }
    }
}
