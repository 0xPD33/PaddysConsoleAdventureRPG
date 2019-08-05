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

            System.Threading.Thread.Sleep(500);

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
                case 1: _character.StartingStats(4, 0, 0); break;
                case 2: _character.StartingStats(0, 4, 0); break;
                case 3: _character.StartingStats(1, 1, 2); break;
                default: break;
            }

            System.Threading.Thread.Sleep(500);
            Story.NPCDialog("Interesting. We have cold and hot zones in Padia, as well as neutral ones, which have a comfortable temperature. Similar to the continent you described.\n", "Niclas: ");
            System.Threading.Thread.Sleep(1500);

            switch (InputManager.CreationInput("Niclas: Tell me about your parents. Which of your parents inspired you the most?\n",
                                               "1 - My father. He was a good guy and always hard-working. He always supported me and told me to stay humble.",
                                               "2 - My mother. She always tried to help people and did tried her best to raise me. She cared a lot about being healthy.",
                                               "3 - To be honest: Both raised me well, but I mostly did my own thing. I wasn't influenced by them that much."))
            {
                case 1: _character.StartingStats(3, 1, 0); break;
                case 2: _character.StartingStats(1, 3, 0); break;
                case 3: _character.StartingStats(1, 1, 2); break;
                default: break;
            }

            System.Threading.Thread.Sleep(500);
            Story.NPCDialog("You seem to really miss your parents. I bet they did a great job raising you.\n", "Niclas: ");
            System.Threading.Thread.Sleep(1500);
            Story.ThoughtsDialog("I do miss them indeed..\n", _character.Name);
            System.Threading.Thread.Sleep(2000);

            switch (InputManager.CreationInput("Niclas: Was there a lot of war where you come from?\n",
                                   "1 - Yes, countries were fighting pretty often. There were a lot of deaths. I also fought in war.",
                                   "2 - We had some wars but I was safe and healthy most of the time. The wars didn't last for long.",
                                   "3 - There were almost no wars. Many countries started to establish peace between each other before I disappeared."))
            {
                case 1: _character.StartingStats(3, 1, 0); break;
                case 2: _character.StartingStats(1, 3, 0); break;
                case 3: _character.StartingStats(1, 1, 2); break;
                default: break;
            }

            System.Threading.Thread.Sleep(500);
            Story.NPCDialog("\nPadia is mostly peaceful, but wild monsters and bandits can be dangerous.\n", "Niclas: ");
            System.Threading.Thread.Sleep(2000);
            Story.ThoughtsDialog("Monsters? Bandits? Oh god.\n", _character.Name);
            System.Threading.Thread.Sleep(1500);

            switch (InputManager.CreationInput("Niclas: Did you find love?\n",
                       "1 - Well I loved many, but I didn't get much love back, until one day I met my perfect partner.",
                       "2 - I loved no one except my parents. I didn't believe in love anyway.",
                       "3 - I was getting a lot of love. I wasn't getting rejected very often."))
            {
                case 1: _character.StartingStats(3, 1, 1); break;
                case 2: _character.StartingStats(1, 3, 1); break;
                case 3: _character.StartingStats(2, 2, 2); break;
                default: break;
            }

            System.Threading.Thread.Sleep(500);
            Story.NPCDialog("\nI bet you will find love in Padia.\n", "Niclas: ");
            System.Threading.Thread.Sleep(2000);
            Story.NPCDialog("Anyways. That's enough for now. I guess you miss your old world, but you will have fun here. Believe me.\n", "Niclas: ");
            System.Threading.Thread.Sleep(2500);
            Story.PlayerDialog("What now?\n", _character.Name);
            System.Threading.Thread.Sleep(1500);
            Story.NPCDialog("You are free to go. North from here is the city. You should be heading there.\n", "Niclas: ");
            System.Threading.Thread.Sleep(2500);
            Story.NPCDialog("Once you reach the city I will ensure you get a wooden sword for defending yourself.\n", "Niclas: ");
            System.Threading.Thread.Sleep(2500);
            Story.NPCDialog("But you should be careful. There could be bandits or monsters waiting for you in the forest.\n", "Niclas: ");
            System.Threading.Thread.Sleep(2500);
            Story.NPCDialog("There were some people camping not far from here. I think it was somewhere South.\n", "Niclas: ");
            System.Threading.Thread.Sleep(2000);
            Story.NPCDialog("So if you want some advice or want to make some friends, check it out.", "Niclas: ");
            System.Threading.Thread.Sleep(2000);
            Story.PlayerDialog("Alright. Thank you.\n", _character.Name);
            System.Threading.Thread.Sleep(1500);
        }

    }
}
