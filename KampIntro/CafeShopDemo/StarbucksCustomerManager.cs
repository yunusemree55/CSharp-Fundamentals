using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeShopDemo
{
    public class StarbucksCustomerManager : ICustomerService
    {
        private MernisAdapterService mernisAdapterService;

        public StarbucksCustomerManager(MernisAdapterService mernisAdapterService)
        {
            this.mernisAdapterService = mernisAdapterService;
        }

        public void Add(Customer customer)
        {
            var d = mernisAdapterService.IsRealPerson(customer);

            if(d == null)
            {
            Console.WriteLine($"{customer.FirstName} {customer.LastName} Starbucks Sistemine kaydedildi!");

            }

        }
    }
}
