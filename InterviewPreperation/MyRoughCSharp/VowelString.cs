/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRoughCSharp
{
    public class VowelString
    {
        public void Vowels()
        {
            String sentence = Console.ReadLine().ToLower();
            String[] StrArr = sentence.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            String vowels = "aeiou";
            List<String> Vowellist = new List<String>();

            foreach (String word in StrArr)
            {
                for (int i = 0; i < word.Length-1; i++)
                {
                    if(vowels.Contains(word[i]) && vowels.Contains(word[i+1]))
                    {
                        Vowellist.Add(word);
                        break;
                    }
                }

            }
            if (Vowellist.Count > 0)
            {
                Console.WriteLine(String.Join(",", Vowellist));
            }
            else
                Console.WriteLine("this sentence doesn't contain consecutive vowels");
           
        }

        public void RevString()
        {
            String input = Console.ReadLine().ToLower();
            String Reverse = "";
            int count = 0;
            foreach (char ch in input)
            {
                count++;
            }

            for(int i=count -1; i >= 0; i--)
            {
                Reverse=Reverse+input[i];
            }

            Console.WriteLine(Reverse);

        }

        public void Titlecase()
        {
            String input = Console.ReadLine().ToLower();
            String result = "";
           
            String[] arr = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

           for(int i=0; i<arr.Length-1; i++)
            {
                bool newword = true;
                foreach (char ch in arr[i])
                {
                    if (newword)
                    {
                        Char temp= ch;
                        temp = (char)(temp - 32);
                        result = result + temp;
                        newword = false;
                    }
                    result = result + ch;
                }
            }

           Console.WriteLine(result);

        }

        public void WordCount()
        {
            string input = "  This is  a  simple  sentence! ";

            int count = 0;
            bool inWord = false;

            Console.WriteLine(!inWord);

            for (int i = 0; i < input.Length; i++)
            {
                char ch = input[i];

                
                if (ch != ' ')
                {
                    if (!inWord)
                    {
                        count++;     
                        inWord = true;
                    }
                }
                else
                {
                    inWord = false;  
                }
            }

            Console.WriteLine("the word count is: "+count);



        }
    }
}
*/