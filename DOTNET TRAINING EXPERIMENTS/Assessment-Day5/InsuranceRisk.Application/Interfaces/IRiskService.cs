using InsuranceRisk.API.DTOs;
using InsuranceRisk.Domain.Models;

namespace InsuranceRisk.Application.Interfaces
{
    public interface IRiskService
    {
        EligibilityResult Evaluate(RiskRequest request);
    }
}
