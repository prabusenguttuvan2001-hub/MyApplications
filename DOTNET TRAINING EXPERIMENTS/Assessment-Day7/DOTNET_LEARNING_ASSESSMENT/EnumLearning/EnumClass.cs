using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOTNET_LEARNING_ASSESSMENT.EnumLearning
{
    internal class EnumClass
    {
        enum Level
        {
            small, medium, big // small 0, medium 1, big 2
        }
        enum Scores
        {
            max = 100,  // 100
            min = 35,   // 35
            avg         // 36
        }
        //static void Main(string[] args)
        //{
        //    Level l1 = Level.small;
        //    Console.WriteLine(l1); // small

        //    int val = (int) Level.medium;
        //    Console.WriteLine(val); // 1

        //    Scores highest_mark = Scores.max;
        //    Console.WriteLine(highest_mark); // returning max enum like max

        //    int  highest_value = (int) Scores.max;
        //    Console.WriteLine("max value :" + highest_value); // returning max value 100 that is stored in the enum "max"

        //    Console.WriteLine("Avg value: "+(int)Scores.avg); // this will returns avg value.. because we didn't specify any value to the avg.
        //}
    }
    enum validity
    {
        low,
        medium
    }
}
