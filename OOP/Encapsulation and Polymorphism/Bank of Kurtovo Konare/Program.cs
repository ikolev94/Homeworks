using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Bank_of_Kurtovo_Konare.Accounts;
using Bank_of_Kurtovo_Konare.Customer;

namespace Bank_of_Kurtovo_Konare
{
    class Program
    {
        static void Main(string[] args)
        {
            Individual kiro = new Individual("Kiro");
            Individual ivan = new Individual("Ivan");
            Company sap = new Company("SAP");
            
            DepositAccount kiroAccount=new DepositAccount(kiro,1112,0.2m);
            LoanAccount ivanAccount = new LoanAccount(ivan,2222,0.29m);
            MortgageAccount sapAccount = new MortgageAccount(sap,3333,0.23m);

            List<Account> accounts = new List<Account>()
            {
                kiroAccount,
                ivanAccount,
                sapAccount
            };
            foreach (var account in accounts)
            {
                Console.WriteLine(account);
            }

            Console.WriteLine(kiroAccount.CalculateInterestrate(4));
            Console.WriteLine(sapAccount.CalculateInterestrate(55));
            sapAccount.Deposit(4141);
            kiroAccount.Withdraw(333);

            foreach (var account in accounts)
            {
                Console.WriteLine(account);
            }
            
        }
    }
}
