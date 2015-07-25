using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterestCalculator;

namespace Interest_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<decimal, decimal, int, decimal> simpmleFunc=GetSimpleInterest;
            Func<decimal, decimal, int, decimal> compaundFunc=GetCompoundInterest;

            var test=new IterestCalculator(500m,5.6m,10,compaundFunc);
            var test2=new IterestCalculator(2500m,7.2m,15,simpmleFunc);

            Console.WriteLine(test);
            Console.WriteLine(test2);
        }

        private static decimal GetSimpleInterest(decimal money, decimal interest, int years)
        {
            return money * (1 + (interest/100 * years));
        }
        private static decimal GetCompoundInterest(decimal money, decimal interest, int years)
        {
            return money * (decimal)Math.Pow((double)(1 + (interest / 100 / 12)), years * 12);
        }
    }
}
