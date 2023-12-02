

using Dictionaries;

Dictionary<string,string> englishDictionary = new Dictionary<string,string>();

englishDictionary.Add("Building", "Bina");
englishDictionary.Add("Desk", "Masa");


foreach (KeyValuePair<string,string> dictionary in englishDictionary)
{
    Console.WriteLine($"{dictionary.Key} : {dictionary.Value}");
}

MyDictionary<string,string> countries = new MyDictionary<string,string>();


countries.Add("Türkiye", "Ankara");
countries.Add("Almanya", "Berlin");


foreach (KeyValuePair<string,string> item in countries.GetAll())
{
    Console.WriteLine(item.Key + " => " + item.Value);
    Console.WriteLine(item.Key + " => " + item.Value);
}