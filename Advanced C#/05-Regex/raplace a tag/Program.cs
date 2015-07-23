using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace raplace_a_tag
{
    class Program
    {
        static void Main(string[] args)
        {
            string htmltext = Console.ReadLine();
            string pattern = @"<a href=http:\/\/(?<site>[a-zA-Z]+).(?<extention>[a-z]{2,3})>(?<site2>[A-Za-z]+)<\/a>";
            Regex regex = new Regex(pattern);

            MatchCollection match = regex.Matches(htmltext);

            for (int i = 0; i < match.Count; i++)
            {
                string tempPattern = match[i].ToString();
                string replace = "[URL href=http://" + match[i].Groups["site"] + "." + match[i].Groups["extention"] + "]" + match[i].Groups["site2"] + "[/URL]";
                Regex tempRegex = new Regex(tempPattern);
                htmltext = tempRegex.Replace(htmltext, replace);
            }
            Console.WriteLine(htmltext);
        }
    }
}
