﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int gold = 500;
            Random ranumber = new Random();
            int squirrellevel = 1;
            string name;
            string winneris = "";
            string squirrel;
            int squirrelmaxhp = 100;
            double squirrelattack = 20;
            double squirrelspecial = 5;
            string move = "";
            string secondarymove;
            double squirrelbleed = 0;
            double squirreldamage = 1;
            double squirreldefence = 1;
            int speed = 1;
            bool winner = false;
            double damage;
            bool movevalid = false;
            int invdrugs = 0;
            int invteddy = 0;
            int invbandage = 0;
            int invmed = 0;
            

            //introduction

            Console.WriteLine("Welcome to... \nWhat is your name?");
            name = Console.ReadLine();
            Console.WriteLine("Hello {0}\nPress enter to begin", name);
            Console.ReadLine();
            Console.Clear();
            Thread.Sleep(2000);
            //Console.WriteLine("You look up from the ground \nYou're laying on a pile of boxes in a familiar looking alleyway with what looks like your squirrel companion asleep on your lap.\nWhat is their name?");
            squirrel = Console.ReadLine();
            /*
            Console.WriteLine("Your friend James runs up to you\nJames - 'OMG, i heard what happened are you ok? What are you going to do about the people that took over " +
                "your animal fighting business?'\nYou - 'I will have to get it back then'\nJames takes you and {0} back to his appartment till the morning", squirrel);
            Thread.Sleep(10000);
            Console.Clear();
            Console.WriteLine("In the morning you notice theres a note from James on the table which reads 'Hey {0}, I need to go out of the city for a while, you can use my " +
                "appartment for as long as you need'", name);
            */
            bool gamefinish = false;
            while (gamefinish == false)
            {
                Console.WriteLine("You have {0} gold, would you like to visit the shop \n 1 - Yes \n 2 - No", gold);
                string visitshop = Console.ReadLine();
                if (visitshop == "1")
                {
                    Console.WriteLine("You decided to visit the shop");

                }





                bool fightfinish = false;
                while (fightfinish == false)
                {
                    //first fight
                    int enemyspeed = 1;
                    double enemydamage = 1;
                    double enemydefence = 1;
                    string enemyname1 = "daniel";
                    string enemy1 = "cat";
                    double enemybleed = 0;
                    double enemyhp = 100;
                    bool teddyactive = false;
                    int test;
                    double enemyattack = 20;
                    double squirrelhp = squirrelmaxhp;

                    while (winner == false)
                    {

                        //your move

                        int speedcount = speed;
                        do
                        {

                            while (movevalid == false)
                            {
                                Console.WriteLine("\nIt's your turn \n\nWhat do you want {0} to do? \n 1 - attack \n 2 - special \n 3 - distract \n 4 - use item", squirrel);
                                move = Console.ReadLine();
                                test = Convert.ToInt32(move);
                                if (test == 1)
                                {
                                    movevalid = true;
                                }
                                else if (test == 2)
                                {
                                    movevalid = true;
                                }
                                else if (test == 3)
                                {
                                    movevalid = true;
                                }
                                else if (test == 4)
                                {
                                    movevalid = true;
                                }
                                else
                                {
                                    Console.WriteLine(" - Invalid input - ");
                                }
                            }
                            movevalid = false;

                            if (move == "1")
                            {
                                enemyhp = enemyhp - 20;
                                Console.WriteLine("you dealt {2} damage to {0} \n{0} has {1} health left", enemy1, enemyhp, squirrelattack);
                            }
                            else if (move == "2")
                            {
                                enemyhp = enemyhp - 5;
                                enemybleed = enemybleed + 1;
                                Console.WriteLine("You dealt {1} damage to {0} \n {0} has started to bleed", enemy1, squirrelspecial);
                            }
                            else if (move == "3")
                            {

                                teddyactive = true;
                                Console.WriteLine("You used a teddy to replace your animal");
                            }
                            else if (move == "4")
                            {
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
                                    if (squirrelbleed > 0)
                                    {
                                        squirrelbleed = 0;
                                        Console.WriteLine("{0} stopped bleeding");
                                    }
                                    else
                                    {
                                        Console.WriteLine("it did nothing");
                                    }
                                }
                                else if (secondarymove == "3")
                                {
                                    int mybuff = ranumber.Next(1, 4);
                                    if (mybuff == 1)
                                    {
                                        squirreldamage = squirreldamage + 0.5;
                                        Console.WriteLine("{0}'s damage was increased", squirrel);
                                    }
                                    else if (mybuff == 2)
                                    {
                                        squirreldefence = squirreldefence + 0.5;
                                        Console.WriteLine("{0}'s defence was increased", squirrel);
                                    }
                                    else if (mybuff == 3)
                                    {
                                        speed = speed + 1;
                                        Console.WriteLine("{0}'s speed was increased", squirrel);
                                    }
                                }
                            }
                            if (squirrelbleed > 0)
                            {
                                squirrelhp = squirrelhp - 5 * squirrelbleed;
                                Console.WriteLine("{0} took {1} damage from bleed", squirrel, squirrelbleed * 5); ;
                                squirrelbleed = squirrelbleed + 1;
                            }
                            if (enemybleed > 0)
                            {
                                enemyhp = enemyhp - 5 * enemybleed;
                                Console.WriteLine("{0} took {1} damage from bleed", enemy1, enemybleed * 5);
                                enemybleed = enemybleed + 1;
                            }

                            if (squirrelhp < 1)
                            {
                                winner = true;
                                winneris = enemyname1;
                            }
                            else if (enemyhp < 1)
                            {
                                winner = true;
                                winneris = name;
                            }
                            speedcount--;
                            if (winner == true)
                            {
                                speedcount = 0;
                            }
                        }
                        while (speedcount > 0);

                        //enemy move
                        if (winner == false)
                        {
                            int enemyspeedcount = enemyspeed;
                            do
                            {
                                Console.WriteLine("\nIt's {0}'s turn \n", enemyname1);
                                int enemymove = ranumber.Next(1, 4);
                                if (enemymove == 1)
                                {
                                    int enemybuff = ranumber.Next(1, 4);
                                    if (enemybuff == 1)
                                    {
                                        enemydamage = enemydamage + 0.5;
                                        Console.WriteLine("{0}'s damage was increased", enemy1);
                                    }
                                    else if (enemybuff == 2)
                                    {
                                        enemydefence = enemydefence + 0.5;
                                        Console.WriteLine("{0}'s defence was increased", enemy1);
                                    }
                                    else if (enemybuff == 3)
                                    {
                                        enemyspeed = enemyspeed + 1;
                                        Console.WriteLine("{0}'s speed was increased", enemy1);
                                    }
                                }
                                else
                                {
                                    if (teddyactive == false)
                                    {
                                        damage = enemyattack * enemydamage / squirreldefence;
                                        Console.WriteLine("{0} attacked {1} \n{0} dealt {2} damage", enemy1, squirrel, damage);
                                        squirrelhp = squirrelhp - damage;
                                    }
                                    else if (teddyactive == true)
                                    {
                                        Console.WriteLine("{0} attacked the teddy and destroyed it");
                                        teddyactive = false;
                                    }
                                }
                                if (squirrelbleed > 0)
                                {
                                    squirrelhp = squirrelhp - 5 * squirrelbleed;
                                    Console.WriteLine("{0} took {1} damage from bleed", squirrel, squirrelbleed * 5); ;
                                    squirrelbleed = squirrelbleed + 1;
                                }
                                if (enemybleed > 0)
                                {
                                    enemyhp = enemyhp - 5 * enemybleed;
                                    Console.WriteLine("{0} took {1} damage from bleed", enemy1, enemybleed * 5);
                                    enemybleed = enemybleed + 1;
                                }
                                if (squirrelhp < 1)
                                {
                                    winner = true;
                                    winneris = enemy1;
                                    enemyspeedcount = 0;
                                }
                                else if (enemyhp < 1)
                                {
                                    winner = true;
                                    winneris = name;
                                    enemyspeedcount = 0;
                                }
                                else
                                {
                                    Console.WriteLine("{0} has {1} health left", squirrel, squirrelhp);
                                }
                                enemyspeedcount = enemyspeedcount - 1;
                            }
                            while (enemyspeedcount > 0);
                        }
                    }
                    if (winneris == name)
                    {

                        squirrellevel = squirrellevel + 1;
                        Console.WriteLine("You won and earned 500 gold \n{0} leveled up to level {1}", squirrel, squirrellevel);
                    }
                    else if (winneris == enemy1)
                    {
                        Console.WriteLine("You lost \n\nWould you like to restart? \n 1 - Yes \n 2 - No");
                        string restart;
                        restart = Console.ReadLine();
                        if (restart == "1")
                        {
                            continue;
                        }
                        else if (restart == "2")
                        {
                            break;
                        }
                    }


                    winner = false;
                }
            }
        }
    }
}