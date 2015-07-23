using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Unicode_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            foreach (var word in input)
            {
                Console.Write("\\u{0}",((int)word).ToString("x4"));
            }
        }
    }
}
