using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine().ToLower();
            string searchString = Console.ReadLine();
            int size = text.Length - searchString.Length;
            int caunt = 0;
            if (size < 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                for (int i = 0; i <= size; i++)
                {
                    string temp = text.Substring(i, searchString.Length);
                    if (temp==searchString)
                    {
                        caunt++;
                    }
                }
                Console.WriteLine(caunt);
            }
        }
    }

