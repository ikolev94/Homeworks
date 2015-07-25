using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_of_Kurtovo_Konare.Interfaces
{
    interface IAccound:IDeposit
    {
        ICustomer Customer { get; set; }
        decimal Balance { get; set; }
        decimal InterestRate { get; set; }

        string CalculateInterestrate(int months);

    }
}
