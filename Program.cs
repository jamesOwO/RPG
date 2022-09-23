using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            Console.WriteLine("Welcome to... \nWhat is your name?");
            name = Console.ReadLine();
            Console.WriteLine("Hello {0}\nPress enter to begin", name);
            Console.ReadLine();
            Console.Clear();
            Thread.Sleep(2000);
            Console.WriteLine("BAanng");
            Thread.Sleep(2000);
        }
    }
}