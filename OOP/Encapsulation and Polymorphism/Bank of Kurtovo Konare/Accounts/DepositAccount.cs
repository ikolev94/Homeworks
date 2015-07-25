using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank_of_Kurtovo_Konare.Interfaces;

namespace Bank_of_Kurtovo_Konare.Accounts
{
    class DepositAccount:Account
    {
        public DepositAccount(ICustomer customer, decimal balance, decimal interestRate) : base(customer, balance, interestRate)
        {
        }

        public void Withdraw(decimal money)
        {
            if (money<0)
            {
                throw  new ArgumentNullException("money","Withdraw cannot be null");
            }
            else if (this.Balance-money<0)
            {
                throw new ArgumentNullException("money","Withdraw is biger than balance");
            }
            this.Balance -= money;
        }
        public override string CalculateInterestrate(int months)
        {
            decimal interest = 0;
            if (this.Balance>=1000)
            {
                interest = this.Balance*(1 + this.InterestRate*months);
            }
            return interest.ToString("C2", CultureInfo.CreateSpecificCulture("bg-BG"));
        }
    }
}
