using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer
{
    internal class Customer:ICloneable,IComparable<Customer>
    {
        
        public Customer(string name ,string secondName,string lastName,string id,string addres,string phone,string email,List<Payment>payments,CustomerType customerTypes  )
        {
            this.Name = name;
            this.Sname = secondName;
            this.LastName = lastName;
            this.Id = id;
            this.Address = addres;
            this.Phone = phone;
            this.Email = email;
            this.Payments = payments;
            this.CustomerTypes = customerTypes;
        }

        public string Name { get; set; }
        public string Sname { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Id { get; set; }
        public string Email { get; set; }
        public List<Payment> Payments { get; set; }
        public CustomerType CustomerTypes { get; set; }

        public override bool Equals(object other)
        {
            if (other != null && other is Customer)
            {
                var otherCustomer = (Customer)other;
                if (this.Id == otherCustomer.Id)
                {
                    return true;
                }
            }

            return false;
        }

        public override int GetHashCode()
        {
            return this.Name.GetHashCode() ^ this.Address.GetHashCode();
        }


        public object Clone()
        {
            return new Customer(this.Name, this.Sname, this.LastName, this.Id,
               this.Address, this.Phone, this.Email, new List<Payment>(this.Payments),
               this.CustomerTypes);
        }

        public int CompareTo(Customer other)
        {

            string fullName = string.Format("{0} {1} {2}",
            this.Name, this.Sname, this.LastName);
            string otherFullName = string.Format("{0} {1} {2}",
                other.Name,
                other.Sname,
                other.LastName);
            if (fullName.CompareTo(otherFullName) != 0)
            {
                return fullName.CompareTo(otherFullName);
            }

            return this.Id.CompareTo(other.Id);
        }

        public override string ToString()
        {
            return String.Format("name: {0}, last name: {1}",this.Name,this.LastName);
        }

        public static bool operator ==(Customer customer1, Customer customer2)
        {
            return Customer.Equals(customer1, customer2);
        }
        public static bool operator !=(Customer customer1, Customer customer2)
        {
            return !(Customer.Equals(customer1, customer2));
        }

        
    }
}

    
