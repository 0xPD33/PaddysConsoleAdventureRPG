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
       
        public static void Main()
        {
            Console.SetWindowSize(180, 45);

            Character _character = new Character("", 15, 15, 10, 10, 3, 3, 10, 0, 1, 1, 25.0f, 0.0f);

            Story.StartingStory();
            CharacterCreation.ChooseName(_character);
            CharacterCreation.ChooseStory(_character);



            Character.GameOver(_character); //call game over method
        }
    }
}
