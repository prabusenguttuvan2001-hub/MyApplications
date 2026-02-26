using InsuranceRisk.Domain.Models;

namespace InsuranceRisk.Application.Interfaces
{
    public interface IRiskCalculator
    {
        RiskProfile Calculate(Applicant applicant, Policy policy);
    }
}
