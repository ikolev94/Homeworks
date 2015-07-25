using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            var shapes = new List<IShape>()
            {
                new Rectangle(3, 5),
                new Triangle(3, 4),
                new Circle(3),
                new Circle(1),
                new Rectangle(2,8),
                new Triangle(22,7)
            };
            Console.WriteLine("Areas");
            foreach (var shape in shapes)
            {
                Console.WriteLine("{0:f2}", shape.CalculateArea());
            }
            Console.WriteLine("Perimeters");
            foreach (var shape in shapes)
            {
                Console.WriteLine("{0:f1}",shape.CalculatePerimeter());
            }
        }
    }
}
