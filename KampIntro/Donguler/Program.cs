

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine("Veri Gönderiliyor : " + i);
    
}

Console.WriteLine("--------------------------");

List<string> courseList = new List<string>() {"C#","Java","Python" };


for (int i = 0; i < courseList.Count; i++)
{
    Console.WriteLine("Kurs ismi : " + courseList[i]);
}

Console.WriteLine("--------------------------");

foreach (string course in courseList)
{
    Console.WriteLine(course);
}

int number = 0;

while (number < 10)
{
    Console.WriteLine("Yazdır: " + number);
    number++;
}