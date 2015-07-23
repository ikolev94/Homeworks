using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace wordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string listOfWords = @"words.txt";

            using (StreamReader reader = new StreamReader("../../words.txt"))
            {
                using (StreamReader readerText = new StreamReader("../../text.txt"))
                {
                    using (StreamWriter writerr = new StreamWriter("../../results.txt"))
                    {
                        SortedDictionary<string, int> Words = new SortedDictionary<string, int>();
                        string lineOfList = reader.ReadLine();
                        while (lineOfList != null)
                        {
                            Words.Add(lineOfList, 0);
                            lineOfList = reader.ReadLine();
                        }
                        string text = readerText.ReadToEnd();
                        string pattern = @"[a-zA-Z]+";
                        Regex reg = new Regex(pattern);
                        MatchCollection match = reg.Matches(text);
                        string[] textInStrings = new string[match.Count];

                        for (int i = 0; i < match.Count; i++)
                        {
                            textInStrings[i] = match[i].ToString().ToLower();
                        }
                        foreach (var symbol in textInStrings)
                        {
                            if (Words.ContainsKey(symbol))
                            {
                                Words[symbol]++;
                            }

                        }
                        foreach (var pair in Words)
                        {
                            writerr.WriteLine("{0}:{1} time/s", pair.Key, pair.Value);
                        }

                    }
                }
            }
        }
    }
}
