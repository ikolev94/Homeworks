namespace Abstraction
{
    using System;

    internal class Circle : IFigure
    {
        private double _radius;

        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public double Radius
        {
            get
            {
                return this._radius;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Radius cannot be negative");
                }

                this._radius = value;
            }
        }

        public double CalcPerimeter()
        {
            double perimeter = 2 * Math.PI * this.Radius;
            return perimeter;
        }

        public double CalcSurface()
        {
            double surface = Math.PI * this.Radius * this.Radius;
            return surface;
        }
    }
}