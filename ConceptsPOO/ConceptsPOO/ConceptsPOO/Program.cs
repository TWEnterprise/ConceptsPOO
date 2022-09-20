// See https://aka.ms/new-console-template for more information

using ConceptsPOO;
using System.Net.WebSockets;

Console.WriteLine("Concepts POO!");
Console.WriteLine("=============");

try
{

	Console.WriteLine(new Date(2024, 2, 29));
	Console.WriteLine(new Date(2021, 9, 23));
	Console.WriteLine(new Date(2020, 11, 31));

}
catch (Exception ex)
{

    Console.WriteLine(ex.Message);
}
