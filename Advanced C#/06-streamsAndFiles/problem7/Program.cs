using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem7
{
    class Program
    {
        static void Main(string[] args)
        {
            string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string[] files = Directory.GetFiles("../../");
            List<filePath>baza=new List<filePath>();
            foreach (var file in files)
            {
                var info = new FileInfo(file);
                baza.Add(new filePath(info.Extension, info.Name, info.Length));
            }

            var fileIinfo =
                from f in baza
                orderby f.Size
                group f by f.Extension
                into extGroup
                orderby extGroup.Key
                orderby extGroup.Count() descending 
                select extGroup;

            StreamWriter writer = new StreamWriter(desktop + "/report.txt");
            foreach (var file in fileIinfo)
            {
                writer.WriteLine(file.Key);
                foreach (var nameSize in file)
                {
                    writer.WriteLine("--{0} - {1:F3}kb",nameSize.Name,nameSize.Size/1024.0);
                }
            }
            writer.Close();
        }
    }
}
