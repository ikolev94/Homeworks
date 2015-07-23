using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindromes
{
    class Program
    {

        static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        static void Main()
        {
            string[] input = Console.ReadLine().Split(new char[] { ',', ':', ';', ' ', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);
            SortedSet<string> sortOutput = new SortedSet<string>();
            for (int i = 0; i < input.Length; i++)
            {
                string reversed = Reverse(input[i]);
                if (input[i] == reversed)
                {
                    sortOutput.Add(input[i]);
                }
            }
            Console.WriteLine(string.Join(", ", sortOutput));
        }

    }
}
