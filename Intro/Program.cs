
using Intro.Business;
using Intro.Entities;

Console.WriteLine("Hello, World!");

string message1 = "Krediler";
int term = 12;
double amount = 1000;


//variables --> camelCase
bool isAuthenticated = true;
Console.WriteLine(message1);

//condition
if(isAuthenticated)
{
    Console.WriteLine("Hoşgeldin.");
}
else
{
    Console.WriteLine("Sisteme giriş yap.");
}

string[] loans = { "Kredi 1", "Kredi 2", "Kredi 3", "Kredi 4", "Kredi 5" };

for (int i = 0; i < loans.Length; i++)
{
    Console.WriteLine(loans[i]);
}

CourseManager courseManager = new();
Course[] courses2 = courseManager.GetAll();

for (int i = 0; i < courses2.Length; i++)
{
    Console.WriteLine(courses2[i].Name + " / " + courses2[i].Price);
}


Console.WriteLine("Kodlar bitti.");