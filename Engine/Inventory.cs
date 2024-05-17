using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Inventory
    {
        public Items Details { get; set; }
        public int Quantity { get; set; }
        public List<Loot> LootTable { get; set; }
        public Inventory(Items details, int quantity)
        {
            Details = details;
            Quantity = quantity;
            LootTable = new List<Loot>();
        }
    }
}
