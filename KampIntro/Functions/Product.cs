using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double UnitPrice { get; set; }
        public string Description { get; set; }

        public Product() { }

        public Product(int id, string name, double unitPrice,string Description)
        {
            this.Id = id;
            this.Name = name;
            this.UnitPrice = unitPrice;
            this.Description = Description;

        }
        

    }
}
