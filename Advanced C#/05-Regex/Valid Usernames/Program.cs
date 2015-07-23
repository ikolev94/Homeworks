using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Valid_Usernames
{
    class Program
    {
        static void Main()
        {
            string usernames = Console.ReadLine();
            string pattern = @"\b([A-Za-z][A-Za-z0-9_]{2,25})\b";
            Regex reg = new Regex(pattern);
            MatchCollection mcollection = reg.Matches(usernames);
            int maxSum = 0;
            int index = 0;
            for (int i = 0; i < mcollection.Count - 1; i++)
            {
                int sum = mcollection[i].Groups[0].Length + mcollection[i + 1].Groups[0].Length;
                if (sum > maxSum)
                {
                    maxSum = sum;
                    index = i;
                }
            }
            Console.WriteLine(mcollection[index].Groups[0]);
            Console.WriteLine(mcollection[index + 1].Groups[0]);
        }
    }
}
