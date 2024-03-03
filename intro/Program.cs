// See https://aka.ms/new-console-template for more information
using intro.Business;
using intro.Entities;

Console.WriteLine("Hello, World!");

string message1 = "Krediler";
int term = 12;
double amount = 100000;

//variables --> camelCase
bool isAuthenticated = true; // backendden gelen data 
Console.WriteLine(message1);

//condition - şart
if (isAuthenticated)//  isAuthenticated - isAuthenticated == true  ikiside aynı
{
    Console.WriteLine("Buton --> Hoşgeldin Mustafa");
}
else
{
    Console.WriteLine("Buton --> Sisteme Giriş Yap");
}

string[] loans ={"Kredi1", "Kredi2", "Kredi3", "Kredi4","Kredi5", "Kredi6"};
//Diğer Bir Yöntem
//string[] loans2 = new string[6];
//loans2[0] = "Kredi 1";
     //!  Start     Condition        increment
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

Console.WriteLine("Kod Bitti");

//inheritance bir sınıfı diğer sınıfın alt sınıfı yapıyor gibi..

IndividualCustomer customer1 = new IndividualCustomer();
customer1.Id = 1;
customer1.NationalIdentity = "12346579822";
customer1.FirstName = "Aslı";
customer1.LastName = "Karayiğit";
customer1.CustomerNumber = "123456";

IndividualCustomer customer2 = new IndividualCustomer();
customer2.Id = 2;
customer2.NationalIdentity = "5689889752";
customer2.FirstName = "Özgür";
customer2.LastName = "Atılgan";
customer2.CustomerNumber = "123457";

CorporateCustomer customer3 = new CorporateCustomer();
customer3.Id = 3;
customer3.Name = "Kodlamaio";
customer3.CustomerNumber = "654778";
customer3.TaxNumber = "12345678987";

CorporateCustomer customer4 = new CorporateCustomer();
customer4.Id = 4;
customer4.Name = "Abc";
customer4.CustomerNumber = "654779";
customer4.TaxNumber = "12345678988";

BaseCustomer[] customers = { customer1, customer2, customer3, customer4 };

//polymorphism

foreach (BaseCustomer customer in customers)
{
    Console.WriteLine(customer.CustomerNumber);
}

