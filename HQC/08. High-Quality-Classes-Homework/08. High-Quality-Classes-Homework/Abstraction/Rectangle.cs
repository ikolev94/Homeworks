namespace Abstraction
{
    using System;

    public class Rectangle : IFigure
    {
        private double _width;

        private double _height;

        public Rectangle(double width, double height)
        {
            this.Height = height;
            this.Width = width;
        }

        public double Width
        {
            get
            {
                return this._width;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Width cannot be negative");
                }

                this._width = value;
            }
        }

        public double Height
        {
            get
            {
                return this._height;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Height cannot be negative");
                }

                this._height = value;
            }
        }

        public double CalcPerimeter()
        {
            double perimeter = 2 * (this.Width + this.Height);
            return perimeter;
        }

        public double CalcSurface()
        {
            double surface = this.Width * this.Height;
            return surface;
        }
    }
}