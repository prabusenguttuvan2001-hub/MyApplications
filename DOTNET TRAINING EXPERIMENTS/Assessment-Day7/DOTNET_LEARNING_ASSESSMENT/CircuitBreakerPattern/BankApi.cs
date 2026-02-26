using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOTNET_LEARNING_ASSESSMENT.CircuitBreakerPattern
{
    internal class BankApi
    {
        private static Random _rand = new Random();

        public static void Pay()
        {
            // Randomly fail
            if (_rand.Next(1, 4) != 1)
                throw new Exception("Bank service is down");

            Console.WriteLine("Payment successful");
        }
    }

}
