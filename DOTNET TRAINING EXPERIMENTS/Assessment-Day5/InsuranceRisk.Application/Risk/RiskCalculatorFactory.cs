using InsuranceRisk.Application.Interfaces;
using InsuranceRisk.Domain.Enums;
using System;

namespace InsuranceRisk.Application.Risk
{
    public class RiskCalculatorFactory
    {
        public static IRiskCalculator GetCalculator(PolicyType type)
        {
            if (type == PolicyType.Car)
            {
                return new CarRiskCalculator();
            }
            else if (type == PolicyType.Bike)
            {
                return new BikeRiskCalculator();
            }
            else
            {
                throw new NotSupportedException("Policy not supported");
            }
        }
    }
}
