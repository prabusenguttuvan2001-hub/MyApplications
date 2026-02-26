using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRoughCSharp
{
    public class RoughWork
    {
        public static void Main(string[] args)
        {
            Thread ab = new Thread(kowshik);

            ab.Start();
        
    }
        static void kowshik()
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
