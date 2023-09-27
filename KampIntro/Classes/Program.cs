
Customer customer1 = new Customer();

customer1.id = 1;
customer1.firstName = "Yunus Emre";
customer1.lastName = "Çiçek";
customer1.email = "ye@gmail.com";

Customer customer2 = new Customer(2,"John","Smith","js@gmail.com");

List<Customer> customerList = new List<Customer>() { customer1,customer2 };

foreach (var customer in customerList)
{
    Console.WriteLine($"Müşteri adı soyadı: {customer.firstName} {customer.lastName}");
}

int isLogin = 1;

Console.WriteLine("----------------------");

switch (isLogin)
{
    case 0:
        Console.WriteLine("Giriş Yap Butonu");
        break;
    case 1:
        Console.WriteLine("Profilim Butonu");
        break;
    default:
        break;
}


class Customer
{
    public int id { get; set; }
    public string firstName { get; set; }
    public string lastName { get; set; }
    public string email { get; set; }

    public Customer() { }

    public Customer(int id, string firstName, string lastName, string email)
    {
        this.id = id;
        this.firstName = firstName;
        this.lastName = lastName;
        this.email = email;
    }
}


