using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PaddysConsoleAdventureRPG;

namespace PaddysConsoleAdventureRPG
{
    public class Character : LivingCreature
    {
        public bool IsPlayer { get; set; }

        public int Gold { get; set; }
        public int ExperiencePoints { get; set; }
        public int Level { get; set; }

        public int MaximumStamina { get; set; }
        public int CurrentStamina { get; set; }

        public int Luck { get; set; }

        public float MaximumCarryWeight { get; set; }
        public float CurrentCarryWeight { get; set; }

        //public string CurrentLocation { get; set; }

        public List<InventorySystem> Inventory { get; set; }
        public List<PlayerQuest> Quests { get; set; }

        public Character(string name, int currentHealth, int maximumHealth, int currentStamina, int maximumStamina, int atkPower, int defValue, int gold, int experiencePoints, int level, int luck, float maximumCarryWeight, float currentCarryWeight, bool isPlayer/*, Location/string(?) currentLocation*/)
            : base(name, currentHealth, maximumHealth, atkPower, defValue)
        {
            Name = name;
            CurrentHealth = currentHealth;
            MaximumHealth = maximumHealth;
            CurrentStamina = currentStamina;
            MaximumStamina = maximumStamina;
            AtkPower = atkPower;
            DefValue = defValue;
            Gold = gold;
            ExperiencePoints = experiencePoints;
            Level = level;
            Luck = luck;
            MaximumCarryWeight = maximumCarryWeight;
            CurrentCarryWeight = currentCarryWeight;
            IsPlayer = isPlayer;
            //CurrentLocation = currentLocation;

            Inventory = new List<InventorySystem>();
            Quests = new List<PlayerQuest>();
        }

        public void SetName(string name)
        {
            Name += name;
        }

        private static bool confirmed = false;
       
        public void StartingStats(int plusStamina, int plusHealth, int plusLuck)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            MaximumStamina += plusStamina; Console.WriteLine("You gained {0} maximum stamina.", plusStamina);
            MaximumHealth += plusHealth; Console.WriteLine("You gained {0} maximum health.", plusHealth);
            Luck += plusLuck; Console.WriteLine("You gained some stamina, health and {0} luck.", plusLuck);
            Console.ResetColor();
        }

        public static void ShowStats(Character _character)
        {
            System.Threading.Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("\nYour Name is: " + _character.Name + ".\n");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Your Level is: " + _character.Level + ".\n");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("And your stats are: \n");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("\nMaximum Health: " + _character.MaximumHealth + ".");
            Console.WriteLine("Maximum Stamina: " + _character.MaximumStamina + ".");
            Console.WriteLine("Attack Power: " + _character.AtkPower + ".");
            Console.WriteLine("Defense: " + _character.DefValue + ".");
            Console.WriteLine("Luck: " + _character.Luck + ".");
            System.Threading.Thread.Sleep(2000);

            Console.WriteLine("\n[Press any key to continue..]");
            Console.ReadLine();
            System.Threading.Thread.Sleep(1000);

            StartOver();
        }

        public static void StartOver()
        {
            do
            {
                ConsoleKey response;
                do
                {
                    Console.WriteLine("\nDo you want to start over?");
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
                    Console.WriteLine("*Restarting game...*");
                    System.Threading.Thread.Sleep(1500);
                    Console.Clear();

                    Game.Main(); //restart game
                }
                else
                {
                    Console.WriteLine("Thanks for playing!");
                    System.Threading.Thread.Sleep(1500);
                    System.Environment.Exit(1);
                }
            }
            while (!confirmed);
        }

        public static void GameOver(Character _character) //game over screen
        {
            Console.Clear();
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("*** GAME OVER ***");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("\nYou did great, Hero. But death awaits everyone.\n");
            System.Threading.Thread.Sleep(1000);
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
                    ShowStats(_character);
                }
                else
                {
                    StartOver();
                }

            }
            while (!confirmed);
        }

    }
}
