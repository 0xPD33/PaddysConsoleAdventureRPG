using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PaddysConsoleAdventureRPG;

namespace PaddysConsoleAdventureRPG
{
    public class Weapon : Item
    {
        public int MinDamage { get; set; }
        public int MaxDamage { get; set; }

        public Weapon(int id, string name, string namePlural, int value, float weight, int minDamage, int maxDamage) : base (id, name, namePlural, value, weight)
        {
            MinDamage = minDamage;
            MaxDamage = maxDamage;
        }
    }
}
