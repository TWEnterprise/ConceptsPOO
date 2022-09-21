// See https://aka.ms/new-console-template for more information

using ConceptsPOO;
using System.Net.WebSockets;

Console.WriteLine("Concepts POO!");
Console.WriteLine("=============");

Employee employee = new SalaryEmployee()
{
    Id= 1010,
    FirstName = "Sandra",
    LastName= "Morales",
    BirthDate= new Date (1990, 5, 23),
    HiringDate= new Date (2022, 1, 15),
    IsActive=true,
    Salary= 1815453.45M
};
//Console.WriteLine(employee);

Employee employee1 = new CommissionEmployee()
{
    Id = 2020,
    FirstName = "Patricia",
    LastName = "Gutierrez",
    BirthDate = new Date(1995, 5, 23),
    HiringDate = new Date(2022, 2, 5),
    IsActive = true,
    Sale=320000000M,
    CommissionPercentaje= 0.03F
   
};
//Console.WriteLine(employee1);

Employee employee2 = new HourlyEmployee()
{
    Id = 3030,
    FirstName = "Gonzalo",
    LastName = "Carmona",
    BirthDate = new Date(1985, 5, 23),
    HiringDate = new Date(2022, 2, 5),
    IsActive = true,
    HourValue = 12356.56M,
    Hours = 123.5F
};
//Console.WriteLine(employee2);

Employee employee3 = new BaseCommissionEmployee()
{
    Id = 4040,
    FirstName = "Jazmin",
    LastName = "Salazar",
    BirthDate = new Date(1985, 5, 23),
    HiringDate = new Date(2022, 2, 15),
    IsActive = true,
    Base= 860678.45M,
    Sale= 58000000M,
    CommissionPercentaje= 0.015F
    
};
//Console.WriteLine(employee3);
ICollection<Employee> employees = new List<Employee>()
{
    employee, employee1, employee2, employee3
};
decimal payroll = 0;
foreach (Employee employe in employees)
{
    Console.WriteLine(employe);
    payroll += employe.GetValueToPay();
}
Console.WriteLine("                       =========================");
Console.WriteLine($"TOTAL                          {$"{payroll:C2}",15}");

Invoice invoice = new Invoice()
{
    Description = "iPhone 13",
    Id = 1,
    Price = 5300000M,
    Quantity = 6
};
Invoice invoice1 = new Invoice()
{
    Description = "Posta Preum",
    Id = 2,
    Price = 32000M,
    Quantity = 17.5F
};
Console.WriteLine(invoice);
Console.WriteLine(invoice1);

//try
//{

//	Console.WriteLine(new Date(2024, 2, 29));
//	Console.WriteLine(new Date(2021, 9, 23));
//	Console.WriteLine(new Date(2020, 11, 31));

//}
//catch (Exception ex)
//{

//    Console.WriteLine(ex.Message);
//}
