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

                Console.WriteLine(question);
                System.Threading.Thread.Sleep(1000);

                Console.ForegroundColor = ConsoleColor.Blue;

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
                        Console.WriteLine("\nNot a valid decision. Try again!\n");
                        Console.ReadKey();
                        break;
                }
            }
            while (!validChoice);
            return 0;
        }

        public static int MoveInput(string question, string direction1, string direction2, string direction3, string direction4)
        {
            System.Threading.Thread.Sleep(500);

            Console.WriteLine("\nFor input use the displayed number keys.\n");

            System.Threading.Thread.Sleep(500);

            Console.WriteLine("Valid directions: North(1), East(2), South(3), West(4)\n");

            System.Threading.Thread.Sleep(500);

            bool validDirection;

            do
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;

                Console.WriteLine(question);

                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine(direction1);
                Console.WriteLine(direction2);
                Console.WriteLine(direction3);
                Console.WriteLine(direction4);

                Console.ResetColor();

                string input = Console.ReadLine();

                validDirection = true;

                switch (input)
                {
                    case "1": return 1;
                    case "2": return 2;
                    case "3": return 3;
                    case "4": return 4;
                    default:
                        validDirection = false;
                        Console.WriteLine("\nNot a valid direction. Try again!\n");
                        Console.ReadKey();
                        break;
                }
            }
            while (!validDirection);
            return 0;
        }
    }
}
