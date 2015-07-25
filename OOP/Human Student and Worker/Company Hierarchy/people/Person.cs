using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company_Hierarchy.people
{
     abstract class Person : Interface1
    {
        private string fName;
        private string lName;
        private int id;

        public Person(string firstName, string LastName, int id)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = LastName;
        }

        public string FirstName { get; set; }
        public int Id
        {
            get { return this.id; }
            set
            {
                if (value<0)
                {
                    throw new AggregateException("Id must be positive number");
                }
                this.id = value;
            }
        }
        public string LastName { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1} is a {2}", this.FirstName, this.LastName, GetType().Name);
        }
    }
}
