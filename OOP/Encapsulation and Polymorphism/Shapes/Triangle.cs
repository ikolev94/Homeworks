using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Triangle:BasicShape
    {
        public Triangle(int height, int widht) : base(height, widht)
        {
        }

        public override double CalculateArea()
        {
           double result = (Height*Widht)/2d;
            return result;
        }

        public override double CalculatePerimeter()
        {
            double a = Widht/2;
            double size = Math.Sqrt(Height*Height + a*a);
            Console.WriteLine(size+size+Widht);
            double result = size + size + Widht;
            return result;
        }
    }
}
