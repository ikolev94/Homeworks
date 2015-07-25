using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company_Hierarchy
{
    class Project
    {
        public Project(string name, DateTime date, string details, string state)
        {
            this.Name = name;
            this.StartDate = date;
            this.Details = details;
            this.State = state;
        }
        string Name { get; set; }
        DateTime StartDate { get; set; }
        string Details { get; set; }
        string State { get; set; }

        public void CloseProject()
        {
            this.State = "Closesd";
        }
    }
}
