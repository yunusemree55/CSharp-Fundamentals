


using CafeShopDemo;

Customer customer1 = new Customer(1,"Yunus Emre","Çiçek","15398612858",2001);
StarbucksCustomerManager starbucksCustomerManager = new StarbucksCustomerManager(new MernisAdapterManager());

starbucksCustomerManager.Add(customer1);

