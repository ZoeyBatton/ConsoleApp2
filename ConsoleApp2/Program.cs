using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string name;
            string favPet;

            Console.WriteLine("Hello, what is your name?");
            name = Console.ReadLine();

            Console.WriteLine($"Hi {name}, what is your favorite animal?");
            favPet = Console.ReadLine();

            if (favPet == "cat"){
                Console.WriteLine("Good, cats are obviously the superior pets.");

            }
            else if (favPet == "Cat")
            {
                Console.WriteLine("Good, cats are obviously the superior pets.");

            }
            else
            {
                Console.WriteLine("Wrong answer. Cats are better.");
            }
            Console.ReadKey();
        }
    }
}
