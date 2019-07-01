using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PaddysConsoleAdventureRPG;

namespace PaddysConsoleAdventureRPG
{
    public class Item //to be continued
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string NamePlural { get; set; }
        public int Value { get; set; }
        public float Weight { get; set; }

        public Item(int id, string name, string namePlural, int value, float weight)
        {
            ID = id;
            Name = name;
            NamePlural = namePlural;
            Value = value;
            Weight = weight;
        }
    }
}
