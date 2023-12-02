using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    public class CorporateCustomer : Customer
    {

        
        public string CompanyName { get; set; }
        public string TaxNo { get; set; }

        public CorporateCustomer() 
        {
        
        }

        public CorporateCustomer(int id, string customerNo, string companyName, string taxNo) : base(id, customerNo)
        {
            CompanyName = companyName;
            TaxNo = taxNo;
        }
    }
}
