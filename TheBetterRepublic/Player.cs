using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBetterRepublic.Utilities
{
    public class Player : Character
    {
        public List<Inventory> items = new();
        public bool hasSword;
        public bool hasShield;

        public void AddItem (Inventory item)
        {
            items.Add(item);
        }
    }
}
