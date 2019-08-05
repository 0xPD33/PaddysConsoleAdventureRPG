using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaddysConsoleAdventureRPG
{
    public class BuffConsumable : Item
    {
        public int DamageBuff { get; set; }
        public int DefenseBuff { get; set; }
        public float CarryBuff { get; set; }

        public BuffConsumable(int id, string name, string namePlural, int value, float weight, int damageBuff, int defenseBuff, float carryBuff) : base(id, name, namePlural, value, weight)
        {
            DamageBuff = damageBuff;
            DefenseBuff = defenseBuff;
            CarryBuff = carryBuff;
        }
    }
}
