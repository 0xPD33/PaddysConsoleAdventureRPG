using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PaddysConsoleAdventureRPG;

namespace PaddysConsoleAdventureRPG
{
    public class HealingPotion : Item //to be continued
    {
        public int HealAmount { get; set; }

        public HealingPotion(int id, string name, string namePlural, int value, float weight, int healAmount) : base(id, name, namePlural, value, weight)
        {
            HealAmount = healAmount;
        }
    }
}
