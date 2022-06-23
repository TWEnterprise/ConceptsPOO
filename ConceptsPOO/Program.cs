using System;

namespace ConceptsPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Employee employee1 = new SalaryEmployee()
            {
                Id = 1010,
                FirstName = "sandra",
                LastName = "morales",
                BirthDate = new Date(1990, 5, 23),
                HiringDate = new Date(2022, 1, 15),
                IsActive = true,
                Salary = 1815453.45M
            };
            Console.WriteLine(employee1);
            Employee employee2 = new CommissionEmployee()
            {
                Id = 2020,
                FirstName = "Patricia",
                LastName = "Gutierrez",
                BirthDate = new Date(1995, 5, 23),
                HiringDate = new Date(2022, 2, 5),
                IsActive = true,
                Sales= 320000000M,
                CommissionPercentaje= 0.03F
            };
            Console.WriteLine(employee2);

            //try
            //{
            //    Console.WriteLine(new Date(2022, 12, 7));
            //    Console.WriteLine(new Date(1974, 9, 23));
            //    Console.WriteLine(new Date(2022, 11, 30));
            //}
            //catch ( Exception ex)
            //{
            //    Console.WriteLine(ex.Message);

            //}
        }
    }
}
