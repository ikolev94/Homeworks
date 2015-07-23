namespace Abstraction
{
    using System;

    internal abstract class Figure
    {
        private double height;

        private double widht;

        protected Figure(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width
        {
            get
            {
                return this.widht;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Size cannot be negative");
                }

                this.widht = value;
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Size cannot be negative");
                }

                this.height = value;
            }
        }

        public abstract double CalcPerimeter();

        public abstract double CalcSurface();
    }
}