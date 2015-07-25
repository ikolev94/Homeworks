using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank_of_Kurtovo_Konare.Customer;
using Bank_of_Kurtovo_Konare.Interfaces;

namespace Bank_of_Kurtovo_Konare.Accounts
{
    class MortgageAccount:Account
    {
        public MortgageAccount(ICustomer customer, decimal balance, decimal interestRate) : base(customer, balance, interestRate)
        {
        }

        public override string CalculateInterestrate(int months)
        {
            decimal interest = this.Balance*(1 + this.InterestRate*months);
            if (Customer is Individual)
            {
                if (months<=6)
                {
                    interest = 0;
                }
                else
                {
                    months -= 6;
                    interest = this.Balance*(1 + this.InterestRate*months);
                }
            }
            else if (this.Customer is Company)
            {
                if (months<=12)
                {
                    interest*=0.5m;
                }
                else
                {
                    months -= 12;
                    interest = this.Balance*(1 + this.InterestRate*months);
                }
            }
            return interest.ToString("C2", CultureInfo.CreateSpecificCulture("bg-BG"));
        }
    }
}
