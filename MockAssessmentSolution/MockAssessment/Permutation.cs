using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockAssessment
{
    internal class Permutation
    {
        static void Main(string[] args)
        {
            String input = "listen";
            Char[] ch1 = input.ToLower().ToCharArray();
            Array.Sort(ch1);
            String FinalInput = ch1.ToString();

            List<string> list = new List<string> { "enlist", "silent", "inlets", "hello", "world" , "system"};

            List<String> finalList = new List<String>();


            foreach (string s in list)
            {
                if (input.Length == s.Length)
                {
                    
                   Char [] ch2 = s.ToLower().ToCharArray();
                   Array.Sort(ch2);
                   String temp = ch2.ToString();

                    if(FinalInput.Equals(temp))
                    {
                        finalList.Add(s);
                    }
                }
            }

            Console.WriteLine(String.Join(',', finalList));
        }
    }
}

