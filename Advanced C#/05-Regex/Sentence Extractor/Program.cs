using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Sentence_Extractor
{
    class Program
    {
        static void Main(string[] args)
        {
            string keyword = Console.ReadLine();
            string text = Console.ReadLine();

            string pattern = @"\b[^.?!]+\b"+keyword+@"\b.*?[!.?]";
            Regex reg = new Regex(pattern);
            MatchCollection mColletion = reg.Matches(text);

            foreach (var VARIABLE in mColletion)
            {
                Console.WriteLine(VARIABLE);
            }
        }
    }
}
