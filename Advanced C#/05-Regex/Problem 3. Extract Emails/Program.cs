using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Problem_3.Extract_Emails
{
    class Program
    {
        static void Main()
        {
            string text = Console.ReadLine();
            string pattern = @"\s\b(?<email>[A-Za-z0-9][A-Za-z0-_?.-]+@[A-Za-z0-9]+\.[A-Za-z.]+)\b";
            Regex reg = new Regex(pattern);
            MatchCollection matchColec = reg.Matches(text);
            foreach (var email in matchColec)
            {
                Console.WriteLine(email.ToString().Trim());
            }
        }
    }
}
