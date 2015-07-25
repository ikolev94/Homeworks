using System;

namespace Problem_2.Fraction_Calculator
{
    public struct Fraction
    {
        private long numerator;
        private long denomerator;

        public Fraction(long numerator, long denomerator)
            : this()
        {
            this.Denomerator = denomerator;
            this.Numerator = numerator;
            
        }
        public long Numerator
        {
            get { return this.numerator; }
            set{this.numerator = value;}
        }
        public long Denomerator
        {
            get { return this.denomerator; }
            set
            {
                if (value==0)
                {
                    throw new ArgumentException("Denomerator cannot be zero");
                }
                this.denomerator = value;
            }
        }

        public static Fraction operator +(Fraction f1, Fraction f2)
        {
            long num = f1.numerator * f2.denomerator +
            f2.numerator * f1.denomerator;
            long deno = f1.Denomerator * f2.Denomerator;
            
            return new Fraction(num,deno);
        }
        public static Fraction operator -(Fraction f1, Fraction f2)
        {
            long num = f1.numerator * f2.denomerator -
                f2.numerator * f1.denomerator;
            long denom = f1.denomerator * f2.denomerator;

            return new Fraction(num, denom);
        }

        public override string ToString()
        {
            double result = ((double)this.Numerator/this.Denomerator);
            return result.ToString();
        }
    }
}