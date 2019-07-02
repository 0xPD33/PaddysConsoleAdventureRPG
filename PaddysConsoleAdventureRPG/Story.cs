using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using PaddysConsoleAdventureRPG;

namespace PaddysConsoleAdventureRPG
{
    public class Story
    {
        public static void ThoughtsDialog(string message, string characterName)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("*");
            Console.Write(characterName);
            Console.Write("*");
            Console.Write(": ");
            Console.Write(message);
            Console.ResetColor();
        }

        public static void NPCDialog(string message, string NPCName)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(NPCName);
            Console.Write(message);
            Console.ResetColor();
        }

        public static void PlayerDialog(string message, string characterName)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(characterName);
            Console.Write(": ");
            Console.Write(message);
            Console.ResetColor();
        }

        public static void StartingStory()
        {
            Console.WriteLine("_______________________________________________________________________________________________________________________\n");
            Console.WriteLine("\t\t\t\t\tWelcome to Paddy's Console Adventure RPG\n");
            Console.WriteLine("_______________________________________________________________________________________________________________________\n");
            System.Threading.Thread.Sleep(1500);
            Console.WriteLine("This game will be pretty small and will be written for learning purposes.\n");
            System.Threading.Thread.Sleep(3000);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("The text written in yellow are your thoughts. They will be marked with little stars (*)");
            System.Threading.Thread.Sleep(2500);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("The text written in cyan is NPC speech.");
            System.Threading.Thread.Sleep(2000);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("The text written in green is you (the character) speaking.");
            System.Threading.Thread.Sleep(3000);

            Console.ResetColor();

            Console.Clear();

            Console.WriteLine("You wake up, having no memory at all.\n");
            System.Threading.Thread.Sleep(1500);
            Console.WriteLine("The sun is shining outside and is blasting in your face.\n");
            System.Threading.Thread.Sleep(1500);
            Console.WriteLine("You seem to be in some kind of wooden hut in the forest.\n");
            System.Threading.Thread.Sleep(1500);
            ThoughtsDialog("There is someone at the door.\n", "You");
            System.Threading.Thread.Sleep(2000);
            ThoughtsDialog("How long has he been standing there?\n", "You");
            System.Threading.Thread.Sleep(1000);

            NPCDialog("Hey friend, are you finally awake?\n", "???: ");
            System.Threading.Thread.Sleep(2500);
            PlayerDialog("Yes. I just woke up. Where am I?\n", "You");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("\nThe person talking to you has some kind of white coat.\n");
            System.Threading.Thread.Sleep(2500);
            ThoughtsDialog("Maybe he is a doctor?\n", "You");
            System.Threading.Thread.Sleep(1500);
            NPCDialog("You are in Padia, a continent full of adventure.\n", "???: ");
            System.Threading.Thread.Sleep(2000);
            ThoughtsDialog("What is he talking about? I've never heard of this continent.\n", "You");
            System.Threading.Thread.Sleep(2500);
            PlayerDialog("But.. I'm from Europe! How did I get here?\n", "You");
            System.Threading.Thread.Sleep(2000);
            NPCDialog("Europe? Never heard of that. We found you stranded on a beach not far from here.\n", "???: ");
            System.Threading.Thread.Sleep(2500);
            PlayerDialog("Why do I have no memory at all?\n", "You");
            System.Threading.Thread.Sleep(2000);
            NPCDialog("Your brain is probably still exhausted. Maybe it will come back when I ask you some questions.\n", "???: ");
            System.Threading.Thread.Sleep(3500);
            NPCDialog("Answer with the truth and nothing else. It's important for me to know this.\n", "???: ");
            System.Threading.Thread.Sleep(2500);
            PlayerDialog("Okay, go ahead.\n", "You");
            System.Threading.Thread.Sleep(1500);
        }
    }
}
