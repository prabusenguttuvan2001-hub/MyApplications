using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRoughCSharp
{
    class Anangram
    {
        public delegate string dele(string hero);
        public static void main(string[] args)
        {
           /* String str1 = "maths";
           // Console.WriteLine("Original String : "+str1);
            Char[] charArr = str1.ToCharArray();
            Array.Sort(charArr);
            String FinalStr = new String(charArr);
            List<string> listStr = new List<string> { "sathm", "thams", "thesi", "Anu", "Nmala", "hmsat" };
            List<string> listFinal = new List<string>();
            foreach (string str2 in listStr)
            {

                if (str2.Length == FinalStr.Length)
                {
                    Char[] ch1 = str2.ToLower().ToCharArray();
                    Array.Sort(ch1);
                    String temp = new String(ch1);
                    if (FinalStr.Equals(temp))
                    {
                        listFinal.Add(str2);
                    }
                }
            }

            foreach (string str3 in listFinal)
            {
                Console.WriteLine(str3 + " ");
            }*/
            Anangram ana = new Anangram();


            Sangeetha san = new Sangeetha();
            ana.PrintFunction("Leo", san.LeoFunction);
           

    }
        public void PrintFunction(string word, dele SanFunction)
        {
            string str = SanFunction(word);
            Console.WriteLine(str);
        }
    }

    class Sangeetha
    {

        public string LeoFunction(string word)
        {
            return "Naan than da " + word;
        }

        public string BatmanFunction(string word)
        {
            return "Naan than da " + word;
        }
    }
}
