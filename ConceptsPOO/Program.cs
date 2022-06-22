using System;

namespace ConceptsPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            try
            {
                Console.WriteLine(new Date(2022, 12, 7));
                Console.WriteLine(new Date(1974, 9, 23));
                Console.WriteLine(new Date(2022, 11, 30));
            }
            catch ( Exception ex)
            {
                Console.WriteLine(ex.Message);
                
            }
        }
    }
}
