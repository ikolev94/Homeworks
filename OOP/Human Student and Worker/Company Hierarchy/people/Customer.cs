using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company_Hierarchy.people
{
    class Customer:Person
    {

        private decimal money;
        public Customer(string firstName, string LastName, int id,decimal money) : base(firstName, LastName, id)
        {
            this.Money = money;
        }

        public decimal Money
        {
            get
            {
                return this.money;
            }
            set
            {
                if (value >= 0)
                {
                    this.money = value;
                }
                else
                {
                    throw new ArgumentException("cannot be negative!");
                }
            }
        }
    }
    }

