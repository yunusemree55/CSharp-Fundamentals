using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeShopDemo
{
    public class MernisAdapterManager : MernisAdapterService
    {
        public async Task<bool> IsRealPerson(Customer customer)
        {
            Mernis.KPSPublicSoapClient mernis = new Mernis.KPSPublicSoapClient();
            
            var validate =await mernis.TCKimlikNoDogrulaAsync(Convert.ToInt64(customer.NationalIdentity), customer.FirstName.ToUpper(), customer.LastName.ToUpper(), customer.YearOfBirth);
            bool result = validate.Body.TCKimlikNoDogrulaResult;
            return result;
        }
    }
}
