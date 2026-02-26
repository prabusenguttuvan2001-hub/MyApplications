using InsuranceRisk.Domain.Enums;

namespace InsuranceRisk.API.DTOs
{
    public class RiskResponse
    {
        public bool Eligible { get; set; }
        public int Score { get; set; }
        public RiskTier Tier { get; set; }
        public string Message { get; set; }
    }
}
