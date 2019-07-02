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

        public static void ChooseName (Character _character)
        {
            Console.Clear();

            do
            {
                Story.NPCDialog("Okay first of all: Please tell me your name.", "???: "); //enter name
                Console.WriteLine("\nName: ");
                _character.SetName(Console.ReadLine()); //wait for input of name

                ConsoleKey response;
                do
                {
                    Story.NPCDialog("Is the name: " + _character.Name + " correct?", "???: "); //ask if name is correct
                    Console.WriteLine("\n[y/n]\n");//yes or no
                    response = Console.ReadKey(false).Key; //wait for key input
                    if (response != ConsoleKey.Enter) //if response isn't enter key
                    {
                        Console.WriteLine(); //repeat line
                    }

                    if (response == ConsoleKey.N)
                    {
                        _character.Name = "";
                    }
                }
                while (response != ConsoleKey.Y && response != ConsoleKey.N); //repeat code until Y or N is pressed

                confirmed = response == ConsoleKey.Y; //confirmed if response is Y
            }
            while (!confirmed);

            Story.NPCDialog("Nice to meet you " + _character.Name + "!\n", "???: ");

            System.Threading.Thread.Sleep(1000);

            ChooseStory(_character);
        }
        public static void ChooseStory(Character _character)
        {
            Story.NPCDialog("My name is Niclas, by the way.", "???: ");
            System.Threading.Thread.Sleep(1000);
            Story.NPCDialog("\nIt's only fair if you know my name as well.", "Niclas: ");
            System.Threading.Thread.Sleep(2000);
            Story.ThoughtsDialog("\nWell, he is right.", _character.Name);
            System.Threading.Thread.Sleep(1000);
            Story.PlayerDialog("\nI'm starting to remember some of the stuff that happened before I woke up here.", _character.Name);
            System.Threading.Thread.Sleep(2500);
            Story.NPCDialog("\nTell me about it! This is fascinating, because we have never heard of that continent.", "Niclas: ");
            System.Threading.Thread.Sleep(1500);
            Story.PlayerDialog("\nOkay. Let me think...", _character.Name);
            System.Threading.Thread.Sleep(2500);
            Story.ThoughtsDialog("\nI think I remember..", _character.Name);
            System.Threading.Thread.Sleep(1000);
            Story.PlayerDialog("\nWhat do you want to know?", _character.Name);
            System.Threading.Thread.Sleep(2000);

            switch(InputManager.CreationInput("\nNiclas: The country you lived in.. was it hot, cold or neutral in temperature?\n",
                                                "1 - It was pretty cold. Winters were hard because temperatures were below zero most of the time. I learned to overcome this coldness.",
                                                "2 - It was hot. Summers were unbearable and everyone was sweating a lot. I learned to endure the hot weather.",
                                                "3 - It was neutral. We had some cold winters and hot summers, but nothing too wild and the climate was pleasant. I guess I was lucky."))
            {
                case 1: _character.StartingStats(5, 0, 0); break;
                case 2: _character.StartingStats(0, 5, 0); break;
                case 3: _character.StartingStats(2, 2, 1); break;
                default: break;
            }
        }

    }
}
