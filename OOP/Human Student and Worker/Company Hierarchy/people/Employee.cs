using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company_Hierarchy.people
{
    class Employee:Person,IEmployee
    {
        private decimal salary;
        private string department;

        public Employee(string firstName, string LastName, int id, decimal salary, Departament departament)
            : base(firstName, LastName, id)
        {
            this.Departament = departament;
            this.Salary = salary;
        }

        public Departament Departament { get; set; }
        public decimal Salary { get; set; }
    }
}
