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
    class LoanAccount:Account
    {
        public LoanAccount(ICustomer customer, decimal balance, decimal interestRate) : base(customer, balance, interestRate)
        {
        }

        public override string CalculateInterestrate(int months)
        {
            decimal interest = this.Balance*(1+this.InterestRate*months);
            if (this.Customer is Individual)
            {
                if (months<=3)
                {
                    interest = 0;
                }
                else
                {
                    months -= 3;
                    interest = this.Balance*(1 + InterestRate*months);
                }
            }
            else if (this.Customer is Company)
            {
                if (months<=2)
                {
                    interest = 0;
                }
                else
                {
                    months -= 2;
                    interest = this.Balance*(1 + this.InterestRate*months);
                }
            }
            return interest.ToString("C2", CultureInfo.CreateSpecificCulture("bg-BG"));
        }
    }
}
