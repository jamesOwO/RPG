﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;

namespace MyApp // Note: actual namespace depends on the project name.
{
    class Inventory
    {
        public int gold;
        public int med;
        public int drugs;
        public int bandage;
        public int teddy;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Inventory backpack = new Inventory();
            backpack.gold = 300;
            backpack.med = 0;
            backpack.drugs = 0;
            backpack.bandage = 0;
            backpack.teddy = 0;

            bool keepplaying = true;
            string restart = "";
            bool wingame = true;
            Random ranumber = new Random();
            int slimelevel = 1;
            string winneris = "";
            string slime;
            int slimemaxhp = 100;
            double slimeattack = 20;
            double slimespecial = 5;
            string move = "";
            string secondarymove;
            double slimebleed = 0;
            bool winner = false;
            double damage;
            bool movevalid = false;
            string shopitem = "";
            int itemprice = 0;
            bool enoughgold = false;

            //introduction

            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine("Welcome to my RPG \nWhat is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hello {0}\nPress enter to begin", name);
            Console.ReadLine();
            Console.Clear();
            Thread.Sleep(200);
            Console.WriteLine("You look up from the ground \nYou're laying on a pile of boxes in a familiar looking alleyway with what looks like a slime asleep on your lap.\nWhat would you like to name them?");
            slime = Console.ReadLine();

            Console.WriteLine("Your friend James runs up to you\nJames - 'OMG, i heard what happened are you ok? What are you going to do about the people that took over " +
                "your slime fighting business?'\nYou - 'I will have to get it back then'\nJames takes you and {0} back to his appartment till the morning", slime);
            Thread.Sleep(10000);
            Console.Clear();
            Console.WriteLine("In the morning you notice theres a note from James on the table which reads 'Hey {0}, I need to go out of the city for a while, you can use my " +
                "appartment for as long as you need'", name);
            Thread.Sleep(5000);
            Console.Clear();

            for (int round = 1; round <= 3; round++)
            {

                //shop


                if (keepplaying == true)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;

                    bool fightfinish = false;
                    while (fightfinish == false)
                    {

                        Console.WriteLine("You have {0} gold, would you like to visit the shop \n 1 - Yes \n 2 - No", backpack.gold);
                        string visitshop = Console.ReadLine();
                        if (visitshop == "1")
                        {
                            Console.WriteLine("You decided to visit the shop");
                            Thread.Sleep(500);
                            Console.Clear();
                            bool leaveshop = false;
                            while (leaveshop == false)
                            {
                                Console.WriteLine("You have {0} gold. \nWhat do you want to buy? \n 1 - medkit - 250G \n 2 - bandage - 50G \n 3 - a drug - 250G \n 4 - teddy 50G \n 5 - leave", backpack.gold);
                                string shopchoice = Console.ReadLine();
                                if (shopchoice == "1")
                                {
                                    shopitem = "medkit";
                                    itemprice = 250;
                                    enoughgold = enoughgoldfunc(backpack.gold, itemprice);
                                    if (enoughgold == true)
                                    {
                                        backpack.med++;
                                    }
                                }
                                if (shopchoice == "2")
                                {
                                    shopitem = "bandage";
                                    itemprice = 50;
                                    enoughgold = enoughgoldfunc(backpack.gold, itemprice);
                                    if (enoughgold == true)
                                    {
                                        backpack.bandage++;
                                    }
                                }
                                if (shopchoice == "3")
                                {
                                    shopitem = "drug";
                                    itemprice = 250;
                                    enoughgold = enoughgoldfunc(backpack.gold, itemprice);
                                    if (enoughgold == true)
                                    {
                                        backpack.drugs++;
                                    }
                                }
                                if (shopchoice == "4")
                                {
                                    shopitem = "teddy";
                                    itemprice = 50;
                                    enoughgold = enoughgoldfunc(backpack.gold, itemprice);
                                    if (enoughgold == true)
                                    {
                                        backpack.teddy++;
                                    }
                                }
                                if (shopchoice == "5")
                                {
                                    break;
                                    Console.Clear();
                                }
                                if (enoughgold == true)
                                {
                                    backpack.gold = backpack.gold - itemprice;
                                    Console.WriteLine("You bought a {0} for {1} gold", shopitem, itemprice);
                                }
                                else if (enoughgold == false)
                                {
                                    Console.WriteLine("You dont have enough for this item");
                                }
                                Thread.Sleep(500);
                            }
                        }
                        else if (visitshop == "2")
                        {
                            Console.WriteLine("You decided not to visit the shop");
                            Thread.Sleep(500);
                        }
                        Console.Clear();

                        //first fight
                        int enemyspeed = 1;
                        double enemydamage = 1;
                        double enemydefence = 1;

                        int speed = 1;
                        double enemybleed = 0;
                        double enemyhp = 100;
                        bool teddyactive = false;
                        int test;
                        double enemyattack = 20;
                        double slimehp = slimemaxhp;
                        string enemyname = "daniel";
                        string enemy = "enemy slime";
                        string opponent = "first";
                        double slimedamage = 1;
                        double slimedefence = 1;


                        if (round == 2)
                        {
                            enemyhp = 200;
                            enemyname = "danielle";
                            opponent = "second";

                        }
                        if (round == 3)
                        {
                            enemyhp = 400;
                            enemyname = "maxine";
                            enemy = "boss slime";
                            enemyattack = 25;
                            opponent = "final";

                        }

                        Console.WriteLine("You're going up against {0}, your {1} opponent", enemyname, opponent);

                        winner = false;
                        while (winner == false)
                        {

                            //your move

                            int speedcount = speed;
                            do
                            {

                                while (movevalid == false)
                                {
                                    Console.WriteLine("\nIt's your turn \n\nWhat do you want {0} to do? \n 1 - attack \n 2 - special \n 3 - distract \n 4 - use item", slime, enemyname, opponent);
                                    move = Console.ReadLine();
                                    if (move == "1" || move == "2" || move == "3" || move == "4")
                                    {
                                        movevalid = true;
                                    }
                                    else
                                    {
                                        Console.WriteLine(" - Invalid input - ");
                                        movevalid = false;
                                    }
                                }
                                movevalid = false;

                                if (move == "1")
                                {
                                    enemyhp = enemyhp - 20 * slimedamage / enemydefence;
                                    Console.WriteLine("you dealt {2} damage to {0}", enemy, enemyhp, slimeattack);
                                }
                                else if (move == "2")
                                {
                                    enemyhp = enemyhp - 5 * slimedamage / enemydefence;
                                    enemybleed = enemybleed + 5;
                                    Console.WriteLine("You dealt {1} damage to {0} \n {0} has started to bleed", enemy, slimespecial);
                                }
                                else if (move == "3")
                                {
                                    if (backpack.teddy > 0)
                                    {

                                        teddyactive = true;
                                        Console.WriteLine("You used a teddy to replace your animal");
                                    }
                                    else
                                    {
                                        Console.WriteLine("You don't have any teddies");
                                    }
                                }
                                else if (move == "4")
                                {
                                    Console.WriteLine("What item would you like to use? \n 1 - medkit \n 2 - bandage \n 3 - drugs");
                                    secondarymove = Console.ReadLine();
                                    if (secondarymove == "1")
                                    {
                                        if (backpack.med > 0)
                                        {
                                            slimehp = slimehp + 50;
                                            if (slimehp > slimemaxhp)
                                            {
                                                slimehp = 100;
                                            }
                                            backpack.med = backpack.med - 1;
                                            Console.WriteLine("{0}'s hp was restored to {1} health \nYou have {2} medkits left", slime, slimehp, backpack.med);
                                        }
                                        else
                                        {
                                            Console.WriteLine("you dont have any medkits");
                                        }
                                    }

                                    else if (secondarymove == "2")
                                    {
                                        if (backpack.bandage > 0)
                                        {
                                            if (slimebleed > 0)
                                            {
                                                slimebleed = 0;
                                                backpack.bandage = backpack.bandage - 1;
                                                Console.WriteLine("{0} stopped bleeding \nYou have {1} bandages left", slime, backpack.bandage);
                                            }
                                            else
                                            {
                                                Console.WriteLine("it did nothing");
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("You dont have any bandages");
                                        }
                                    }
                                    else if (secondarymove == "3")
                                    {
                                        if (backpack.drugs > 0)
                                        {
                                            int mybuff = ranumber.Next(1, 4);
                                            if (mybuff == 1)
                                            {
                                                slimedamage = slimedamage + 0.5;
                                                Console.WriteLine("{0}'s damage was increased", slime);
                                            }
                                            else if (mybuff == 2)
                                            {
                                                slimedefence = slimedefence + 0.5;
                                                Console.WriteLine("{0}'s defence was increased", slime);
                                            }
                                            else if (mybuff == 3)
                                            {
                                                speed = speed + 1;
                                                Console.WriteLine("{0}'s speed was increased", slime);
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("You dont have any drugs");
                                        }
                                    }
                                }
                                if (slimebleed > 0)
                                {
                                    slimehp = slimehp - slimebleed;
                                    Console.WriteLine("{0} took {1} damage from bleed", slime, slimebleed); ;
                                    slimebleed = slimebleed + 1;
                                }
                                if (enemybleed > 0)
                                {
                                    enemyhp = enemyhp - enemybleed;
                                    Console.WriteLine("{0} took {1} damage from bleed", enemy, enemybleed);
                                    enemybleed = enemybleed + 1;
                                }

                                if (slimehp < 1)
                                {
                                    winner = true;
                                    winneris = enemyname;
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
                            if (enemyhp > 0)
                            {
                                Console.WriteLine("{0} has {1} health left", enemy, enemyhp);
                            }
                            else
                            {
                                Console.WriteLine("{0} has 0 health left", enemy);
                            }
                            Thread.Sleep(1000);
                            //enemy move
                            if (winner == false)
                            {
                                int enemyspeedcount = enemyspeed;
                                do
                                {
                                    Console.WriteLine("\nIt's {0}'s turn \n", enemyname);
                                    int enemymove = ranumber.Next(1, 15);
                                    if (enemymove == 1)
                                    {
                                        int enemybuff = ranumber.Next(1, 4);
                                        if (enemybuff == 1)
                                        {
                                            enemydamage = enemydamage + 0.5;
                                            Console.WriteLine("{0}'s damage was increased", enemy);
                                        }
                                        else if (enemybuff == 2)
                                        {
                                            enemydefence = enemydefence + 0.5;
                                            Console.WriteLine("{0}'s defence was increased", enemy);
                                        }
                                        else if (enemybuff == 3)
                                        {
                                            enemyspeed = enemyspeed + 1;
                                            Console.WriteLine("{0}'s speed was increased", enemy);
                                        }
                                    }
                                    else
                                    {
                                        if (teddyactive == false)
                                        {
                                            damage = enemyattack * enemydamage / slimedefence;
                                            Console.WriteLine("{0} attacked {1} \n{0} dealt {2} damage", enemy, slime, damage);
                                            slimehp = slimehp - damage;
                                        }
                                        else if (teddyactive == true)
                                        {
                                            Console.WriteLine("{0} attacked the teddy and destroyed it", enemy);
                                            teddyactive = false;
                                        }
                                    }
                                    if (slimebleed > 0)
                                    {
                                        slimehp = slimehp - slimebleed;
                                        Console.WriteLine("{0} took {1} damage from bleed", slime, slimebleed); ;
                                        slimebleed = slimebleed + 1;
                                    }
                                    if (enemybleed > 0)
                                    {
                                        enemyhp = enemyhp - enemybleed;
                                        Console.WriteLine("{0} took {1} damage from bleed", enemy, enemybleed);
                                        enemybleed = enemybleed + 1;
                                    }
                                    if (slimehp < 1)
                                    {
                                        winner = true;
                                        winneris = enemyname;
                                        enemyspeedcount = 0;
                                        Console.WriteLine("{1} has {0} hp left", slimehp, slime);
                                    }
                                    else if (enemyhp < 1)
                                    {
                                        winner = true;
                                        winneris = name;
                                        enemyspeedcount = 0;
                                        Console.WriteLine("{1} has {0} hp left", enemyhp, enemy);

                                    }
                                    else
                                    {
                                        Console.WriteLine("{0} has {1} health left", slime, slimehp);
                                    }
                                    enemyspeedcount = enemyspeedcount - 1;
                                }
                                while (enemyspeedcount > 0);
                            }
                        }
                        if (winneris == name)
                        {
                            backpack.gold = backpack.gold + 200;
                            slimelevel = slimelevel + 1;
                            Console.WriteLine("You won and earned 200 gold \n{0} leveled up to level {1}", slime, slimelevel);
                            fightfinish = true;
                            slimemaxhp = slimemaxhp + 20;
                            slimeattack = slimeattack + 5;
                            wingame = true;
                        }
                        else if (winneris == enemyname)
                        {
                            Console.WriteLine("You lost");
                            wingame = false;
                            keepplaying = false;
                            fightfinish = true;
                        }
                    }
                }
            }
            if (wingame == true)
            {
                Console.WriteLine("  Congrats\nYou won back your slime fighting arena");
            }
            
        }
        static bool enoughgoldfunc(int gold, int itemprice)
        {
            if (gold >= itemprice)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}