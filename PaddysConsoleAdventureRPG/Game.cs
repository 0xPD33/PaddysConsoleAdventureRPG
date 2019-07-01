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
       

        public Game() //constructor
        {
            Location location = new Location(1, "Wooden hut", "This is the place where you woke up.");
            location.ID = 1;
            location.Name = "Wooden hut";
            location.Description = "This is the place where you woke up.";

            //Character _character = new Character(); //CS7036

            //_character.CurrentHealth = 20;
            //_character.MaximumHealth = 20;
            //_character.MaximumStamina = 15;
            //_character.CurrentStamina = 15;
            //_character.Gold = 20;
            //_character.ExperiencePoints = 0;
            //_character.Level = 1;

            //_character.Luck = 2;
            //_character.AtkPower = 4;
            //_character.DefValue = 4;

            //_character.MaximumCarryWeight = 20.0f;
            //_character.CurrentCarryWeight = 0f;
        }

        public static void Main() //will try to make the code cleaner and better this time
        {
            Story.StartingStory();
            //CharacterCreation.Creation(); //CS7036



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

        public static void ShowStats() //NullReference when trying to add values from Game() constructor :(
        {
            System.Threading.Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("\nYour Level is: " + "placeholder" + ".\n"); 
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("And your stats are: ");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Maximum Health: " + "placeholder");
            Console.WriteLine("Maximum Stamina: " + "placeholder");
            Console.WriteLine("Attack Power: " + "placeholder");
            Console.WriteLine("Defense: " + "placeholder");
            Console.WriteLine("Luck: " + "placeholder");
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
