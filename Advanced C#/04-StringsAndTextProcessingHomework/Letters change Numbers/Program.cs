using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LettersNumbers_7
{
    class LettersNumbers_7
    {
        static decimal result = 0;

        static void CalcResult(char first, char last, int num)
        {
            if (Char.IsUpper(first))
            {
                result += num / (decimal)(first - 'A' + 1);
            }
            else if (Char.IsLower(first))
            {
                result += num * (decimal)(first - 'a' + 1);
            }

            if (Char.IsUpper(last))
            {
                result -= (decimal)(last - 'A' + 1);
            }
            else if (Char.IsLower(last))
            {
                result += (decimal)(last - 'a' + 1);
            }
        }
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var word in input)
            {
                char first = word.First();
                char last = word.Last();
                int number = int.Parse(Regex.Match(word, @"\d+").Value);

                CalcResult(first, last, number);
            }
            Console.WriteLine("{0:F2}", result);
        }
    }
}