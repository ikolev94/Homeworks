using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank_of_Kurtovo_Konare.Interfaces;

namespace Bank_of_Kurtovo_Konare.Accounts
{
    abstract class Account:IAccound
    {
        private ICustomer customer;
        private decimal balance;
        private decimal intertrestRate;

        protected Account(ICustomer customer,decimal balance,decimal interestRate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }

        public void Deposit(decimal money)
        {
            if (money<0)
            {
                throw new ArgumentNullException("money","Deposit cannot be negative");
            }
            this.Balance += money;
        }

        public ICustomer Customer 
        {
            get { return this.customer; }
            set { this.customer = value; }
        }
        public decimal Balance { get; set; }
        public decimal InterestRate { get; set; }
        public abstract string CalculateInterestrate(int months);

        public override string ToString()
        {
            return String.Format("Account Type: {0}\nAccount Holder: {2} - {1}\nBalance: {3}\nInterest Rate: {4}%\n",
                this.GetType().Name,
                this.Customer.GetType().Name,
                this.Customer.Name,
                this.Balance.ToString("C2", CultureInfo.CreateSpecificCulture("bg-BG")),
                this.InterestRate * 100);
        }
    }
}
