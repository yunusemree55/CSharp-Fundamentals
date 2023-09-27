using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    public class CartManager
    {
        public void AddToCart(Product product)
        {
            
            Console.WriteLine($"{product.Name} adlı ürün sepete eklendi");
        }

    }
}
