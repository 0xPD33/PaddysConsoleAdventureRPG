using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PaddysConsoleAdventureRPG;

namespace PaddysConsoleAdventureRPG
{
    public class Armor : Item
    {
        public int ArmorDefense{ get; set; }

        public Armor(int id, string name, string namePlural, int value, float weight, int armorDef) : base(id, name, namePlural, value, weight)
        {
            ArmorDefense = armorDef;
        }
    }
}
