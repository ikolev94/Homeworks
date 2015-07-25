using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company_Hierarchy.people;

namespace Company_Hierarchy
{
    interface IManager
    {
        List<Employee> Employees { get; set; }
    }
}
