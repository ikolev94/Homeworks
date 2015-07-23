using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem7
{
   public class filePath
    {
       public filePath(string extension, string name, long size)
       {
           this.Extension = extension;
           this.Name = name;
           this.Size = size;
       }

       public string Extension { get; set; }
       public string Name { get; set; }
       public long Size { get; set; }
    }
}
