using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOTNET_LEARNING_ASSESSMENT.StrategyPattern.Interfaces
{
    internal interface IDiscountStrategy
    {
        double Calculate(double amount);
    }
}
