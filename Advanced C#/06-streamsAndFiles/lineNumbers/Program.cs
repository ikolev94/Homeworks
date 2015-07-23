using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string oldPath = @"../../text.txt";
            string newPath = @"../../newText.txt";
            using (var reader = new StreamReader(oldPath))
            {
                using (var writer = new StreamWriter(newPath))
                {
                    string line = reader.ReadLine();
                    int count = 0;
                    while (line!=null)
                    {
                        writer.Write("line: " + count+" ");
                        for (int i = 0; i < line.Length; i++)
                        {
                            writer.Write(line[i]);
                        }
                        writer.WriteLine();
                        line = reader.ReadLine();
                        count++;
                    }
                }
            }
        }
    }
}
