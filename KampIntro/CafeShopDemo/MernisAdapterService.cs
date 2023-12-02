using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeShopDemo
{
    public interface MernisAdapterService
    {
        Task<bool> IsRealPerson(Customer customer);
    }
}
