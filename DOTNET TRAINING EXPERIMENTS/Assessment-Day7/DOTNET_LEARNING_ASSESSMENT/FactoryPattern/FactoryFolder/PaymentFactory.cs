using DOTNET_LEARNING_ASSESSMENT.FactoryPattern.Implementation;
using DOTNET_LEARNING_ASSESSMENT.FactoryPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOTNET_LEARNING_ASSESSMENT.FactoryPattern.FactoryFolder
{
    internal class PaymentFactory
    {
        public static IPayment GetPaymentMethod(string paymentType)
        {
            return paymentType switch
            {
                "CreditCard" => new CreditCardPayment(),
                "UPI" => new UPIPayment(),
                "COD" => new CashOnDelivery(),
                _ => throw new Exception("Invalid payment type")
            };
        }
        //static void Main(string[] args)
        //{
        //    IPayment payment = PaymentFactory.GetPaymentMethod("UPI");
        //    payment.Pay(1000);
        //}
    }

    
}
