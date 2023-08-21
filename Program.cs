using System;
using System.Threading;

namespace CoolTextAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Cool Text Adventure";

            Console.WriteLine("Welcome to the Cool Text Adventure!");
            Console.WriteLine("You find yourself standing at the entrance of a mysterious cave.");
            Console.WriteLine("Will you venture inside to find the hidden treasure? (yes/no)");

            string choice = Console.ReadLine().ToLower();
            if (choice == "yes")
            {
                Console.Clear();
                Console.WriteLine("As you enter the cave, you encounter two paths ahead.");
                Console.WriteLine("Will you take the path on the left or the right? (left/right)");

                choice = Console.ReadLine().ToLower();
                if (choice == "left")
                {
                    Console.Clear();
                    Console.WriteLine("You walk down the left path and discover a shimmering pool.");
                    Console.WriteLine("Do you want to swim across or search for another way? (swim/search)");

                    choice = Console.ReadLine().ToLower();
                    if (choice == "swim")
                    {
                        Console.Clear();
                        Console.WriteLine("You bravely swim across the pool and find a hidden chamber.");
                        Console.WriteLine("Inside, you find the legendary treasure chest!");
                        Console.WriteLine("Congratulations, you've won the game!");
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("You search for another way and encounter a hidden bridge.");
                        Console.WriteLine("You cross it safely and find the legendary treasure chest!");
                        Console.WriteLine("Congratulations, you've won the game!");
                    }
                }
                else if (choice == "right")
                {
                    Console.Clear();
                    Console.WriteLine("You take the right path and stumble upon a sleeping dragon!");
                    Console.WriteLine("Do you want to face the dragon or retreat? (face/retreat)");

                    choice = Console.ReadLine().ToLower();
                    if (choice == "face")
                    {
                        Console.Clear();
                        Console.WriteLine("You gather your courage and confront the dragon.");
                        Console.WriteLine("With a mighty battle, you defeat the dragon and find the treasure chest!");
                        Console.WriteLine("Congratulations, you've won the game!");
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("You wisely choose to retreat and find another way.");
                        Console.WriteLine("You eventually find a hidden passage that leads to the treasure chest!");
                        Console.WriteLine("Congratulations, you've won the game!");
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("You hesitate and are seized by a sense of doubt...");
                    Console.WriteLine("Your indecision prevents you from finding the treasure. Game over.");
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("You decide not to enter the cave and miss out on the adventure.");
                Console.WriteLine("Maybe next time! Thanks for playing.");
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
