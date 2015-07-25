using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company_Hierarchy.people
{
    class SalesEmployee:Person,ISalesEmployee
    {
        public SalesEmployee(string firstName, string LastName, int id,List<Sale> sales ) : base(firstName, LastName, id)
        {
            this.Sales = sales;
        }

        public List<Sale> Sales { get; set; }
    }
}
