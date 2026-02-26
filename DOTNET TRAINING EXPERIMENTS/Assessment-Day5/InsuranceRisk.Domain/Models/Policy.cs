using InsuranceRisk.Domain.Enums;


namespace InsuranceRisk.Domain.Models
{
    public class Policy
    {
        public PolicyType Type { get; }

        public Policy(PolicyType type)
        {
            Type = type;
        }
    }
}
