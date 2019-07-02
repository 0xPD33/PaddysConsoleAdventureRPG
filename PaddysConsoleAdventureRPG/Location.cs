using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PaddysConsoleAdventureRPG;

namespace PaddysConsoleAdventureRPG
{

    public class Location
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Item ItemToEnter { get; set; }
        public Quest QuestAvailable { get; set; }
        public Monster MobToBattle1 { get; set; }
        public Monster MobToBattle2 { get; set; }
        public Location LocationToNorth { get; set; }
        public Location LocationToEast { get; set; }
        public Location LocationToSouth { get; set; }
        public Location LocationToWest { get; set; }

        public Location(int id, string name, string description, Item itemToEnter = null, Quest questAvailable = null, Monster mobToBattle1 = null, Monster mobToBattle2 = null)
        {
            ID = id;
            Name = name;
            Description = description;
            ItemToEnter = itemToEnter;
            QuestAvailable = questAvailable;
            MobToBattle1 = mobToBattle1;
            MobToBattle2 = mobToBattle2;
        }
    }
}
