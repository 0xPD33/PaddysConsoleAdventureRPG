using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PaddysConsoleAdventureRPG;

namespace PaddysConsoleAdventureRPG
{
    public class LootItem
    {
        public Item Details { get; set; }
        public int DropChance { get; set; }
        public bool IsDefaultItem { get; set; }

        public LootItem(Item details, int dropChance, bool isDefaultItem)
        {
            Details = details;
            DropChance = dropChance;
            IsDefaultItem = isDefaultItem;
        }
    }
}
