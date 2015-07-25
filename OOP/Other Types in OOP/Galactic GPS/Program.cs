using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Galactic_GPS
{
    class Program
    {
        static void Main(string[] args)
        {
            Location home = new Location(22.412,41.24,Planet.Mars);
            Location work = new Location(-22.5521,123.11556,Planet.Mercury);
            Console.WriteLine(home);
            Console.WriteLine(work);
        }
    }
}
