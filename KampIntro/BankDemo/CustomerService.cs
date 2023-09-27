using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankDemo
{
    public class CustomerManager
    {
        private List<Customer> _customerList;

        public CustomerManager()
        {
            _customerList = new List<Customer>()
            {
                new Customer(1,"Yunus Emre","Çiçek","12312312312"),
                new Customer(2, "Enes Emir", "Çiçek", "98723456712"),

            };
        }

        public void Add(Customer customer)
        {
            Console.WriteLine($"{customer.FirstName} {customer.LastName} is added to system");
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine($"{customer.FirstName} {customer.LastName} is deleted from system");
        }

        public List<Customer> GetAll()
        {
            return _customerList;

        }

    }
}
