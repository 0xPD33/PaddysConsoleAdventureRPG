using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaddysConsoleAdventureRPG
{
    public class Food : Item
    {
        public int HealthRecovery { get; set; }
        public int StaminaRecovery { get; set; }

        public Food(int id, string name, string namePlural, int value, float weight, int healthRecovery, int staminaRecovery) : base(id, name, namePlural, value, weight)
        {
            HealthRecovery = healthRecovery;
            StaminaRecovery = staminaRecovery;
        }

    }
}
