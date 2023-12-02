
using OOP2;

IndividualCustomer individualCustomer1 = new IndividualCustomer(1,"1234567890","Yunus Emre","Çiçek","11223344");
CorporateCustomer corporateCustomer1 = new CorporateCustomer(2, "2345678910", "ABC Şirketi", "9988776633");

CustomerManager customerManager = new CustomerManager();

customerManager.Add(individualCustomer1);
customerManager.Add(corporateCustomer1);