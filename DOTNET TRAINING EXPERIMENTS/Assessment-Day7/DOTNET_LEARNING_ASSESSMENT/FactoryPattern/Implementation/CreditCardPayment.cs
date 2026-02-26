using DOTNET_LEARNING_ASSESSMENT.FactoryPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOTNET_LEARNING_ASSESSMENT.FactoryPattern.Implementation
{
    internal class CreditCardPayment : IPayment
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Paid {amount} using Credit Card");
        }
    }
}
