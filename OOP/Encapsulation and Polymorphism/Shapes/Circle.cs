using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Circle:IShape
    {
        public Circle(int radius)
        {
            this.Radius = radius;
        }

        public int Radius { get; set; }
        public double CalculateArea()
        {
            return(this.Radius*this.Radius*Math.PI);
        }

        public double CalculatePerimeter()
        {
            double result= this.Radius*2*Math.PI;
            return result;
        }
    }
}
