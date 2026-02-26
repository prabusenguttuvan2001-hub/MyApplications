
namespace InsuranceRisk.Domain.Models
{
    public class EligibilityResult
    {
        public bool IsEligible { get; }
        public RiskProfile Profile { get; }
        public string Message { get; }

        public EligibilityResult(bool eligible, RiskProfile profile, string reason = "")
        {
            IsEligible = eligible;
            Profile = profile;
            Message = reason;
        }
    }
}
