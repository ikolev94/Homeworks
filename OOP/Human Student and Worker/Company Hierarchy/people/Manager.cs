using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company_Hierarchy.people
{
    class Manager:Person,IManager
    {
        private List<string> employees; 
        public Manager(string firstName, string LastName, int id , List<Employee> employees ) : base(firstName, LastName, id)
        {
            this.Employees = employees;
        }

        public List<Employee> Employees { get; set; }
    }
}
