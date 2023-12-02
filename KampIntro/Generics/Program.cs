


using Generics;

MyList<string> countries = new MyList<string>();


countries.Add("Almanya");
countries.Add("Rusya");


foreach (var country in countries.GetAll())
{
    Console.WriteLine(country);
}