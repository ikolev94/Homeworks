using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] text =
            {
                '*', '*', '*', '*', '*', '*', '*', '*', '*', '*', '*', '*', '*', '*', '*', '*', '*', '*', '*',
                '*',
            };

            string input = Console.ReadLine();
            for (int i = 0; i < input.Length; i++)
            {
                if (i>=text.Length)
                {
                    break;
                }
                char temp = input[i];
                text[i] = temp;
            }
            foreach (var VARIABLE in text)
            {
                Console.Write(VARIABLE);
            }
            Console.WriteLine();
        }
    }
}
