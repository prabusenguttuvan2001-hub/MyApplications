using DOTNET_LEARNING_ASSESSMENT.FactoryPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOTNET_LEARNING_ASSESSMENT.FactoryPattern.Implementation
{
    internal class CashOnDelivery : IPayment
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Payment on Delivery: {amount}");
        }
    }
}
