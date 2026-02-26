using InsuranceRisk.Application.Interfaces;
using InsuranceRisk.Domain.Enums;
using InsuranceRisk.Domain.Models;

namespace InsuranceRisk.Application.Risk
{
    public class CarRiskCalculator : IRiskCalculator
    {
        public RiskProfile Calculate(Applicant applicant, Policy policy)
        {
            int score = 0;

            if (applicant.Age < 25)
            {
                score = score + 30;
            }

            if (applicant.DrivingExperience < 2)
            {
                score = score + 20;
            }

            score = score + (applicant.History.IncidentCount * 15);

            RiskTier tier;

            if (score < 30)
            {
                tier = RiskTier.Low;
            }
            else if (score < 60)
            {
                tier = RiskTier.Medium;
            }
            else
            {
                tier = RiskTier.High;
            }

            return new RiskProfile(score, tier);
        }
    }
}
