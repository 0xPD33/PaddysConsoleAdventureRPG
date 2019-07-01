using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PaddysConsoleAdventureRPG;

namespace PaddysConsoleAdventureRPG
{
    public class Monster //to be continued
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int MaximumHealth { get; set; }
        public int CurrentHealth { get; set; }
        public int MobDamage { get; set; }
        public int MobDefense { get; set; }
        public int RewardExp { get; set; }
        public int RewardGold { get; set; }
    }
}
