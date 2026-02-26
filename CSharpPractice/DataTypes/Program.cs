


using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices.Marshalling;
using System.Xml.Linq;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Program obj = new Program();
            //Console.WriteLine(obj.leettrail13());
            //obj.leettrail14();
            FlamesProgram f = new FlamesProgram();
            f.flames("Moovendhran", "");
        }

        public void leettrail1()
        {
            int[] gifts = { 30 };
            int k = 53;

            while (k != 0)
            {

                for (int i = 0; i < gifts.Length; i++)
                {
                    Array.Sort(gifts);
                    Array.Reverse(gifts);

                    int temp = (int)Math.Sqrt(gifts[i]);


                    gifts[i] = temp;
                    break;
                }
                k--;
            }

            Console.WriteLine(string.Join(", ", gifts));
            int ans = 0;
            for (int i = 0; i < gifts.Length; i++)
            {
                ans += gifts[i];
            }

            Console.WriteLine(ans);
        }

        public void leettrail2()
        {
            int[] nums = { 2, 1, 3, 5, 6 };     
            int k = 5;
            int multiplier = 2;

            while (k != 0)
            {
                int x = nums.Min();
                int inde= Array.IndexOf(nums, x);
                nums[inde] = x * multiplier;
                
                k--;
            }

         Console.WriteLine(String.Join(", ", nums));
        }

        public void leettrail3()
        {
            int[] prices = { 8, 4, 6, 2, 3 };
            int[] discount = new int[prices.Length];

            for (int i = 0; i < prices.Length; i++)
            {
                for (int j = i+1;j<prices.Length; j++)
                {
                    if (prices[i] > prices[j])
                    {
                        int dis = prices[i] - prices[j];
                        discount[i] = dis;
                        break;
                    }
                    else
                    {
                        discount[i] = prices[i];
                        continue;
                    }   
                }
                if (i == prices.Length - 1)
                {
                    discount[i] = prices[i];
                    break;
                }
            }

            Console.WriteLine(string.Join(", ", discount));
        }

        public void leettrail4()
        {
            string s = "011101";
            
            int maxi = 0;
            for (int i = 0; i < s.Length-1; i++)
            {
                int count0 = 0;
                int count1 = 0;
                String str1 = s.Substring(0, i+1);
                String str2 = s.Substring(i+1);
               
                foreach (char su in str1)
                {
                    if (su == '0')
                    {
                        count0++;
                    }
                }
                foreach (char su in str2)
                {
                    if (su == '1')
                    {
                        count1++;
                    }
                }
                int temp = count0 + count1;
                if(maxi<temp)
                {
                    maxi = temp;
                }
            }
            Console.WriteLine(maxi);
        }

        public void leettrail5()
        {
            string[] words = { "leetcoder", "leetcode", "od", "hamlet", "am" };
            List<string> list = new List<string>();

            for (int i = 0; i < words.Length; i++)
            {
                for (int j = 0; j < words.Length; j++)
                {
                    if ( i!=j && words[i].Contains(words[j]) && !list.Contains(words[j]))
                    {
                        
                        list.Add(words[j]);
                    }
                }
            }
            Console.WriteLine(string.Join(",", list));
            
        }

        public void leettrail6()
        {
            string[] words = { "a", "aba", "ababa", "aa" };
            int count = 0;
            for(int i=0;i<words.Length; i++)
            {

                for (int j = i + 1; j < words.Length; j++)
                {
                    string str1= words[i];
                    string str2= words[j];

                    if (str1.Length > str2.Length)
                        continue;
                 
                if (str2.StartsWith(str1) && str2.EndsWith(str1))
                {
                count++;
                }
                }
                
            }
            Console.WriteLine("Count= "+ count);
        }

        public void leettrail7()
        {

            //Incomplete--

            string[] words1 = { "amazon", "apple", "facebook", "google", "leetcode" };
            string[] words2 = { "lc", "eo" };

            string letter = words2.ToString();   
            List<string> list = new List<string>();
          

            for(int i=0;i<words1.Length; i++)
            {
                string temp= words1[i];
                for (int j = 0; j < temp.Length; j++)
                {
                   
                }
            }

           

        }
        public void leettrail8()
        {
            int[] nums = { 3, 2, 4 };
            int target = 6;
            List<int> ans = new List<int>();
            
            for (int i = 0; i < nums.Length; i++)
            {
               for(int j=i+1; j<nums.Length; j++)                   
               {  
                    if (target - nums[i] == nums[j])
                    {
                        ans.Add(i);
                        ans.Add(j);                      
                    }
               }

            }
            Console.WriteLine(string.Join(",", ans));
        }

        public void leettrail9()
        {
            string s = "pwwkew";
            string temp= "";
            int count = 0;
            
            List<int> ans = new List<int>();
            for(int i=0;i < s.Length;i++)
            {
                for(int j=i; j<s.Length;j++)
                {
                    if (!temp.Contains(s[j]))
                    {
                        temp = temp + s[j];
                        count = temp.Length;
                    }
                    else
                    {
                        temp = "";
                        break;
                    }   
                } 
                ans.Add(count);
            }
            int lar = 0;
            foreach (int i in ans)
            {
                if(i<=lar)
                {
                    lar = i;
                }
            }
            Console.WriteLine(lar);

        }

        /*  Input: s = "babad"
            Output: "bab"
            Explanation: "aba" is also a valid answer.*/
        public void leettrail10()
        {
            string s = "babad";
            string temp = "";
            int count = 0;

            List<string> ans = new List<string>();
            for (int i = 0; i < s.Length; i++)
            {
                for(int j=s.Length-1;j>=i;j--)
                {
                    if (s[i] == s[j])
                    {
                        string sub1 = "";
                        int left = i;
                        int right = j;
                        int innerCount = 0;
                        while (left <=right)
                        { 
                            innerCount++;
                            right--;
                        }
                        sub1=s.Substring(i, innerCount);
                            
                        Char[] ch = sub1.ToCharArray();
                        Array.Reverse(ch);
                        string sub2 = new string(ch);
                        if (sub1.Equals(sub2))
                        {
                            if(!ans.Contains(sub1)) 
                            ans.Add(sub1);
                        }
                    }
                      

                }  
            }
            string sh = "";
            foreach (string str in ans)
            {
                int leg = 0;
                if(str.Length >sh.Length)
                {
                    sh= str;
                }
            }
            Console.WriteLine("Longest Plaindrome : "+sh);

        }
        public void leettrail11()
        {


        /*        Input: num = 9669
                Output: 9969
                Explanation:
                            Changing the first digit results in 6669.
                Changing the second digit results in 9969.
                Changing the third digit results in 9699.
                Changing the fourth digit results in 9666.
                The maximum number is 9969.*/


            int num = 9999;
            int length = num.ToString().Length;
            int repeat = 0;
            int ans = num;
            while (length != 0)
            {
                char[] numbers= num.ToString().ToCharArray();
                bool flag = true;
                while(flag)
                {

                    if (numbers[repeat] == '9')
                    {
                        numbers[repeat] = '6';
                        repeat++;
                        break;
                    }
                    else if(numbers[repeat] =='6')
                    {
                        numbers[repeat] = '9';
                        repeat++;
                        break;
                    }
                    
                }
                string str = new string(numbers);
                int temp = Int32.Parse(str);
                if (ans<=temp)
                {
                    ans= temp;
                }

                length--;
            }
            Console.WriteLine("Largest value: "+ ans);


        }


        public void leettrail12()
        {
            /*Input: arr = [40, 10, 20, 30]
            Output: [4, 1, 2, 3]
            Explanation: 40 is the largest element. 10 is the smallest. 20 is the second smallest. 30 is the third smallest.
            [5,3,4,2,8,6,7,1,3]*/

            int[] arr = { -1, 1, 2, 3 };
            int[] brr = (int[])arr.Clone();
            int[] crr= new int[arr.Length];
            List<int> list = new List<int>();
            Console.WriteLine("Sorted Array: ");
            foreach (int f in brr)
            {
                Console.Write(f + " ");
            }
            Array.Sort(brr);

            int rank = 1;
            for(int i=0; i<arr.Length; i++)
            {
                int temp = brr[i];
                if (!list.Contains(temp))
                {
                    list.Add(temp);
                    for (int j = 0; j < arr.Length; j++)
                    {
                        if (temp == arr[j])
                        {
                            crr[j] = rank;
                        }
                    }
                    rank++;
                }
                else
                {
                    continue;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Rank Array: ");
            foreach(int f in crr)
            {
                Console.Write(f+" ");
            }

        }

        public bool leettrail13()
        {
            int x = 121;
            string str= x.ToString();
            string temp = "";
            for (int i = str.Length - 1; i >= 0; i--)
            {
                temp = temp + str[i];
            }
            if(temp == str)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public void leettrail14()
        {
/*
        Input: list1 = [1, 2, 4], list2 = [1, 3, 4]
        Output: [1, 1, 2, 3, 4, 4]
*/

            List<int> list1 = new List<int> { 1, 2, 4 };
            List<int> list2 = new List<int> { 1, 3, 4 };
            //List<int> list = new List<int>();
            list1.AddRange(list2);
            int[] arr= list1.ToArray();
            Array.Sort(arr);
            arr.ToList().Clear();
            foreach(int i in arr)
            {
                Console.WriteLine(arr[i]);
            }
            
        }

        public void leettrail15()
        {
            int[] nums = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
            int[] arr = new int[nums.Length];
            List<int> list = new List<int>();
            
            for (int i = 0; i < nums.Length; i++)
            {
                if (!list.Contains(nums[i]))
                {
                    list.Add(nums[i]);
                }
            }

            for(int i = 0;i < list.Count; i++)
            {
                arr[i] = list[i];
            }
        }

        public void selfDividingNumber()
        {
            int left = 1; int right = 22;

            List<int> nums = new List<int>();
            
            while(left <= right)
            {
                bool flag = true;
                int i = left;
                int original = left;
                while (i != 0)
                {
                    int remainder = i % 10;
                    if(remainder == 0 || original % remainder!=0)
                    {
                        flag = false;
                        break;
                    }
                    i /= 10;
                }
                left++;
                if (flag)
                {
                    nums.Add(original);
                }
                
            }

            Console.WriteLine(string.Join(",", nums));
        }
    }
}

