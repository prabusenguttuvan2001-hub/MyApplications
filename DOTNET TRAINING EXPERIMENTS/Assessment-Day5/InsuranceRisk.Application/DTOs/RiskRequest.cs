using InsuranceRisk.Domain.Enums;

namespace InsuranceRisk.API.DTOs
{
    public class RiskRequest
    {
        public int Age { get; set; }
        public int Experience { get; set; }
        public int Incidents { get; set; }
        public PolicyType PolicyType { get; set; }
    }
}
