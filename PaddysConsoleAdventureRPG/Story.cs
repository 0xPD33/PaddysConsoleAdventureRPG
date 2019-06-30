using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PaddysConsoleAdventureRPG
{
    class Story
    {

        public static void ThoughtsDialog(string message/* ,string characterName*/) //I want to add the name of the character in front of every thought dialog. dunno how to do that yet
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(message);
            Console.ResetColor();
        }

        public static void NPCDialog(string message)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(message);
            Console.ResetColor();
        }

        public static void PlayerDialog(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(message);
            Console.ResetColor();
        }

        public static void StartingStory()
        {
            Console.WriteLine("Welcome to Paddy's Console Adventure RPG\n");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("This game will be pretty small and will be written for learning purposes.\n");
            System.Threading.Thread.Sleep(2000);
            Console.Clear();

            Console.WriteLine("You wake up, having no memory at all.\n");
            System.Threading.Thread.Sleep(1500);
            Console.WriteLine("The sun is shining outside and is blasting in your face.\n");
            System.Threading.Thread.Sleep(1500);
            Console.WriteLine("You seem to be in some kind of wooden hut in the forest.\n");
            System.Threading.Thread.Sleep(1500);
            ThoughtsDialog("There is someone at the door.\n");
            System.Threading.Thread.Sleep(2000);
            ThoughtsDialog("How long has he been standing there?\n");
            System.Threading.Thread.Sleep(1000);

            NPCDialog("Hey friend, are you finally awake?\n");
            System.Threading.Thread.Sleep(2500);
            PlayerDialog("Yes. I just woke up. Where am I?\n");
            System.Threading.Thread.Sleep(2500);
            Console.WriteLine("\nThe person talking to you has some kind of white coat.\n");
            System.Threading.Thread.Sleep(2000);
            ThoughtsDialog("Maybe he is a doctor?\n");
            System.Threading.Thread.Sleep(1500);
            Console.WriteLine("\nYou ask yourself.\n");
            System.Threading.Thread.Sleep(1500);
            NPCDialog("You are in Padia, a continent full of adventure.\n");
            System.Threading.Thread.Sleep(2000);
            ThoughtsDialog("What is he talking about? I've never heard of this continent.\n");
            System.Threading.Thread.Sleep(2000);
            PlayerDialog("But.. I'm from Europe! How did I get here?\n");
            System.Threading.Thread.Sleep(2000);
            NPCDialog("Europe? Never heard of that. We found you stranded on a beach not far from here.\n");
            System.Threading.Thread.Sleep(2000);
            PlayerDialog("Why do I have no memory at all?\n");
            System.Threading.Thread.Sleep(2500);
            NPCDialog("I don't know either. Now, I need to ask you some questions.\n");
            System.Threading.Thread.Sleep(2500);
            PlayerDialog("Okay, go ahead.\n");
            System.Threading.Thread.Sleep(2000);

            Console.Clear();
            
        }

       

    }
}
