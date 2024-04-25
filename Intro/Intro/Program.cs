// See https://aka.ms/new-console-template for more information
using Intro.Business;
using Intro.DataAccess.Concreets;
using Intro.Entities;

Console.WriteLine("Hello, World!");

string message = "Credits";
int number = 0;
double amont = 10000;

//variables --> camelCase
bool isAuthenticated = false; // true
Console.WriteLine(message);

//condition
if (isAuthenticated)
{
    Console.WriteLine("It is true");
}
else
{
    Console.WriteLine("It is false");
}

string[] loans = { "test1", "test2" };

for (int i = 0; i < loans.Length; i++)
{
    Console.WriteLine(loans[i]);
}



CourseManager courseManager = new (new CourseDal());
List<Course> courses2 = courseManager.GetAll();
for (int i = 0; i < courses2.Count; i++)
{
    Console.WriteLine(courses2[i].Name + " / " + courses2[i].Description);
}




Console.WriteLine("The End");

IndividualCustomer customer1 =  new IndividualCustomer();
customer1.Id = 1;
customer1.NationalIdentity = "12345";
customer1.FirstName = "Zehra";
customer1.LastName = "Pamuk";
customer1.CustomerNumber = "123";

IndividualCustomer customer2 = new IndividualCustomer();
customer2.Id = 2;
customer2.NationalIdentity = "345";
customer2.FirstName = "Pamuk";
customer2.LastName = "Zehra";
customer2.CustomerNumber = "783";

CoorporateCustomer customer3 = new CoorporateCustomer();
customer3.Id = 3;
customer3.Name = "CodeCamp";
customer3.CustomerNumber = "980";
customer3.TaxNumber = "987743";

CoorporateCustomer customer4 = new CoorporateCustomer();
customer4.Id = 4;
customer4.Name = "Abc";
customer4.CustomerNumber = "87766";
customer4.TaxNumber = "7543";


BaseCustomer[] customers = {customer1, customer2, customer3, customer4};

//polymorphism
foreach (BaseCustomer customer in customers)
{
    Console.WriteLine(customer.CustomerNumber);
}


