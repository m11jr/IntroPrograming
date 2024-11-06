using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");

            Console.WriteLine("I am " + (2024 - 2005) + " Years Old");
            Console.WriteLine("I am {0} Years Old",2024-2005);
            Console.WriteLine($"I am {2024-2005} years old");
            Console.WriteLine($" This is \\ and this is \" ");
            Console.Write("hello");
            Console.WriteLine("\nThis is My World");
            Console.WriteLine("***********************");
            Console.WriteLine("Name \t \t Surname");
            Console.WriteLine("Alinur \t \t Mammadzada");
            Console.WriteLine("Alinur \t \t Mammadzada");
            Console.WriteLine(" I am from \bPoland");
            //\b helps you to delete the last letter before itself
            Console.WriteLine("This is an alarm \a");

        }
    }
}
