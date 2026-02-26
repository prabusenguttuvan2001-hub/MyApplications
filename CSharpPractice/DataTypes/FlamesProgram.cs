using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    public class FlamesProgram
    {
        public void flames(string first, string second)
        {
            if(first.Length == 0 || second.Length == 0)
            {
                Console.WriteLine("Please enter valid names.");
                return;
            }
            first = first.ToLower();
            second = second.ToLower();
            char[] str1= first.ToCharArray();
            char[] str2= second.ToCharArray();
            List<char> game = new List<char>{ 'F', 'L', 'A', 'M', 'E', 'S' };
            int count = 0;
            for (int i = 0; i < str1.Length; i++)
            {
                for (int j = 0; j < str2.Length; j++)
                {
                    if (str1[i] == str2[j] || (str1[i] == ' ' || str2[j] == ' '))
                    {
                        str2[j] = '-';
                        str1[i] = '-';
                        break;
                    }
                }
            }
            foreach (char c in str1)
            {
                if (c != '-')
                {
                    count++;
                }
            }
            foreach(char c in str2)
            {
                if (c != '-')
                {
                    count++;
                }
            }
            Console.WriteLine(count);
            int innercount = 0;
            int outercount = count;
            int index = 0;
            while (outercount > 0)
            {
                while (innercount < count)
                {
                    if(index == game.Count-1)
                    {
                        index = (index + 1) % game.Count;
                        innercount++;
                    }
                    else
                    {
                        index++;
                        innercount++;
                       
                    }
                    if((innercount+1)==count)
                    {
                        game.RemoveAt(index);
                        innercount = 0;
                        outercount--;
                        if(index ==game.Count)
                        {
                            index = 0; 
                        }
                        break;
                    }
                }
                if (game.Count == 1)
                {
                    break;
                }
            }

            switch(game[0])
            {
                case 'F':
                    Console.WriteLine(first+" and "+second+" are Friends!");
                    break;

                case 'L':
                    Console.WriteLine(first + " and " + second + ", they Both are in Love!");
                    break;

                case 'A':
                    Console.WriteLine(first + " and " + second + ", they have lot of Affection on eachother!");
                    break;

                case 'M':
                    Console.WriteLine(first + " and " + second + " gonna Marry Soon!");
                    break;

                case 'E':
                    Console.WriteLine(first + " and " + second + ", they are literally Enemies!");
                    break;

                case 'S':
                    Console.WriteLine(first + " and " + second + " are Sisters!");
                    break;
            }
        }
    }
}
