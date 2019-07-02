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
        }

        public static void Main()
        {
            Character _character = new Character("", 20, 20, 15, 15, 4, 4, 25, 0, 1, 3, 20.0f, 0.0f);

            Story.StartingStory();
            CharacterCreation.ChooseName(_character);
            CharacterCreation.ChooseStory(_character);



            Character.GameOver(_character); //call game over method
        }
    }
}
