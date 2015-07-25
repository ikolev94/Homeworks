using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human_Student_and_Worker
{
    public class Human
    {
        private string firstName;
        private string lastName;

        public Human(string first,string last)
        {
            this.FirstName = first;
            this.LastName = last;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public override string ToString()
        {
            return string.Format("name:{0} last:{1}", this.FirstName, this.LastName);
        }
    }
}
