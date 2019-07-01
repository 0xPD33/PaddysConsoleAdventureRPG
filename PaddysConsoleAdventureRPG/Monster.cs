using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PaddysConsoleAdventureRPG;

namespace PaddysConsoleAdventureRPG
{
    public class Monster : LivingCreature
    {
        public int ID { get; set; }
        public int RewardExp { get; set; }
        public int RewardGold { get; set; }

        public Monster(int id, string name, int atkPower, int defValue, int rewardExp, int rewardGold, int currentHealth, int maximumHealth) : base(name, currentHealth, maximumHealth, atkPower, defValue)
        {
            ID = id;
            Name = name;
            AtkPower = atkPower;
            DefValue = defValue;
            RewardExp = rewardExp;
            RewardGold = rewardGold;
        }

    }
}
