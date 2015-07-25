using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Point3D;

namespace Paths
{
    class Tests
    {
        static void Main(string[] args)
        {
            Storage.Save("7 0 13|2 17 88", "text");
            var points = new List<Point>
            {
                new Point(1 , 3, 5),
                new Point(2 , 3, 5),
                new Point(5 , 13, 51),
                new Point(1 , 3, 25),
                new Point(1 , 3, 5),
                new Point(4 , 3, 6),
            };

            Storage.Save(points, "text2");

            var loadedPoints = Storage.Load("text2");
            var path = new Path3D(loadedPoints);

            Console.WriteLine(path);
        }
    }
}