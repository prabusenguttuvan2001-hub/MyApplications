using DOTNET_LEARNING_ASSESSMENT.StrategyPattern.Implementations;
using DOTNET_LEARNING_ASSESSMENT.StrategyPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOTNET_LEARNING_ASSESSMENT.StrategyPattern.StrategyFolder
{
    internal class ShoppingCart
    {

        private IDiscountStrategy _discountStrategy;

        public ShoppingCart(IDiscountStrategy discountStrategy)
        {
            _discountStrategy = discountStrategy;
        }

        public double GetFinalPrice(double amount)
        {
            return _discountStrategy.Calculate(amount);
        }
        //static void Main(string[] args)
        //{
        //    int amount = 1700;
        //    IDiscountStrategy strategy = new FestivalDiscount();

        //    ShoppingCart cart = new ShoppingCart(strategy);
        //    Console.WriteLine(cart.GetFinalPrice(amount));

        //}
    }

   
}
