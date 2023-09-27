

using BankDemo;

CustomerManager customerManager = new CustomerManager();

foreach (Customer customer in customerManager.GetAll())
{
    Console.WriteLine($"{customer.FirstName} {customer.LastName}");
}

Customer customer1 = new Customer(3, "Ali Haydar", "Turgut", "32132132132");
Customer customer2 = new Customer(4,"Nedim","Görgü","12345678912");

customerManager.Add(customer1);
customerManager.Delete(customer2);