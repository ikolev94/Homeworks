using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company_Hierarchy.people
{
    class Developer:Person,IDeveloper
    {
        private List<Project> projects; 
        public Developer(string firstName, string LastName, int id,List<Project> projects ) : base(firstName, LastName, id)
        {
            this.Projects = projects;
        }

        public List<Project> Projects { get; set; }
    }
}
