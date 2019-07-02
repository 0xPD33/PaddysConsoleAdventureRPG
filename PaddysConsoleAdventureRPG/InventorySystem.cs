using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PaddysConsoleAdventureRPG;

namespace PaddysConsoleAdventureRPG
{
    public class InventorySystem
    {
        public Item Details { get; set; }
        public int Quantity { get; set; }

        public InventorySystem(Item details, int quantity)
        {
            Details = details;
            Quantity = quantity;
        }
    }
}
