using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    public class IndividualCustomer : Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string IdentityNumber { get; set; }

        public IndividualCustomer()
        {
        
        }

        public IndividualCustomer(int id, string customerNo,string firstName, string lastName, string identityNumber) : base(id,customerNo)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.IdentityNumber = identityNumber;
        }
        

    }
}
