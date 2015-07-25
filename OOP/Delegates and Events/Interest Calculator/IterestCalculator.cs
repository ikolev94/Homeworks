using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterestCalculator
{
    class IterestCalculator
    {
        private decimal money;
        private decimal interest;
        private int years;

        public IterestCalculator(decimal money,decimal interest,int years,Func<decimal,decimal,int,decimal> func )
        {
            this.Money = money;
            this.Interest = interest;
            this.Years = years;
            this.Result = func(money, interest, years);
        }

        public decimal Money 
        { get { return this.money; }
            set
            {
                if (value<0)
                {
                    throw new ArgumentOutOfRangeException("value" ,"Value cannot be negative");
                }
                this.money = value;
            }
        }
        public decimal Interest
        {
            get { return this.interest; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("value", "Value cannot be negative");
                }
                this.interest = value;
            }
        }
        public int Years
        {
            get { return this.years; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("value", "Value cannot be negative");
                }
                this.years = value;
            }
        }

        public decimal Result { get; set; }

        public override string ToString()
        {
            return string.Format("Money: {0}, Interest: {1}%, Years: {2}, Result: {3:F4}", this.Money, this.Interest,
                this.Years, this.Result);
        }
    }
}
