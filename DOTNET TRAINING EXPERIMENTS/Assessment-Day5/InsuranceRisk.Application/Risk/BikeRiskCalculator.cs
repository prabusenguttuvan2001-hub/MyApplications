using InsuranceRisk.Application.Interfaces;
using InsuranceRisk.Domain.Enums;
using InsuranceRisk.Domain.Models;

namespace InsuranceRisk.Application.Risk
{
    public class BikeRiskCalculator : IRiskCalculator
    {
        public RiskProfile Calculate(Applicant applicant, Policy policy)
        {
            int score = 0;

            if (applicant.Age < 22)
            {
                score = score + 25;
            }

            score = score + (applicant.History.IncidentCount * 10);

            RiskTier tier;

            if (score < 25)
            {
                tier = RiskTier.Low;
            }
            else if (score < 50)
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
