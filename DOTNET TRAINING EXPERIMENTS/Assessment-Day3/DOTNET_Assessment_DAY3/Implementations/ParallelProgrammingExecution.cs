using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOTNET_Assessment_DAY3.Implementations
{
    public class ParallelProgrammingExecution
    {
        public void CookMeal()
        {
            Console.WriteLine("Chef Preaparing Meal!");
            Thread.Sleep(3000);
            Console.WriteLine("MEal is Ready");
        }

        public void PreparingJuice()
        {
            Console.WriteLine("Cutting fruits for juice");
            Thread.Sleep(2000);
            Console.WriteLine("Your Juice is ready!");
        }

        public void FryChicken()
        {
            Console.WriteLine("Frying Chicken..!");
            Thread.Sleep(4000);
            Console.WriteLine("Your Chicken is ready!");
        }

        //static void Main()
        //{
           
        //    ParallelProgrammingExecution par= new ParallelProgrammingExecution();
        //    par.CookMeal();
        //    par.PreparingJuice();
        //    par.FryChicken();


        //    Parallel.Invoke(
        //        () => par.CookMeal(),
        //        () => par.PreparingJuice(),
        //        () => par.FryChicken()
        //    );

        //    Console.WriteLine("Your Order is ready!.");
        //}
    }
}
