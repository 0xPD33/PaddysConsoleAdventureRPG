using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaddysConsoleAdventureRPG
{
    public class LivingCreature
    {
        public string Name { get; set; }

        public int CurrentHealth { get; set; }
        public int MaximumHealth { get; set; }

        public int AtkPower { get; set; }
        public int DefValue { get; set; }

        public LivingCreature(string name, int currentHealth, int maximumHealth, int atkPower, int defValue)
        {
            Name = name;
            AtkPower = atkPower;
            DefValue = defValue;
            CurrentHealth = currentHealth;
            MaximumHealth = maximumHealth;
        }

    }
}
