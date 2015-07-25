using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    abstract class BasicShape : IShape

    {
        private int height;
        private int widht;

        public BasicShape(int height, int widht)
        {
            this.Height = height;
            this.Widht = widht;
        }

        public int Height { get; set; }
        public int Widht { get; set; }

        public abstract double CalculateArea();
        public abstract double CalculatePerimeter();

    }
}
