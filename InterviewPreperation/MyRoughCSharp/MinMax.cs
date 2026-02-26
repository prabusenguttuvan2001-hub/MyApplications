/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRoughCSharp
{
    class MinMax
    {
        public static void Main(String[] args)
        {
            int[] Arr = new int[] { 28, 4, 3, 21, 8, 1, 23, 143, 98 };
            //Minimum using sort
            Array.Sort(Arr);
            Console.WriteLine(Arr[0]);

            //Minimum using Loop
            int MinTemp = 0;
            foreach (int num in Arr)
            {
                if(num <MinTemp)
                MinTemp = num;
            }
            Console.WriteLine("using Loop: "+MinTemp);

            //Minimum using Linq
            Console.WriteLine("Using Linq: "+Arr.Min());

            //Maximum using Sort
            Console.WriteLine("Maximum: "+Arr[Arr.Length-1]);

            //Maximum using Loop
            int MaxTemp = 0;
            foreach (int num in Arr)
            {
                if (num > MaxTemp)
                    MaxTemp = num;
            }
            Console.WriteLine("using Loop: " + MaxTemp);

            //Maximum using Linq
            Console.WriteLine("Using Linq: " + Arr.Max());


            VowelString obj= new VowelString();
            obj.WordCount();
        
        
        
        
        }
    }


    public class  Notification
    {
        
         public INotification Notify()
        {
            var type = "SMS";
            Console.WriteLine("get config!");

            if(type == "SMS")
            {
                return new SMS();
            }
            else if (type == "Email")
            {
                return new Email();
            }
            else             {
                throw new NotSupportedException("Notification type not supported");
            }


        }
    }


    public interface INotification
    {
        void Send();
    }
    public class  SMS : INotification
    {
        public void Send()
        {
            Console.WriteLine("SMS sent!");
        }

    }

    public class Email : INotification
    {
        public void Send()
        {
            Console.WriteLine("Email sent!");
        }
    }
}
*/