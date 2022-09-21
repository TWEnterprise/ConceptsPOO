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
Console.WriteLine(employee);

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
Console.WriteLine(employee1);



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
