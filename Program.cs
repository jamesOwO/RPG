using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random ranumber = new Random();
            string name;
            string squirrel;
            int squirrelmaxhp = 100;
            int enemyhp = 100;
            string enemy = "cat";
            int squirrelhp = 100;
            string move;
            string secondarymove;
            bool myblock = false;
            bool squirrelbleed = false;
            bool enemyblock = false;
            bool enemybleed = false;
            Double damage = 1;
            Double defence = 1;
            Double speed = 1;
            bool winner = false;

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

             
            while (winner == false) {
                Console.WriteLine("What do you want {0} to do? \n 1 - attack \n 2 - special \n 3 - distract \n 4 - use item");
                move = Console.ReadLine();
                switch (move) {
                    case "1" || "attack":
                        enemyhp = enemyhp - 20;
                        Console.WriteLine("you dealt 20 damage to {0}", enemy);
                    case "2" || "special":
                        enemyhp = enemyhp - 5;
                        enemybleed = true;
                        Console.WriteLine("You dealt 5 damage to {0} \n {0} has started to bleed", enemy);
                    case "3" || "distract":
                        myblock = true;
                        Console.WriteLine("You used a teddy to replace your animal");
                    case "4" || "use item":
                        Console.WriteLine("What item would you like to use? \n 1 - medkit \n 2 - bandage \n 3 - drugs");
                        secondarymove = Console.ReadLine();
                        if (secondarymove == "1")
                        {
                            squirrelhp = squirrelhp + 50;
                            if (squirrelhp > squirrelmaxhp)
                            {
                                squirrelhp = 100;
                            }
                            Console.WriteLine("{0}'s hp was restored to {1} health", squirrel, squirrelhp);
                        }
                        else if (secondarymove == "2")
                        {
                            if (squirrelbleed == true)
                            {
                                squirrelbleed = false;
                                Console.WriteLine("{0} stopped bleeding");
                            }
                            else
                            {
                                Console.WriteLine("it did nothing");
                            }
                        }
                        else if (secondarymove == "3")
                        {
                            int ranumber = rnd.Next(1, 3);
                            if (ranumber == 1)
                            {
                                damage = damage + 1.5;
                                Console.WriteLine("{0}'s damage was increased", squirrel);
                            }
                            else if (ranumber == 2)
                            {
                                defence = defence + 1.5;
                                Console.WriteLine("{0}'s defence was increased", squirrel);
                            }
                            else if (ranumber == 3)
                            {
                                speed = speed + 1.5;
                                Console.WriteLine("{0}'s speed was increased", squirrel);
                            }


                        }
            }

            
        }
    }
}