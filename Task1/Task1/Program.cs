using System;
using Task2;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1
            Console.WriteLine("Task 1:");
            Console.WriteLine("Please type your name and hit enter:");
            string input = Console.ReadLine();
            Console.WriteLine($"Hello, {input}");


            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            //Task 2
            Console.WriteLine("Task 2:");

            Class1 class1 = new Class1();
            class1.SayHello(input);

            Console.ReadLine();
        }
    }
}
