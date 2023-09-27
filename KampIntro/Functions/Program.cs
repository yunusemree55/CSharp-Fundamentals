
using Functions;

Product product1 = new Product(1,"Apple",20,"Unique");
Product product2 = new Product(2, "Watermelon", 80, "Special grown");

List<Product> products = new List<Product>() { product1,product2 };

CartManager cartManager = new CartManager();

foreach (Product product in products)
{
    cartManager.AddToCart(product);
}


