﻿using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            string squirrel;
            int squirrelmaxhp = 100;
            int squirrelhp = 100;
            

            Console.WriteLine("Welcome to... \nWhat is your name?");
            name = Console.ReadLine();
            Console.WriteLine("Hello {0}\nPress enter to begin", name);
            Console.ReadLine();
            Console.Clear();
            Thread.Sleep(2000);
            Console.WriteLine("You look up from the ground \nYou're laying on a pile of boxes in a familiar looking alleyway with what looks like your squirrel companion " +
                "asleep on your lap.\nWhat is their name?");
            squirrel = Console.ReadLine();
            Console.WriteLine("Your friend James runs up to you\nJames - 'OMG, i heard what happened are you ok? What are you going to do about the people that took over " +
                "your animal fighting business?'\nYou - 'I will have to get it back then'\nJames takes you and {0} back to his appartment till the morning", squirrel);
            Thread.Sleep(10000);
            Console.Clear();
            Console.WriteLine("In the morning you notice theres a note from James on the table which reads 'Hey {0}, I need to go out of the city for a while, you can use my " +
                "appartment for as long as you need'", name);

            

            
        }
    }
}