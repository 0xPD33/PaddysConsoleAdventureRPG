using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PaddysConsoleAdventureRPG;

namespace PaddysConsoleAdventureRPG
{
    public class Character : LivingCreature
    {
        public int Gold { get; set; }
        public int ExperiencePoints { get; set; }
        public int Level { get; set; }

        public int MaximumStamina { get; set; }
        public int CurrentStamina { get; set; }

        public int Luck { get; set; }

        public float MaximumCarryWeight { get; set; }
        public float CurrentCarryWeight { get; set; }

        public Character(string name, int currentHealth, int maximumHealth, int currentStamina, int maximumStamina, int atkPower, int defValue, int gold, int experiencePoints, int level, int luck, float maximumCarryWeight, float currentCarryWeight)
            : base(name, currentHealth, maximumHealth, atkPower, defValue)
        {
            Name = name;
            CurrentHealth = currentHealth;
            MaximumHealth = maximumHealth;
            CurrentStamina = currentStamina;
            MaximumStamina = maximumStamina;
            AtkPower = atkPower;
            DefValue = defValue;
            Gold = gold;
            ExperiencePoints = experiencePoints;
            Level = level;
            Luck = luck;
            MaximumCarryWeight = maximumCarryWeight;
            CurrentCarryWeight = currentCarryWeight;
        }

        public void SetName(string name)
        {
            Name += name;
        }

    }
}
