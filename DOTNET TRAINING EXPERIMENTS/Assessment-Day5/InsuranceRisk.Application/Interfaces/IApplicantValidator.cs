using InsuranceRisk.API.DTOs;


namespace InsuranceRisk.Application.Interfaces
{
    public interface IApplicantValidator
    {
        void Validate(RiskRequest request);
    }
}
