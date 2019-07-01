using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PaddysConsoleAdventureRPG;

namespace PaddysConsoleAdventureRPG
{
    public class CharacterCreation
    {
        private static bool confirmed = false;

        public static void Creation (Character character)
        {
            Console.Clear();

            do
            {
                Story.NPCDialog("Okay first of all: Please tell me your name.", "???: "); //enter name
                Console.WriteLine("\nName: ");
                character.SetName(Console.ReadLine()); //wait for input of name

                ConsoleKey response;
                do
                {
                    Story.NPCDialog("Is the name: " + character.Name + " correct?", "???: "); //ask if name is correct
                    Console.WriteLine("\n[y/n]\n");//yes or no
                    response = Console.ReadKey(false).Key; //wait for key input
                    if (response != ConsoleKey.Enter) //if response isn't enter key
                    {
                        Console.WriteLine(); //repeat line
                    }
                }
                while (response != ConsoleKey.Y && response != ConsoleKey.N); //repeat code until Y or N is pressed

                confirmed = response == ConsoleKey.Y; //confirmed if response is Y
            }
            while (!confirmed);

            Story.NPCDialog("Nice to meet you " + character.Name + "!\n", "???: ");

            System.Threading.Thread.Sleep(1500);
        }
    }
}
