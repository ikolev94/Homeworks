using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SeriesOfLetters
{
    class SeriesOfLetters
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string pattern = @"([a-z])\1+";
            Regex regex = new Regex(pattern);
            MatchCollection match = Regex.Matches(text, pattern);
            for (int i = 0; i < match.Count; i++)
            {
                string tempPattern = match[i].ToString();
                string replace = tempPattern.First().ToString();
                Regex tempRegex = new Regex(tempPattern);
                text = tempRegex.Replace(text, replace);
            }
            Console.WriteLine(text);

        }
    }
}