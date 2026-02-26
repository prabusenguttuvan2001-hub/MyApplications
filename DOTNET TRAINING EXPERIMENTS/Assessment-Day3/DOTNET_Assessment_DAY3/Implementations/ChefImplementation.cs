using DOTNET_Assessment_DAY3.Interfaces;

namespace DOTNET_Assessment_DAY3.Implementations
{
    public class ChefImplementation : IChefInterfaces
    {
        public delegate void CallBackCustomer();
        public void CallTable1()
        {
            Console.WriteLine("Table 1 Order is Ready");
        }

        public void CallTable2()
        {
            Console.WriteLine("Table 2 Order is Ready");
        }

        public void CallTable3()
        {
            Console.WriteLine("Table 3 Order is on Process");
            throw new Exception("Your is not Ready");
        }
       
        public void CallTable4()
        {
            Console.WriteLine("Table 4 Order is Ready");
        }
        public string FoodDeliver(CallBackCustomer phoneNumber)
        {
            phoneNumber();
            return "Food is Arrived!";
        }
       
    }
}
