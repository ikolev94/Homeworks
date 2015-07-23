using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Slicing_File
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("File to slice");
            string sourceFile = "../../text.txt"; //Console.ReadLine();
            string destinationDirectory = "../../Part";//Console.ReadLine();
            string newDestinationDirectory = "../../Assembled.txt";//Console.ReadLine();
            int n = 5;//int.Parse(Console.ReadLine());


            List<string> partsAddress = Slice(sourceFile, n, destinationDirectory);
            //Assemble(partsAddress, destinationDirectory, newDestinationDirectory);





        }

        public static void Compress(FileStream inputFile, string outputFile)
        {
            //using (var inputSream = new FileStream(inputFile, FileMode.Open))
           // {
                using (var outputStream = new FileStream(outputFile, FileMode.Create))
                {
                    using (var compreesionStream = new GZipStream(outputStream, CompressionMode.Compress, false))
                    {
                        byte[] buffer = new byte[4096];
                        while (true)
                        {
                            int readBytes = inputFile.Read(buffer, 0, buffer.Length);
                            if (readBytes == 0)
                            {
                                break;
                            }
                            compreesionStream.Write(buffer, 0, readBytes);
                        }
                    }
                }
           // }
        }
        public static void Assemble(List<string> partsAddress, string destinationDirectory, string newDestinationDirectory)
        {

            byte[] buffer = new byte[4096];
            FileStream result = new FileStream(newDestinationDirectory, FileMode.Create);
            for (int i = 0; i < partsAddress.Count; i++)
            {
                using (var source = new FileStream(partsAddress[i], FileMode.Open))
                {
                    while (true)
                    {
                        int readBytes = source.Read(buffer, 0, buffer.Length);
                        if (readBytes == 0)
                        {
                            break;
                        }
                        result.Write(buffer, 0, readBytes);
                    }
                }
            }
            result.Close();
        }

        public static List<string> Slice(string sourceFile, int n, string destinationDirectory)
        {
            List<string> partsAddress = new List<string>();
            using (var source = new FileStream(sourceFile, FileMode.Open))
            {
                long sizeOfFile = source.Length;
                long sizeOfparts = sizeOfFile / n;
                byte[] buffer = new byte[sizeOfparts + 1];
                int count = 0;
                for (int i = 0; i < n; i++)
                {
                    partsAddress.Add(destinationDirectory + i);
                }
                while (true)
                {
                    int readBytes = source.Read(buffer, 0, buffer.Length);
                    if (readBytes == 0)
                    {
                        break;
                    }
                    FileStream sream = new FileStream(partsAddress[count], FileMode.Create);
                    
                    sream.Write(buffer, 0, readBytes);
                    //sream.Close();
                    Compress(sream, partsAddress[count] + ".gz");

                    count++;
                }
            }
            return partsAddress;
        }
    }
}
