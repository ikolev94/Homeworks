using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company_Hierarchy.people;

namespace Company_Hierarchy
{
    internal class Program
    {
        private static void Main()
        {
            var employees = new List<Person>()
            {
                new Manager("Stefan", "Pop", 2324, new List<Employee>()
                {
                    new Employee("Uli", "Wehter", 122114, 3242,Departament.Accounting),
                    new Employee("Rex", "gex", 32445, 1000,Departament.Accounting),
                }),
                new SalesEmployee("Tata", "Lata", 5000, new List<Sale>()
                {
                    new Sale("PAPATA", new DateTime(), 999.11M )
                }),
                new Customer("Rege", "PLAVAM", 12345, 124.5M),
                new Developer("Ivan", "Radkov", 1999, new List<Project>()
                {
                    new Project("Proj", new DateTime(), "Test project","Open" )
                }),
                new Employee("Emply", "PLO", 468, 238, Departament.Production)
            };

            employees.ForEach(Console.WriteLine);
        }
    }
}
