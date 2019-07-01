using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PaddysConsoleAdventureRPG;

namespace PaddysConsoleAdventureRPG
{
    class Game
    {
        private static Character _character;

        public Game() //constructor
        {
            _character = new Character(); //new Character

            _character.CurrentHealth = 15;
            _character.MaximumHealth = 15;
            _character.Gold = 20;
            _character.ExperiencePoints = 0;
            _character.Level = 1;

            _character.Stamina = 15;
            _character.AtkPower = 5;
            _character.DefValue = 5;

            _character.MaximumCarryWeight = 20.0f;
            _character.CurrentCarryWeight = 0f;
        }

        public static void Main() //will try to make the code cleaner and better this time
        {
            Story.StartingStory();
            Character.NameCharacter();



            GameOver(); //call game over method
        }

        private static bool confirmed = false;

        public static void GameOver() //game over screen
        {
            Console.Clear();
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("GAME OVER");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("\n[Press any key to continue..]");
            Console.ReadLine();
            Console.Clear();
            do
            {
                ConsoleKey response;
                do
                {
                    Console.WriteLine("Do you want to see your stats?");
                    Console.WriteLine("\n[y/n]\n");//yes or no
                    response = Console.ReadKey(false).Key; //wait for key input
                    if (response != ConsoleKey.Enter) //if response isn't enter key
                    {
                        Console.WriteLine(); //repeat line
                    }
                }
                while (response != ConsoleKey.Y && response != ConsoleKey.N); //repeat code until Y or N is pressed

                confirmed = response == ConsoleKey.Y; //confirmed if response is Y

                if (response == ConsoleKey.Y)
                {
                    ShowStats();
                }
                else
                {
                    StartOver();
                }

            }
            while (!confirmed);

        }

        public static void ShowStats()
        {
            System.Threading.Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("\nYour Level is: " + _character.Level + ".\n"); //NullReference, HELP
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("And your stats are: ");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Maximum Health: " + _character.MaximumHealth);
            Console.WriteLine("Stamina: " + _character.Stamina);
            Console.WriteLine("Attack Power: " + _character.AtkPower);
            Console.WriteLine("Defense: " + _character.DefValue);
            System.Threading.Thread.Sleep(2000);

            StartOver();
        }

        public static void StartOver()
        {
            do
            {
                ConsoleKey response;
                do
                {
                    Console.WriteLine("Do you want to start over?");
                    Console.WriteLine("\n[y/n]\n");//yes or no
                    response = Console.ReadKey(false).Key; //wait for key input
                    if (response != ConsoleKey.Enter) //if response isn't enter key
                    {
                        Console.WriteLine(); //repeat line
                    }
                }
                while (response != ConsoleKey.Y && response != ConsoleKey.N); //repeat code until Y or N is pressed

                confirmed = response == ConsoleKey.Y; //confirmed if response is Y

                if (response == ConsoleKey.Y)
                {
                    Console.Clear();
                    System.Threading.Thread.Sleep(500);
                    Main();
                }
                else
                {
                    System.Environment.Exit(1);
                }
            }
            while (!confirmed);
        }
    }
}
