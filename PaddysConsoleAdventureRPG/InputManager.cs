using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaddysConsoleAdventureRPG
{
    class InputManager
    {

        public static int CreationInput(string question, string decision1, string decision2, string decision3)
        {
            System.Threading.Thread.Sleep(500);

            Console.WriteLine("\nFor input use the displayed number keys.\n");

            System.Threading.Thread.Sleep(500);

            bool validChoice;

            do
            {
                Console.ForegroundColor = ConsoleColor.Cyan;

                Console.WriteLine(decision1);
                Console.WriteLine(decision2);
                Console.WriteLine(decision3);

                Console.ResetColor();

                string input = Console.ReadLine();

                validChoice = true;

                switch (input)
                {
                    case "1": return 1;
                    case "2": return 2;
                    case "3": return 3;
                    default:
                        validChoice = false;
                        Console.WriteLine("\nNot a valid decision\n");
                        Console.WriteLine("[Press any key to continue..]");
                        Console.ReadKey();
                        break;
                }
            }
            while (!validChoice);
            return 0;
        }
    }
}
