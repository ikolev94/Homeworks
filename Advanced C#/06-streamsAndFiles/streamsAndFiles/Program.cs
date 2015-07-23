using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace streamsAndFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"../../text.txt";

            using (var reader = new StreamReader(path))
            {
                string line = reader.ReadLine();
                int i = 1;
                while (line !=null)
                {
                    if (i%2==1)
                    {
                        Console.WriteLine(line);
                    }
                    line = reader.ReadLine();
                    i++;
                }
            }
        }
    }
}
