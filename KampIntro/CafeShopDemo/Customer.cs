using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeShopDemo
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string NationalIdentity { get; set; }

        public int YearOfBirth { get; set; }


        public Customer()
        {
            
        }

        public Customer(int Id,string FirstName,string LastName,string NationalIdentity, int YearOfBirth)
        {
            this.Id = Id;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.NationalIdentity = NationalIdentity;
            this.YearOfBirth = YearOfBirth;
        }





    }
}
