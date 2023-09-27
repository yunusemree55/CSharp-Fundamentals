using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankDemo
{
    public class Customer
    {

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string IdentityNumber { get; set; }

        public Customer() { }

        public Customer(int ıd, string firstName, string lastName, string ıdentityNumber)
        {
            Id = ıd;
            FirstName = firstName;
            LastName = lastName;
            IdentityNumber = ıdentityNumber;
        }
    }
}
