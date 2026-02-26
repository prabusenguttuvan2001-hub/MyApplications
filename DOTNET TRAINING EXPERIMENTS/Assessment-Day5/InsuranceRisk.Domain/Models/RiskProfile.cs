using InsuranceRisk.Domain.Enums;

namespace InsuranceRisk.Domain.Models
{
    public class RiskProfile
    {
        public int Score { get; }
        public RiskTier Tier { get; }

        public RiskProfile(int score, RiskTier tier)
        {
            Score = score;
            Tier = tier;
        }
    }
}
