using DOTNET_LEARNING_ASSESSMENT.StrategyPattern.Interfaces;

namespace DOTNET_LEARNING_ASSESSMENT.StrategyPattern.Implementations
{
    internal class FestivalDiscount : IDiscountStrategy
    {
        public double Calculate(double amount)
        {
            return amount * 0.8;
        }
    }
}
