using DOTNET_LEARNING_ASSESSMENT.StrategyPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOTNET_LEARNING_ASSESSMENT.StrategyPattern.Implementations
{
    internal class PremiumDiscount: IDiscountStrategy
    {
        public double Calculate(double amount)
        {
            return amount * 0.7;
        }
    }
}
