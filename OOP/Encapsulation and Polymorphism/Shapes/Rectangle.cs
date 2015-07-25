using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Rectangle:BasicShape
    {
        public Rectangle(int height, int widht) : base(height, widht)
        {
        }

        public override double CalculateArea()
        {
            return Height*Widht;
        }

        public override double CalculatePerimeter()
        {
            double result=(2*Height+2*Widht);
            return result;
        }
    }
}
