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
                Story.NPCDialog("Please tell me your name.", "???: "); //enter name
                Console.WriteLine("\nName: ");
                _character.SetName(Console.ReadLine()); //wait for input of name

                ConsoleKey response;
                do
                {
                    Story.NPCDialog("Is the name " + _character.Name + " correct?", "???: "); //ask if name is correct
                    Console.WriteLine("\n[y/n]\n");//yes or no
                    response = Console.ReadKey(false).Key; //wait for key input
                    if (response != ConsoleKey.Enter) //if response isn't enter key
                    {
                        Console.WriteLine(); //repeat line
                    }

                    if (response == ConsoleKey.N)
                    {
                        Console.Clear();
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
            Story.NPCDialog("My name is Niclas, by the way.\n", "???: ");
            System.Threading.Thread.Sleep(1000);
            Story.NPCDialog("It's only fair if you know my name as well.\n", "Niclas: ");
            System.Threading.Thread.Sleep(2000);
            Story.ThoughtsDialog("Well, he is right.\n", _character.Name);
            System.Threading.Thread.Sleep(1000);
            Story.PlayerDialog("I'm starting to remember some of the stuff that happened before I woke up here.\n", _character.Name);
            System.Threading.Thread.Sleep(2500);
            Story.NPCDialog("Tell me about it! This is fascinating, because we have never heard of that continent.\n", "Niclas: ");
            System.Threading.Thread.Sleep(1500);
            Story.PlayerDialog("Okay. Let me think...\n", _character.Name);
            System.Threading.Thread.Sleep(2000);
            Story.ThoughtsDialog("I think I remember!\n", _character.Name);
            System.Threading.Thread.Sleep(2000);
            Story.PlayerDialog("What do you want to know?\n", _character.Name);
            System.Threading.Thread.Sleep(1500);

            switch(InputManager.CreationInput("Niclas: The country you lived in.. was it hot, cold or neutral in temperature?\n",
                                                "1 - It was pretty cold. Winters were hard because temperatures were below zero most of the time. I learned to overcome this coldness.",
                                                "2 - It was hot. Summers were unbearable and everyone was sweating a lot. I learned to endure the hot weather.",
                                                "3 - It was neutral. We had some cold winters and hot summers, but nothing too wild and the climate was pleasant. I guess I was lucky."))
            {
                case 1: _character.StartingStats(5, 0, 0); break;
                case 2: _character.StartingStats(0, 5, 0); break;
                case 3: _character.StartingStats(1, 1, 2); break;
                default: break;
            }

            System.Threading.Thread.Sleep(500);
            Story.NPCDialog("Interesting. We have cold and hot zones in Padia, as well as neutral ones, which have a comfortable temperature. Similar to the continent you described.\n", "Niclas: ");
            System.Threading.Thread.Sleep(1500);

            switch (InputManager.CreationInput("Niclas: Tell me about your parents. Which of your parents inspired you the most?\n",
                                               "1 - My father. He was a good guy and always hard-working. He always supported me and told me to stay humble.",
                                               "2 - My mother. She always tried to help people and did tried her best to raise me. She cared a lot about being healthy.",
                                               "3 - To be honest: Both, but I mostly did my own thing. I wasn't influenced by them that much."))
            {
                case 1: _character.StartingStats(4, 1, 0); break;
                case 2: _character.StartingStats(1, 4, 0); break;
                case 3: _character.StartingStats(2, 2, 1); break;
                default: break;
            }

            System.Threading.Thread.Sleep(500);
            Story.NPCDialog("You seem to really miss your parents. I bet they did a great job raising you.", "Niclas: ");
            System.Threading.Thread.Sleep(1500);
            Story.ThoughtsDialog("I do miss them indeed...", _character.Name);
            System.Threading.Thread.Sleep(2000);
        }

    }
}
