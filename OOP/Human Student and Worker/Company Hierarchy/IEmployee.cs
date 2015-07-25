using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company_Hierarchy
{
    interface IEmployee
    {
        Departament Departament { get; set; }
        decimal Salary { get; set; }
    }
}
